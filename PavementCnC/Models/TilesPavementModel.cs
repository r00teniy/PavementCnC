using Autodesk.AutoCAD.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavementCnC.Models;
// Layer name structure: pavementLayerStart + typeOfPavement + Code + tileSize + tileColor + pavementTypeName + pointOfUse + acceptedLoad + tileManufacturer + tileCollection
public class TilesPavementModel : IPavement
{
    public PavementType TypeOfPavement { get; private set; } = PavementType.Tiles;
    public string Code { get; private set; }
    public string PavementTypeName { get; private set; }
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

    public TilesPavementModel(string[] layerSplit, double pavementArea, Point3d position, bool isInsidePlot = true)
    {
        Code = layerSplit[2];
        PavementTypeName = layerSplit[5];
        PointOfUse = (PointOfUseType)Array.IndexOf(Variables.pointOfUseLayer, layerSplit[6]);
        AcceptedLoad = Convert.ToInt32(layerSplit[7]);
        PavementArea = pavementArea;
        TileSize = layerSplit[3];
        TileManufacturer = layerSplit[8];
        TileColor = layerSplit[4];
        TileCollection = layerSplit[9];
        IsInsidePlot = isInsidePlot;
        Position= position;
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
