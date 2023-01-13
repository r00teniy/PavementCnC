using Autodesk.AutoCAD.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavementCnC.Models;
// Layer name structure: pavementLayerStart + typeOfPavement + rubberMaterial + rubberManufacturer + rubberColor + pavementTypeName + pointOfUse + rubberThicknessInMM + safeDropHeightInM
public class RubberPavementModel : IPavement
{
    public PavementType TypeOfPavement { get; private set; } = PavementType.Rubber;
    public string Code { get; private set; }
    public string PavementTypeName { get; private set; }
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
        Code = layerSplit[2];
        PavementTypeName = layerSplit[6];
        PointOfUse = (PointOfUseType)Array.IndexOf(Variables.pointOfUseLayer, layerSplit[7]);
        PavementArea = pavementArea;
        RubberManufacturer = layerSplit[4];
        RubberColor = layerSplit[5];
        RubberThicknessInMM = Convert.ToInt32(layerSplit[8]);
        RubberMaterial = layerSplit[3];
        SafeDropHeightInM = Convert.ToDouble(layerSplit[9]);
        IsInsidePlot = isInsidePlot;
        Position= position;
        var type = PointOfUse switch
        {
            PointOfUseType.Playground => "детские площадки",
            PointOfUseType.SportZone => "спортивные площадки",
            _ => throw new Exception("Неизвестное место применения")
        };
        PavementFullName = $"Покрытие из {RubberMaterial} {RubberManufacturer} ({type}). Цвет: {RubberColor}, толщина {RubberThicknessInMM}мм";
    }
}
