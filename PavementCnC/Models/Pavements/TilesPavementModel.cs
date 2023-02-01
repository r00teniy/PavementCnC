using Autodesk.AutoCAD.Geometry;
using System;

namespace PavementCnC.Models;
// Layer name structure: pavementLayerStart(0) + Code(1) + typeOfPavement(2) + pointOfUse(3) + tileSize(4) + tileColor(5) + tileManufacturer(6) + tileCollection(7) + acceptedLoad(8)
public class TilesPavementModel : IPavement
{
    public PavementType TypeOfPavement { get; private set; } = PavementType.Tiles;
    public string Code { get; private set; }
    public string FullName { get; private set; }
    public PointOfUseType PointOfUse { get; private set; }
    public double AcceptedLoad { get; private set; }
    public double Amount { get; private set; }
    public string Parameters { get; private set; }
    public string Manufacturer { get; private set; }
    public string Color { get; private set; }
    public string Collection { get; private set; }
    public bool IsInsidePlot { get; private set; }
    public Point3d Position { get; private set; }

    public TilesPavementModel(string[] layerSplit, double pavementArea, Point3d position, bool isInsidePlot)
    {
        Code = layerSplit[1];
        PointOfUse = (PointOfUseType)Array.IndexOf(Variables.pointOfUseLayer, layerSplit[3]);
        Parameters = layerSplit[4];
        Color = layerSplit[5];
        Manufacturer = layerSplit[6];
        Collection = layerSplit[7];
        AcceptedLoad = Convert.ToInt32(layerSplit[8]);
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
        FullName = $"Покрытие из тротуарной плитки {Manufacturer}, размер {Parameters} ({type}). Коллекция: {Collection}, цвет {Color}. Основание под нагрузку {AcceptedLoad}т/ось.";
    }
}
