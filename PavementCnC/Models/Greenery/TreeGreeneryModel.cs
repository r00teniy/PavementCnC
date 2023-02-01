using Autodesk.AutoCAD.Geometry;
using System;
using System.Collections.Generic;

namespace PavementCnC.Models;
// Layer name structure: greeneryNameStart(0) + ItemOrArea(1) + Code(2) + TypeOfGreenery(3) + GreeneryName(4) + Height(5) + TrunkGirthInM(6) + CrownSizeInM(7) + StoolbedSize(8) + HasSpecialPavement(9) (1/0) + SpecialPavementName(10) + SpecialPavementAreaInM2(11) + IrrigationSystem(12) + SupportSystem(13)
public class TreeGreeneryModel : IGreeneryItem
{
    public string GreeneryName { get; private set; }
    public double SoilAmountInM3 { get; private set; }
    public GreeneryType TypeOfGreenery { get; private set; }
    public double PitSizeInM3 { get; private set; }
    public double StoolbedInM3 { get; private set; }
    public double Height { get; private set; }
    public double TrunkGirthInM { get; private set; }
    public double CrownSizeInM { get; private set; }
    public string IrrigationSystem { get; private set; }
    public string SupportSystem { get; private set; }
    public bool HasSpecialPavement { get; private set; }
    public string SpecialPavementName { get; private set; }
    public double SpecialPavementAreaInM2 { get; private set; }
    public Point3d Position { get; private set; }
    public string Code { get; private set; }
    public ItemOrArea ItemOrArea { get; private set; } = ItemOrArea.Item;
    public string StoolBedSize { get; private set; }
    public bool IsInsidePlot { get; private set; }
    public double Amount { get; } = 1.0;

    public TreeGreeneryModel(string[] layerSplit, Point3d position, bool isInsidePlot)
    {
        Code = layerSplit[2];
        TypeOfGreenery = (GreeneryType)Array.IndexOf(Variables.typeOfAreaGreenery, layerSplit[3]);
        GreeneryName = layerSplit[4];
        Height = Convert.ToDouble(layerSplit[5]);
        TrunkGirthInM = Convert.ToDouble(layerSplit[6]);
        CrownSizeInM = Convert.ToDouble(layerSplit[7]);
        StoolBedSize = layerSplit[8].Replace('x','х');
        var dim = StoolBedSize.Split('х');
        var stoolDiameter = Convert.ToDouble(dim[0]);
        var stoolHeight = Convert.ToDouble(dim[1]);
        StoolbedInM3 = Math.PI * stoolDiameter * stoolDiameter / 4 * stoolHeight;
        PitSizeInM3 = Math.PI * (stoolDiameter + 0.2) * (stoolDiameter + 0.2) / 4 * (stoolHeight +0.2); // to variable?
        SoilAmountInM3 = PitSizeInM3 - StoolbedInM3;
        HasSpecialPavement = layerSplit[9] == "1";
        SpecialPavementName = layerSplit[10];
        SpecialPavementAreaInM2 = Convert.ToDouble(layerSplit[11]);
        IrrigationSystem = layerSplit[12];
        SupportSystem = layerSplit[13];
        Position = position;
        IsInsidePlot = isInsidePlot;
    }
}
