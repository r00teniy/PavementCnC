using Autodesk.AutoCAD.Geometry;
using System;

namespace PavementCnC.Models;
// Layer name structure: pavementLayerStart + Code + typeOfPavement + pointOfUse + fillMaterial + grainSize + isInsideGeoCells + acceptedLoad
public class LooseFillPavementModel : IPavement
{
    public PavementType TypeOfPavement { get; private set; } = PavementType.LooseFill;
    public string Code { get; private set; }
    public string PavementFullName { get; private set; }
    public PointOfUseType PointOfUse { get; private set; }
    public int AcceptedLoad { get; private set; }
    public double PavementArea { get; private set; }
    public bool IsInsideGeocells { get; private set; }
    public string FillMaterial { get; private set; }
    public string GrainSize { get; private set; }
    public bool IsInsidePlot { get; private set; }
    public Point3d Position { get; private set; }

    public LooseFillPavementModel(string[] layerSplit, double pavementArea, Point3d position, bool isInsidePlot = true)
    {
        Code = layerSplit[1];
        PointOfUse = (PointOfUseType)Array.IndexOf(Variables.pointOfUseLayer, layerSplit[3]);
        FillMaterial = layerSplit[4];
        GrainSize = layerSplit[5];
        IsInsideGeocells = layerSplit[6] == "в георешетке";
        AcceptedLoad = Convert.ToInt32(layerSplit[7]);
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
        PavementFullName = $"Насыпное покрытие из {FillMaterial} {GrainSize} ({type}). Основание под нагрузку {AcceptedLoad}т/ось.";
    }
}
