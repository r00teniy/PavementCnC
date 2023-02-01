using Autodesk.AutoCAD.Geometry;
using System;

namespace PavementCnC.Models;
// Layer name structure: greeneryNameStart(0) + ItemOrArea(1) + Code(2) + TypeOfGreenery(3) + GreeneryName(4) + StoolbedSize (5) + NumberOfPlantsPerSQM(6) + HasSpecialPavement(7) + SpecialPavementName(8)
public class FlowerbedGreeneryModel : IGreeneryArea
{
    public string Code { get; private set; }
    public string GreeneryName { get; private set; }
    public double Amount { get; private set; }
    public double SoilAmountInM3 { get; private set; }
    public GreeneryType TypeOfGreenery { get; private set; }
    public ItemOrArea ItemOrArea { get; private set; } = ItemOrArea.Area;
    public double NumberOfPlantsPerSQM { get; private set; }
    public int NumberOfPlants { get
        {
            return (int)Math.Ceiling(NumberOfPlantsPerSQM * Amount);
        }
    }
    //public string FlowerSpecies { get; private set; } not needed for now
    //public bool IsInsidePlanter { get; set; } move these to furniture?
    public bool HasSpecialPavement { get; private set; }
    public string SpecialPavementName { get; private set; }
    public double SpecialPavementAreaInM2 { get; private set; }
    public Point3d Position { get; private set; }
    public string StoolBedSize { get; private set; }
    public bool IsInsidePlot { get; private set; }
    public double Height { get; } = 0;
    public double CrownSizeInM { get; } = 0;

    public FlowerbedGreeneryModel(string[] layerSplit, double greeneryAmount, Point3d position, bool isInsidePlot)
    {
        Code = layerSplit[2];
        TypeOfGreenery = (GreeneryType)(Array.IndexOf(Variables.typeOfAreaGreenery, layerSplit[3]) + Variables.typeOfItemGreenery.Length);
        GreeneryName = layerSplit[4];
        StoolBedSize = layerSplit[5];
        NumberOfPlantsPerSQM = Convert.ToDouble(layerSplit[6]);
        HasSpecialPavement = layerSplit[7] == "1";
        SpecialPavementName = layerSplit[8];
        SoilAmountInM3 = greeneryAmount * 0.3; //change later to variable or get from type?
        Amount = greeneryAmount;
        SpecialPavementAreaInM2 = greeneryAmount;
        Position = position;
        IsInsidePlot = isInsidePlot;
    }
}
