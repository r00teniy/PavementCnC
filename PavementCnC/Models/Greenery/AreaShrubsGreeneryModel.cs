using Autodesk.AutoCAD.Geometry;
using System;

namespace PavementCnC.Models;
// Layer name structure: greeneryNameStart(0) + ItemOrArea(1) + Code(2) + TypeOfGreenery(3) + GreeneryName(4) + Height(5) + Width(6) + ShrubsPerM2(7) + StoolBedSize(8) + HasSpecialPavement(9) (1/0) + SpecialPavementName(10)
public class AreaShrubsGreeneryModel : IGreeneryArea
{
    public string GreeneryName { get; private set; }
    public double Amount { get; private set; }
    public double SoilAmountInM3 { get; private set; }
    public GreeneryType TypeOfGreenery { get; private set; }
    public double Height { get; private set; }
    public double CrownSizeInM { get; private set; }
    public double NumberOfPlantsPerSQM { get; private set; }
    public int NumberOfPlants
    {
        get
        {
            return (int)Math.Ceiling(NumberOfPlantsPerSQM * Amount);
        }
    }
    public bool HasSpecialPavement { get; private set; }
    public string SpecialPavementName { get; private set; }
    public double SpecialPavementAreaInM2 { get { return Amount; } }
    public Point3d Position { get; private set; }
    public string Code { get; private set; }
    public ItemOrArea ItemOrArea { get; private set; } = ItemOrArea.Area;
    public string StoolBedSize { get; private set; }
    public bool IsInsidePlot { get; private set; }

    public AreaShrubsGreeneryModel(string[] layerSplit, Point3d position, double amount, bool isInsidePlot)
    {
        Code = layerSplit[2];
        GreeneryName = layerSplit[4];
        Amount = amount;
        TypeOfGreenery = (GreeneryType)(Array.IndexOf(Variables.typeOfAreaGreenery, layerSplit[3]) + Variables.typeOfItemGreenery.Length);
        GreeneryName= layerSplit[4];
        Height = Convert.ToDouble(layerSplit[5]);
        CrownSizeInM = Convert.ToDouble(layerSplit[6]);
        NumberOfPlantsPerSQM = Convert.ToDouble(layerSplit[7]);
        Position = position;
        SoilAmountInM3 = amount * 0.3; //change later to variable or get from type?
        StoolBedSize = layerSplit[8];
        HasSpecialPavement = layerSplit[9] == "1";
        SpecialPavementName = layerSplit[10];
        IsInsidePlot = isInsidePlot;
    }
}
