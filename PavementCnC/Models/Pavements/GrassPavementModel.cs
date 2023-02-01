using Autodesk.AutoCAD.Geometry;
using System;
using System.Globalization;

namespace PavementCnC.Models;
// Layer name structure: pavementLayerStart(0) + Code(1) + typeOfPavement(2) + pointOfUse(3) + parameters(4) + color(5) + acceptedLoad(6)
public class GrassPavementModel : IPavement
{
    public PavementType TypeOfPavement { get; private set; } = PavementType.Grass;
    public string Code { get; private set; }
    public string FullName { get; private set; }
    public PointOfUseType PointOfUse { get; private set; }
    public double Amount { get; private set; }
    public bool IsInsideGeocells { get; private set; } = true;
    public bool IsInsidePlot { get; private set; }
    public Point3d Position { get; private set; }
    public string Parameters { get; private set; }
    public string Color { get; private set; }
    public double AcceptedLoad { get; private set; }

    public GrassPavementModel(string[] layerSplit, double pavementArea, Point3d position, bool isInsidePlot)
    {
        Code = layerSplit[1];
        PointOfUse = (PointOfUseType)Array.IndexOf(Variables.pointOfUseLayer, layerSplit[3]);
        Parameters = layerSplit[4];
        Color = layerSplit[5];
        AcceptedLoad = Convert.ToDouble(layerSplit[6], CultureInfo.InvariantCulture);
        Amount = pavementArea;
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
            _ => throw new Exception("Неправильное место применения для газонного покрытия")
        };
        FullName = $"Покрытие из газона в георешетке ({type}). Основание под нагрузку {AcceptedLoad} т/ось.";
    }
}
