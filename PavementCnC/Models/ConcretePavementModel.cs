using Autodesk.AutoCAD.Geometry;
using System;

namespace PavementCnC.Models;
// Layer name structure: pavementLayerStart + Code + typeOfPavement + pointOfUse + concreteClass + acceptedLoad
public class ConcretePavementModel : IPavement
{
    public PavementType TypeOfPavement { get; private set; } = PavementType.Concrete;
    public string Code { get; private set; }
    public string PavementFullName { get; private set; }
    public PointOfUseType PointOfUse { get; private set; }
    public int AcceptedLoad { get; private set; }
    public double PavementArea { get; private set; }
    public string ConcreteClass { get; private set; }
    public bool IsInsidePlot { get; private set; }
    public Point3d Position { get; private set; }

    public ConcretePavementModel(string[] layerSplit, double pavementArea, Point3d position, bool isInsidePlot = true)
    {
        Code = layerSplit[1];
        PointOfUse = (PointOfUseType)Array.IndexOf(Variables.pointOfUseLayer, layerSplit[3]);
        ConcreteClass = layerSplit[4];
        AcceptedLoad = Convert.ToInt32(layerSplit[5]);
        PavementArea = pavementArea;
        IsInsidePlot = isInsidePlot;
        Position = position;
        var type = PointOfUse switch
        {
            PointOfUseType.Road => "проезды автотранспорта",
            PointOfUseType.Parking => "стоянки автотранспорта",
            PointOfUseType.Footpath => "тротуары и дорожки",
            PointOfUseType.FireLane => "пожарные проезды",
            PointOfUseType.PerimeterWalk => "отмостка",
            PointOfUseType.Playground => "детские площадки",
            PointOfUseType.SportZone => "спортивные площадки",
            PointOfUseType.UtilityZone => "хозяйственные площадки",
            PointOfUseType.RestZone => "площадки отдыха",
            PointOfUseType.Greenery => "территория озеленения",
            _ => throw new Exception("Неизвестное место применения")
        };
        PavementFullName = $"Покрытие из бетона {ConcreteClass} ({type}). Основание под нагрузку {AcceptedLoad}т/ось.";
    }
}
