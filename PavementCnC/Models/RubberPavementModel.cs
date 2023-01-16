using Autodesk.AutoCAD.Geometry;
using System;

namespace PavementCnC.Models;
// Layer name structure: pavementLayerStart + Code + typeOfPavement + pointOfUse + rubberMaterial + rubberManufacturer + rubberColor + rubberThicknessInMM + safeDropHeightInM
public class RubberPavementModel : IPavement
{
    public PavementType TypeOfPavement { get; private set; } = PavementType.Rubber;
    public string Code { get; private set; }
    public string PavementFullName { get; private set; }
    public PointOfUseType PointOfUse { get; private set; }
    public int AcceptedLoad { get; private set; } = 0;
    public double PavementArea { get; private set; }
    public string RubberManufacturer { get; private set; }
    public string RubberColor { get; private set; }
    public int RubberThicknessInMM { get; private set; }
    public string RubberMaterial { get; private set; }
    public double SafeDropHeightInM { get; private set; }
    public bool IsInsidePlot { get; private set; }
    public Point3d Position { get; private set; }

    public RubberPavementModel(string[] layerSplit, double pavementArea, Point3d position, bool isInsidePlot = true)
    {
        Code = layerSplit[1];
        PointOfUse = (PointOfUseType)Array.IndexOf(Variables.pointOfUseLayer, layerSplit[3]);
        RubberMaterial = layerSplit[4];
        RubberManufacturer = layerSplit[5];
        RubberColor = layerSplit[6];
        RubberThicknessInMM = Convert.ToInt32(layerSplit[7]);
        SafeDropHeightInM = Convert.ToDouble(layerSplit[8]);
        PavementArea = pavementArea;
        IsInsidePlot = isInsidePlot;
        Position = position;
        var type = PointOfUse switch
        {
            PointOfUseType.Playground => "детские площадки",
            PointOfUseType.SportZone => "спортивные площадки",
            _ => throw new Exception("Неправильное место применения дял резинового покрытия")
        };
        PavementFullName = $"Покрытие из {RubberMaterial} {RubberManufacturer} ({type}). Цвет: {RubberColor}, толщина {RubberThicknessInMM}мм";
    }
}
