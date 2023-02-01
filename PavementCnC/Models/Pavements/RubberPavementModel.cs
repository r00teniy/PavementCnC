using Autodesk.AutoCAD.Geometry;
using System;

namespace PavementCnC.Models;
// Layer name structure: pavementLayerStart(0) + Code(1) + typeOfPavement(2) + pointOfUse(3) + material(4) + manufacturer(5) + color(6) + modelName(7) + parameters(8) + safeDropHeightInM(9)
public class RubberPavementModel : IPavement
{
    public PavementType TypeOfPavement { get; private set; } = PavementType.Rubber;
    public string Code { get; private set; }
    public string FullName { get; private set; }
    public PointOfUseType PointOfUse { get; private set; }
    public double AcceptedLoad { get; private set; } = 0;
    public double Amount { get; private set; }
    public string Manufacturer { get; private set; }
    public string Color { get; private set; }
    public string ModelName { get; private set; }
    public string Parameters { get; private set; }
    public string Material { get; private set; }
    public double SafeDropHeightInM { get; private set; }
    public bool IsInsidePlot { get; private set; }
    public Point3d Position { get; private set; }

    public RubberPavementModel(string[] layerSplit, double pavementArea, Point3d position, bool isInsidePlot = true)
    {
        Code = layerSplit[1];
        PointOfUse = (PointOfUseType)Array.IndexOf(Variables.pointOfUseLayer, layerSplit[3]);
        Material = layerSplit[4];
        Manufacturer = layerSplit[5];
        Color = layerSplit[6];
        ModelName = layerSplit[7];
        Parameters = layerSplit[8];
        SafeDropHeightInM = Convert.ToDouble(layerSplit[9]);
        Amount = pavementArea;
        IsInsidePlot = isInsidePlot;
        Position = position;
        var type = PointOfUse switch
        {
            PointOfUseType.Playground => "детские площадки",
            PointOfUseType.SportZone => "спортивные площадки",
            _ => throw new Exception("Неправильное место применения дял резинового покрытия")
        };
        FullName = $"Покрытие из {Material} {Manufacturer} ({type}). Безопасная высота падения {SafeDropHeightInM}м";
    }
}
