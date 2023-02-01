using Autodesk.AutoCAD.Geometry;

namespace PavementCnC.Models;

public interface IGreenery : IElement
{
    public string GreeneryName { get; }
    public double SoilAmountInM3 { get; }
    public string StoolBedSize { get; }
    public GreeneryType TypeOfGreenery { get; }
    public ItemOrArea ItemOrArea { get; }
    public Point3d Position { get; }
    public bool HasSpecialPavement { get; }
    public string SpecialPavementName { get; }
    public double SpecialPavementAreaInM2 { get; }
    public double Height { get; }
    public double CrownSizeInM { get; }
}
