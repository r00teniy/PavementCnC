using Autodesk.AutoCAD.Geometry;
using System;
using System.Globalization;

namespace PavementCnC.Models;
// Layer name structure: pavementLayerStart(0) + Code(1) + typeOfPavement(2) + pointOfUse(3) + Color(4) + acceptedLoad(5)
public class AsphaltPavementModel : IPavement
{
    public PavementType TypeOfPavement { get; private set; } = PavementType.Asphalt;
    public string Code { get; private set; }
    public string FullName { get; private set; }
    public PointOfUseType PointOfUse { get; private set; }
    public double AcceptedLoad { get; private set; }
public double Amount { get; private set; }
    public bool IsInsidePlot { get; private set; }
    public Point3d Position { get; private set; }
    public string Parameters { get; private set; } = "-";
    public string Color { get; private set; }

    public AsphaltPavementModel(string[] layerSplit, double pavementArea, Point3d position, bool isInsidePlot = true)
    {
        Code = layerSplit[1];
        PointOfUse = (PointOfUseType)Array.IndexOf(Variables.pointOfUseLayer, layerSplit[3]);
        Color = layerSplit[4];
        AcceptedLoad = Convert.ToDouble(layerSplit[5], CultureInfo.InvariantCulture);
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
        FullName = $"Покрытие из асфальтобетона ({type}). Основание под нагрузку {AcceptedLoad}т/ось.";
    }
}
