using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavementCnC.Models;
// Layer name structure: pavementLayerStart + typeOfPavement + fillMaterial + isInsideGeoCells + pavementTypeName + pointOfUse + acceptedLoad + grainSize
public class LooseFillPavementModel : IPavement
{
    public PavementType TypeOfPavement { get; set; }
    public string PavementTypeName { get; set; }
    public string PavementFullName { get; set; }
    public PointOfUseType PointOfUse { get; set; }
    public int AcceptedLoad { get; set; }
    public double PavementArea { get; set; }
    public bool IsInsideGeocells { get; set; }
    public string FillMaterial { get; set; }
    public string GrainSize { get; set; }
    public bool IsInsidePlot { get; set; }

    public LooseFillPavementModel(PavementType typeOfPavement, string pavementTypeName, PointOfUseType pointOfUse, int acceptedLoad, double pavementArea, bool isInsideGeocells, string fillMaterial, string grainSize, bool isInsidePlot = true)
    {
        TypeOfPavement = typeOfPavement;
        PavementTypeName = pavementTypeName;
        PointOfUse = pointOfUse;
        AcceptedLoad = acceptedLoad;
        PavementArea = pavementArea;
        IsInsideGeocells = isInsideGeocells;
        FillMaterial = fillMaterial;
        GrainSize = grainSize;
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
        PavementFullName = $"Насыпное покрытие из {FillMaterial} {GrainSize} ({type}). Основание под нагрузку {AcceptedLoad}т/ось.";
    }
}
