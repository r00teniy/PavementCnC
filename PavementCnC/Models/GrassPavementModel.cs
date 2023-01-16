using Autodesk.AutoCAD.Geometry;
using System;

namespace PavementCnC.Models;
// Layer name structure: pavementLayerStart + Code + typeOfPavement + pointOfUse + acceptedLoad
public class GrassPavementModel : IPavement
{
    public PavementType TypeOfPavement { get; private set; } = PavementType.Grass;
    public string Code { get; private set; }
    public string PavementFullName { get; private set; }
    public PointOfUseType PointOfUse { get; private set; }
    public int AcceptedLoad { get; private set; }
    public double PavementArea { get; private set; }
    public bool IsInsideGeocells { get; private set; } = true;
    public bool IsInsidePlot { get; private set; }
    public Point3d Position { get; private set; }

    public GrassPavementModel(string[] layerSplit, double pavementArea, Point3d position, bool isInsidePlot = true)
    {
        Code = layerSplit[1];
        PointOfUse = (PointOfUseType)Array.IndexOf(Variables.pointOfUseLayer, layerSplit[3]);
        AcceptedLoad = Convert.ToInt32(layerSplit[4]);
        PavementArea = pavementArea;
        IsInsidePlot = isInsidePlot;
        Position = position;
        var type = PointOfUse switch
        {
            PointOfUseType.FireLane => "пожарные проезды",
            PointOfUseType.Playground => "детские площадки",
            PointOfUseType.SportZone => "спортивные площадки",
            PointOfUseType.UtilityZone => "хозяйственные площадки",
            PointOfUseType.RestZone => "площадки отдыха",
            PointOfUseType.Greenery => "территория озеленения",
            _ => throw new Exception("Ееправильное место применения для газонного покрытия")
        };
        PavementFullName = $"Покрытие из газона в георешетке ({type}). Основание под нагрузку {AcceptedLoad} т/ось.";
    }
}
