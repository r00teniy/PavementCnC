using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavementCnC.Models
{
    internal class RubberPavementModel : IPavement
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

        public RubberPavementModel(PavementType typeOfPavement, string pavementTypeName, PointOfUseType pointOfUse, int acceptedLoad, double pavementArea, string rubberManufacturer, string rubberColor, int rubberThicknessInMM, string rubberMaterial, double safeDropHeightInM)
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
            PavementFullName = ""; //Add later
        }
    }
}
