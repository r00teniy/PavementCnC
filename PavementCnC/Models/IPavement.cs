using Autodesk.AutoCAD.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavementCnC.Models;

public interface IPavement
{
    public PavementType TypeOfPavement { get; }
    public string Code { get; }
    public string PavementTypeName { get; }
    public string PavementFullName { get; }
    public PointOfUseType PointOfUse { get; }
    public int AcceptedLoad { get; }
    public double PavementArea { get; }
    public bool IsInsidePlot { get; }
    public Point3d Position { get; }
}
