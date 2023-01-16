using Autodesk.AutoCAD.Geometry;
using System;

namespace PavementCnC.Models;
// Layer name structure: pavementLayerStart + Code + typeOfPavement + pointOfUse + tileSize + tileColor + tileManufacturer + tileCollection + acceptedLoad
public class TilesPavementModel : IPavement
{
    public PavementType TypeOfPavement { get; private set; } = PavementType.Tiles;
    public string Code { get; private set; }
    public string PavementFullName { get; private set; }
    public PointOfUseType PointOfUse { get; private set; }
    public int AcceptedLoad { get; private set; }
    public double PavementArea { get; private set; }
    public string TileSize { get; private set; }
    public string TileManufacturer { get; private set; }
    public string TileColor { get; private set; }
    public string TileCollection { get; private set; }
    public bool IsInsidePlot { get; private set; }
    public Point3d Position { get; private set; }

    public TilesPavementModel(string[] layerSplit, double pavementArea, Point3d position, bool isInsidePlot)
    {
        Code = layerSplit[1];
        PointOfUse = (PointOfUseType)Array.IndexOf(Variables.pointOfUseLayer, layerSplit[3]);
        TileSize = layerSplit[4];
        TileColor = layerSplit[5];
        TileManufacturer = layerSplit[6];
        TileCollection = layerSplit[7];
        AcceptedLoad = Convert.ToInt32(layerSplit[8]);
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
        PavementFullName = $"Покрытие из тротуарной плитки {TileManufacturer}, размер {TileSize} ({type}). Коллекция: {TileCollection}, цвет {TileColor}. Основание под нагрузку {AcceptedLoad}т/ось.";
    }
}
