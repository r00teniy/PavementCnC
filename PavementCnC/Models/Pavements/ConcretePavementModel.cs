using Autodesk.AutoCAD.Geometry;
using System;
using System.Globalization;

namespace PavementCnC.Models;
// Layer name structure: pavementLayerStart(0) + Code(1) + typeOfPavement(2) + pointOfUse(3) + concreteClass(4) + Color(5) acceptedLoad(6)
public class ConcretePavementModel : IPavement
{
    public PavementType TypeOfPavement { get; private set; } = PavementType.Concrete;
    public string Code { get; private set; }
    public string FullName { get; private set; }
    public PointOfUseType PointOfUse { get; private set; }
    public double Amount { get; private set; }
    public string ConcreteClass { get; private set; }
    public bool IsInsidePlot { get; private set; }
    public Point3d Position { get; private set; }
    public string Parameters { get; private set; } = "-";
    public string Color { get; private set; }
    public double AcceptedLoad { get; private set; }

    public ConcretePavementModel(string[] layerSplit, double pavementArea, Point3d position, bool isInsidePlot = true)
    {
        Code = layerSplit[1];
        PointOfUse = (PointOfUseType)Array.IndexOf(Variables.pointOfUseLayer, layerSplit[3]);
        ConcreteClass = layerSplit[4];
        Color = layerSplit[5];
        AcceptedLoad = Convert.ToDouble(layerSplit[6], CultureInfo.InvariantCulture);
        Amount = pavementArea;
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
        FullName = $"Покрытие из бетона {ConcreteClass} ({type}). Основание под нагрузку {AcceptedLoad}т/ось.";
    }
}
