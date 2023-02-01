using Autodesk.AutoCAD.Geometry;

namespace PavementCnC.Models;

public interface IPavement: IElement
{
    public PavementType TypeOfPavement { get; }
    public string FullName { get; }
    public string Parameters { get; }
    public string Color { get; }
    public PointOfUseType PointOfUse { get; }
    public double AcceptedLoad { get; }
    public Point3d Position { get; }
}
