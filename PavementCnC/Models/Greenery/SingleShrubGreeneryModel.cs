using Autodesk.AutoCAD.Geometry;
using System;

namespace PavementCnC.Models;
// Layer name structure: greeneryNameStart(0) + ItemOrArea(1) + Code(2) + TypeOfGreenery(3) + GreeneryName(4) + Height(5) + StoolbedSize(6) + HasSpecialPavement(7) (1/0) + SpecialPavementName(8) + SpecialPavementAreaInM2(9)
public class SingleShrubGreeneryModel : IGreeneryItem
{
    public string GreeneryName { get; private set; }
    public double SoilAmountInM3 { get { return PitSizeInM3 - StoolbedInM3; } }
    public GreeneryType TypeOfGreenery { get; private set; } = GreeneryType.SingleShrub;
    public double PitSizeInM3 { get; private set; }
    public double StoolbedInM3 { get; private set; }
    public double Height { get; private set; }
    public bool HasSpecialPavement { get; private set; }
    public string SpecialPavementName { get; private set; }
    public double SpecialPavementAreaInM2 { get; private set; }
    public Point3d Position { get; private set; }
    public string Code { get; private set; }
    public ItemOrArea ItemOrArea { get; private set; } = ItemOrArea.Item;
    public string StoolBedSize { get; private set; }
    public bool IsInsidePlot { get; private set; }
    public double TrunkGirthInM { get; } = 0;
    public double CrownSizeInM { get; } = 0;
    public double Amount { get; } = 1;

    public SingleShrubGreeneryModel(string[] layerSplit, Point3d position, bool isInsidePlot)
    {
        Code = layerSplit[2];
        GreeneryName = layerSplit[4];
        Height = Convert.ToDouble(layerSplit[5]);
        StoolBedSize = layerSplit[6].Replace('x', 'х');
        var dim = StoolBedSize.Split('х');
        var stoolDiameter = Convert.ToDouble(dim[0]);
        var stoolHeight = Convert.ToDouble(dim[1]);
        StoolbedInM3 = Math.PI * stoolDiameter * stoolDiameter / 4 * stoolHeight;
        PitSizeInM3 = Math.PI * (stoolDiameter + 0.1) * (stoolDiameter + 0.1) / 4 * (stoolHeight + 0.1); // to variable?
        HasSpecialPavement = layerSplit[7] == "1";
        SpecialPavementName = layerSplit[8];
        SpecialPavementAreaInM2 = Convert.ToDouble(layerSplit[9]);
        Position = position;
        IsInsidePlot = isInsidePlot;
    }
}
