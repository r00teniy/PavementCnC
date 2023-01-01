using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavementCnC.Models
{
    internal class GrassPavementType : IPavement
    {
        public PavementType TypeOfPavement { get; set; }
        public string PavementTypeName { get; set; }
        public string PavementFullName { get; set; }
        public PointOfUseType PointOfUse { get; set; }
        public int AcceptedLoad { get; set; }
        public double PavementArea { get; set; }
        public bool IsInsideGeocells { get; set; }
        public bool IsRolled { get; set; }

        public GrassPavementType(PavementType typeOfPavement, string pavementTypeName, PointOfUseType pointOfUse, int acceptedLoad, double pavementArea, bool isInsideGeocells, bool isRolled)
        {
            TypeOfPavement = typeOfPavement;
            PavementTypeName = pavementTypeName;
            PointOfUse = pointOfUse;
            AcceptedLoad = acceptedLoad;
            PavementArea = pavementArea;
            IsInsideGeocells = isInsideGeocells;
            IsRolled = isRolled;
            PavementFullName = ""; //Add later
        }
    }
}
