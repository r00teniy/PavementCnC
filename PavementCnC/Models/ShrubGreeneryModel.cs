using Autodesk.AutoCAD.Geometry;
using System;

namespace PavementCnC.Models;
// Layer name structure: greeneryNameStart + TypeOfGreenery + GreeneryName + Age + Height + CrownSizeInM + StoolbedInM3 + PitSizeInM3 + HasSpecialPavement (1/0) + SpecialPavementName + SpecialPavementAreaInM2
public class ShrubGreeneryModel : IGreenery
{
    public string GreeneryName { get; set; }
    public double SoilAmountInM3 { get; set; }
    public GreeneryType TypeOfGreenery { get; set; }
    public double PitSizeInM3 { get; set; }
    public double StoolbedInM3 { get; set; }
    public double Age { get; set; }
    public double Height { get; set; }
    public double CrownSizeInM { get; set; }
    public bool HasSpecialPavement { get; set; }
    public string SpecialPavementName { get; set; }
    public double SpecialPavementAreaInM2 { get; set; }
    public Point3d Position { get; set; }

    public ShrubGreeneryModel(GreeneryType typeOfGreenery, string[] layerSplit, Point3d position)
    {
        GreeneryName = layerSplit[2];
        StoolbedInM3 = Convert.ToDouble(layerSplit[6]);
        PitSizeInM3 = Convert.ToDouble(layerSplit[7]);
        SoilAmountInM3 = PitSizeInM3 - StoolbedInM3;
        TypeOfGreenery = typeOfGreenery;
        Age = Convert.ToDouble(layerSplit[3]);
        Height = Convert.ToDouble(layerSplit[4]);
        CrownSizeInM = Convert.ToDouble(layerSplit[5]);
        HasSpecialPavement = layerSplit[8] == "1";
        SpecialPavementName = layerSplit[9];
        SpecialPavementAreaInM2 = Convert.ToDouble(layerSplit[10]);
        Position = position;
    }
}
