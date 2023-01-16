using Autodesk.AutoCAD.Geometry;
using System;

namespace PavementCnC.Models;
// Layer name structure: greeneryNameStart + TypeOfGreenery + GreeneryName + Height + Width + ShrubsPerM2 + HasSpecialPavement (1/0) + SpecialPavementName
public class HedgeGreeneryModel : IGreenery
{
    public string GreeneryName { get; set; }
    public double GreeneryAmount { get; set; }
    public double SoilAmountInM3 { get; set; }
    public GreeneryType TypeOfGreenery { get; set; }
    public double Height { get; set; }
    public double Width { get; set; }
    public double ShrubsPerM2 { get; set; }
    public bool HasSpecialPavement { get; set; }
    public string SpecialPavementName { get; set; }
    public Point3d Position { get; set; }

    public HedgeGreeneryModel(GreeneryType typeOfGreenery, string[] layerSplit, Point3d position, double greeneryAmount)
    {
        GreeneryName = layerSplit[2];
        GreeneryAmount = greeneryAmount;
        TypeOfGreenery = typeOfGreenery;
        Height = Convert.ToDouble(layerSplit[3]);
        Width = Convert.ToDouble(layerSplit[4]);
        ShrubsPerM2 = Convert.ToDouble(layerSplit[5]);
        Position = position;
        SoilAmountInM3 = greeneryAmount * 0.3; //change later to variable or get from type?
        HasSpecialPavement = layerSplit[6] == "1";
        SpecialPavementName = layerSplit[7];
    }
}
