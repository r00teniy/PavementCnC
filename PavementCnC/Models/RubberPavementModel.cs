using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavementCnC.Models
{
    public class RubberPavementModel : IPavement
    {
        public PavementType TypeOfPavement { get; set; }
        public string PavementTypeName { get; set; }
        public string PavementFullName { get; set; }
        public PointOfUseType PointOfUse { get; set; }
        public int AcceptedLoad { get; set; }
        public double PavementArea { get; set; }
        public string RubberManufacturer { get; set; }
        public string RubberColor { get; set; }
        public int RubberThicknessInMM { get; set; }
        public string RubberMaterial { get; set; }
        public double SafeDropHeightInM { get; set; }
        public bool IsInsidePlot { get; set; }

        public RubberPavementModel(PavementType typeOfPavement, string pavementTypeName, PointOfUseType pointOfUse, int acceptedLoad, double pavementArea, string rubberManufacturer, string rubberColor, int rubberThicknessInMM, string rubberMaterial, double safeDropHeightInM, bool isInsidePlot = true)
        {
            TypeOfPavement = typeOfPavement;
            PavementTypeName = pavementTypeName;
            PointOfUse = pointOfUse;
            AcceptedLoad = acceptedLoad;
            PavementArea = pavementArea;
            RubberManufacturer = rubberManufacturer;
            RubberColor = rubberColor;
            RubberThicknessInMM = rubberThicknessInMM;
            RubberMaterial = rubberMaterial;
            SafeDropHeightInM = safeDropHeightInM;
            IsInsidePlot = isInsidePlot;
            var type = PointOfUse switch
            {
                PointOfUseType.Playground => "детские площадки",
                PointOfUseType.SportZone => "спортивные площадки",
                _ => throw new Exception("Неизвестное место применения")
            };
            PavementFullName = $"Покрытие из {RubberMaterial} {RubberManufacturer} ({type}). Цвет: {RubberColor}, толщина {RubberThicknessInMM}мм";
        }
    }
}
