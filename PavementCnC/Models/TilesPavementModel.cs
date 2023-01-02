using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavementCnC.Models;
// Layer name structure: pavementLayerStart + typeOfPavement + tileSize + tileColor + pavementTypeName + pointOfUse + acceptedLoad + tileManufacturer + tileCollection
public class TilesPavementModel : IPavement
{
    public PavementType TypeOfPavement { get; set; }
    public string PavementTypeName { get; set; }
    public string PavementFullName { get; set; }
    public PointOfUseType PointOfUse { get; set; }
    public int AcceptedLoad { get; set; }
    public double PavementArea { get; set; }
    public string TileSize { get; set; }
    public string TileManufacturer { get; set; }
    public string TileColor { get; set; }
    public string TileCollection { get; set; }
    public bool IsInsidePlot { get; set; }

    public TilesPavementModel(PavementType typeOfPavement, string pavementTypeName, PointOfUseType pointOfUse, int acceptedLoad, double pavementArea, string tileSize, string tileManufacturer, string tileColor, string tileCollection, bool isInsidePlot = true)
    {
        TypeOfPavement = typeOfPavement;
        PavementTypeName = pavementTypeName;
        PointOfUse = pointOfUse;
        AcceptedLoad = acceptedLoad;
        PavementArea = pavementArea;
        TileSize = tileSize;
        TileManufacturer = tileManufacturer;
        TileColor = tileColor;
        TileCollection = tileCollection;
        IsInsidePlot = isInsidePlot;
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
