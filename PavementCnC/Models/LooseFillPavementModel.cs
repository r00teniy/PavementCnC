using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavementCnC.Models
{
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

        public LooseFillPavementModel(PavementType typeOfPavement, string pavementTypeName, PointOfUseType pointOfUse, int acceptedLoad, double pavementArea, bool isInsideGeocells, string fillMaterial, string grainSize)
        {
            TypeOfPavement = typeOfPavement;
            PavementTypeName = pavementTypeName;
            PointOfUse = pointOfUse;
            AcceptedLoad = acceptedLoad;
            PavementArea = pavementArea;
            IsInsideGeocells = isInsideGeocells;
            FillMaterial = fillMaterial;
            GrainSize = grainSize;
            PavementFullName = ""; //Add later
        }
    }
}
