using Autodesk.AutoCAD.Geometry;
using System;
using System.Globalization;

namespace PavementCnC.Models;
// Layer name structure: pavementLayerStart(0) + Code(1) + typeOfPavement(2) + pointOfUse(3) + fillMaterial(4) + parameters(5) + isInsideGeoCells(6) + Color(7) + acceptedLoad(8)
public class LooseFillPavementModel : IPavement
{
    public PavementType TypeOfPavement { get; private set; } = PavementType.LooseFill;
    public string Code { get; private set; }
    public string FullName { get; private set; }
    public PointOfUseType PointOfUse { get; private set; }
    public double AcceptedLoad { get; private set; }
    public double Amount { get; private set; }
    public bool IsInsideGeocells { get; private set; }
    public string FillMaterial { get; private set; }
    public string Parameters { get; private set; }
    public bool IsInsidePlot { get; private set; }
    public Point3d Position { get; private set; }
    public string Color { get; private set; }

    public LooseFillPavementModel(string[] layerSplit, double pavementArea, Point3d position, bool isInsidePlot)
    {
        Code = layerSplit[1];
        PointOfUse = (PointOfUseType)Array.IndexOf(Variables.pointOfUseLayer, layerSplit[3]);
        FillMaterial = layerSplit[4];
        Parameters = layerSplit[5];
        IsInsideGeocells = layerSplit[6] == "в георешетке";
        Color = layerSplit[7];
        AcceptedLoad = Convert.ToDouble(layerSplit[8], CultureInfo.InvariantCulture);
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
        FullName = $"Насыпное покрытие из {FillMaterial} ({type}). Основание под нагрузку {AcceptedLoad}т/ось.";
    }
}
