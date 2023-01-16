using Autodesk.AutoCAD.Geometry;

namespace PavementCnC.Models;

public interface IPavement
{
    public PavementType TypeOfPavement { get; }
    public string Code { get; }
    public string PavementFullName { get; }
    public PointOfUseType PointOfUse { get; }
    public int AcceptedLoad { get; }
    public double PavementArea { get; }
    public bool IsInsidePlot { get; }
    public Point3d Position { get; }
}
