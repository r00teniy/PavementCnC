using Autodesk.AutoCAD.Geometry;

namespace PavementCnC.Models;

public interface IGreenery
{
    public string GreeneryName { get; set; }
    public double SoilAmountInM3 { get; set; }
    public GreeneryType TypeOfGreenery { get; set; }
    public Point3d Position { get; set; }
}
