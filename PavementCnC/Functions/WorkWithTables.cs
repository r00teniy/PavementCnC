using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using PavementCnC.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PavementCnC.Functions;

internal class WorkWithTables
{
    public static void CreateAutocadTable(string title, List<string[]> data)
    {
        Document doc = Application.DocumentManager.MdiActiveDocument;
        Database db = doc.Database;
        using (Transaction tr = db.TransactionManager.StartTransaction())
        {
            using (DocumentLock acLckDoc = doc.LockDocument())
            {
                var bT = (BlockTable)tr.GetObject(db.BlockTableId, OpenMode.ForRead);
                var bTr = (BlockTableRecord)tr.GetObject(bT[BlockTableRecord.ModelSpace], OpenMode.ForWrite);
                ObjectId tbSt = new ObjectId();
                DBDictionary tsd = (DBDictionary)tr.GetObject(db.TableStyleDictionaryId, OpenMode.ForRead);
                foreach (DBDictionaryEntry entry in tsd)
                {
                    var tStyle = (TableStyle)tr.GetObject(entry.Value, OpenMode.ForRead);
                    if (tStyle.Name == Variables.tableStyleName)
                    { tbSt = entry.Value; }
                }
                //Creating table
                Table tb = new Table()
                {
                    TableStyle = tbSt,
                    Position = ImportFromAutocad.GetInsertionPoint()
                };
                //Creating title
                tb.Rows[0].Style = "Название";
                tb.Cells[0, 0].TextString = title;
                tb.SetColumnWidth(20);
                //Creating header
                tb.InsertRows(1, 15, 1);
                tb.Rows[1].Style = "Заголовок";
                tb.InsertColumns(1, 80, data[0].Length - 1);
                //Creating Data
                tb.SetRowHeight(8);
                var currentRow = 1;
                //Creating rows
                foreach (var entry in data)
                {
                    currentRow++;
                    tb.InsertRows(currentRow, 8, 1);
                    tb.Rows[currentRow].Style = "Данные";
                    var currentCollumn = 0;
                    foreach (var cell in entry)
                    {
                        if (cell != null)
                        {
                            tb.Cells[currentRow, currentCollumn].TextString = cell;
                        }
                        else
                        {
                            tb.Cells[currentRow, currentCollumn].TextString = "-";
                        }
                        
                        currentCollumn++;
                    }
                }
                //Adding table to drawing
                tb.GenerateLayout();
                bTr.AppendEntity(tb);
                tr.AddNewlyCreatedDBObject(tb, true);
            }
            tr.Commit();
        }
    }
    internal static List<string[]> CreateTableData<T>(TableType type, List<T> list) where T : IElement
    {
        var output = new List<string[]>();
        switch (type)
        {
            case TableType.Curbs:
                output.Add(Variables.curbsHeader);
                List<string> curbCodes = list.Select(x => x.Code).Distinct().ToList();
                curbCodes.Sort();
                foreach (var curbCode in curbCodes)
                {
                    output.Add(CreateTableRow(Variables.curbsHeader.Length, type, list, curbCode));
                }
                break;
            case TableType.Pavements:
                output.Add(Variables.pavementHeader);
                List<string> pavementCodes = list.Select(x => x.Code).Distinct().ToList();
                pavementCodes.Sort();
                foreach (var pavementCode in pavementCodes)
                {
                    output.Add(CreateTableRow(Variables.pavementHeader.Length, type, list, pavementCode));
                }
                break;
            case TableType.ItemGreenery:
                output.Add(Variables.GreeneryItemHeader);
                List<string> greeneryItemCodes = list.Select(x => x.Code).Distinct().ToList();
                greeneryItemCodes.Sort();
                foreach (var greeneryItemCode in greeneryItemCodes)
                {
                    output.Add(CreateTableRow(Variables.GreeneryItemHeader.Length, type, list, greeneryItemCode));
                }
                break;
            case TableType.AreaGreenery:
                output.Add(Variables.GreeneryAreaHeader);
                var notGrassList = list.Where(x => x is not GrassGreeneryModel).ToList();
                List<string> greeneryAreaCodes = notGrassList.Select(x => x.Code).Distinct().ToList();
                greeneryAreaCodes.Sort();
                foreach (var greeneryAreaCode in greeneryAreaCodes)
                {
                    output.Add(CreateTableRow(Variables.GreeneryAreaHeader.Length, type, list, greeneryAreaCode));
                }
                break;
            case TableType.GrassGreenery:
                output.Add(Variables.GreeneryGrassHeader);
                var grassList = list.Where(x => x is GrassGreeneryModel).ToList();
                List<string> grassAreaCodes = grassList.Select(x => x.Code).Distinct().ToList();
                grassAreaCodes.Sort();
                foreach (var grassAreaCode in grassAreaCodes)
                {
                    output.Add(CreateTableRow(Variables.GreeneryGrassHeader.Length, type, list, grassAreaCode));
                }
                break;
            case TableType.StreetFurniture:
                output.Add(Variables.streetFurnitureHeader);
                List<string> furnitureCodes = list.Select(x => x.Code).Distinct().ToList();
                furnitureCodes.Sort();
                foreach (var code in furnitureCodes)
                {
                    output.Add(CreateTableRow(Variables.streetFurnitureHeader.Length, type, list, code));
                }
                break;
            case TableType.EarthVolumes:
                break;
        }
        return output;
    }
    internal static string[] CreateTableRow<T>(int numberOfCollumns, TableType type, List<T> list, string code) where T : IElement
    {
        var elements = list.Where(x => x.Code == code).ToList();
        switch (type)
        {
            case TableType.Curbs:
                var curb = elements[0] as CurbModel;
                return new string[] { "", curb.Code, curb.CurbFullName, curb.CurbSize, curb.CurbColor, Math.Ceiling(elements.Sum(x => x.Amount)).ToString(), "" };
            case TableType.Pavements:
                var pavement = elements[0] as IPavement;
                return new string[] { "", pavement.Code, Variables.pointOfUseText[(int)pavement.PointOfUse], pavement.FullName, pavement.Parameters, pavement.Color, elements.Sum(x => x.Amount).ToString("{0.##}"), "" };
            case TableType.ItemGreenery:
                var greeneryItems = elements as List<IGreeneryItem>;
                var specialPavementAreaGI = greeneryItems[0].HasSpecialPavement ? greeneryItems.Sum(x => x.SpecialPavementAreaInM2).ToString("{0.##}") : " ";
                return new string[] { "", greeneryItems[0].Code, greeneryItems[0].GreeneryName, greeneryItems[0].Height.ToString(), greeneryItems[0].TrunkGirthInM.ToString(), greeneryItems[0].CrownSizeInM.ToString(), greeneryItems[0].StoolBedSize, greeneryItems.Sum(x => x.Amount).ToString(), greeneryItems[0].HasSpecialPavement ? greeneryItems[0].SpecialPavementName : " ", specialPavementAreaGI, "" };
            case TableType.AreaGreenery:
                var greeneryArea = elements as List<IGreeneryArea>;
                var heightPlusCrownSize = greeneryArea[0].Height == 0 ? "-" : greeneryArea[0].Height.ToString() + " / " + greeneryArea[0].CrownSizeInM.ToString();
                var specialPavementArea = greeneryArea[0].HasSpecialPavement ? greeneryArea.Sum(x => x.SpecialPavementAreaInM2).ToString("{0.##}") : " ";
                return new string[] { "", greeneryArea[0].Code, greeneryArea[0].GreeneryName, heightPlusCrownSize, greeneryArea[0].StoolBedSize, greeneryArea.Sum(x => x.Amount).ToString("{0.##}"), greeneryArea[0].NumberOfPlantsPerSQM.ToString(), greeneryArea.Sum(x => x.NumberOfPlants).ToString(), greeneryArea[0].HasSpecialPavement ? greeneryArea[0].SpecialPavementName : " ", specialPavementArea, "" };
            case TableType.GrassGreenery:
                var grass = elements[0] as GrassGreeneryModel;
                return new string[] { "", grass.Code, grass.GreeneryName, grass.SeedsDetails, elements.Sum(x => x.Amount).ToString("{0.##}"), "" };
            case TableType.StreetFurniture:
                var furniture = elements[0] as StreetFurnitureModel;
                return new string[] { "", furniture.Code, furniture.FullName, elements.Count.ToString(), furniture.SafeDropHeight.ToString(), furniture.MountType, "" };
            default: return new string[5];

        }
    }
}
