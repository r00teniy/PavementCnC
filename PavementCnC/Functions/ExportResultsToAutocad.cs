using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Colors;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using System;
using System.Collections.Generic;

namespace PavementCnC.Functions;
public static class ExportResultsToAutocad
{
    static Document doc = Application.DocumentManager.MdiActiveDocument;
    static Database db = Application.DocumentManager.MdiActiveDocument.Database;
    public static void CreateLayerIfDontExist(string layerName, Color color, LineWeight lw, int transp)
    {
        using (DocumentLock lk = doc.LockDocument())
        {
            using (Transaction tr = db.TransactionManager.StartTransaction())
            {
                LayerTable lt = (LayerTable)tr.GetObject(db.LayerTableId, OpenMode.ForWrite);
                if (!lt.Has(layerName)) //Checking if layer already exist
                {
                    LayerTableRecord newLayer = new LayerTableRecord()
                    {
                        Name = layerName,
                        Color = color,
                        LineWeight = lw,
                        IsPlottable = true
                    };
                    lt.UpgradeOpen();
                    lt.Add(newLayer);
                    tr.AddNewlyCreatedDBObject(newLayer, true);
                    newLayer.Transparency = new Transparency((byte)(255 * (100 - transp) / 100));
                }
                tr.Commit();
            }
        }
    }
    //Create Mleaders for everything
    //Create hatch  based on layer? pattern/size/color?
    public static void CreateNewHatch(string layerSt, string[] layerParts, Dictionary<string,string> style)
    {
        ObjectId? objId = null;
        while (objId == null)
        {
            objId = ImportFromAutocad.GetObjectIdOfEntity<Polyline>("Polyline");
        }
        ObjectIdCollection ObjIds = new ObjectIdCollection();
        ObjIds.Add((ObjectId)objId);
        using (DocumentLock lk = doc.LockDocument())
        {
            using (Transaction tr = db.TransactionManager.StartTransaction())
            {
                var bT = (BlockTable)tr.GetObject(db.BlockTableId, OpenMode.ForRead);
                var btr = (BlockTableRecord)tr.GetObject(bT[BlockTableRecord.ModelSpace], OpenMode.ForWrite);
                Hatch oHatch = new Hatch();
                oHatch.SetHatchPattern(HatchPatternType.UserDefined, style["patName"]);
                // set other properties  
                Vector3d normal = new Vector3d(0.0, 0.0, 1.0);
                oHatch.Normal = normal;
                oHatch.Elevation = 0.0;
                oHatch.PatternScale = Double.Parse(style["scale"]);
                oHatch.PatternAngle = 0.0;
                oHatch.ColorIndex = 7;
                oHatch.BackgroundColor = Color.FromColorIndex(ColorMethod.ByLayer, 256);
                oHatch.Transparency = new Transparency(TransparencyMethod.ByLayer);
                oHatch.Layer = layerSt+"+"+string.Join("+",layerParts);
                // !!IMPORTANT You must reaffirm the hatch pattern  
                //oHatch.SetHatchPattern(HatchPatternType.UserDefined, "SOLID");
                // Then you can proceed as normal  
                btr.AppendEntity(oHatch);
                tr.AddNewlyCreatedDBObject(oHatch, true);

                oHatch.Associative = true;
                oHatch.AppendLoop(HatchLoopTypes.External, ObjIds);
                oHatch.EvaluateHatch(true);

                tr.Commit();
            }
        }
    }
}

