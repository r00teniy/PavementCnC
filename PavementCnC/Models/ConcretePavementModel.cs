using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavementCnC.Models
{
    internal class ConcretePavementModel : IPavement
    {
        public PavementType TypeOfPavement { get; set; }
        public string PavementTypeName { get; set; }
        public string PavementFullName { get; set; }
        public PointOfUseType PointOfUse { get; set; }
        public int AcceptedLoad { get; set; }
        public double PavementArea { get; set; }
        public string ConcreteClass { get; set; }

        public ConcretePavementModel(PavementType typeOfPavement, string pavementTypeName, PointOfUseType pointOfUse, int acceptedLoad, double pavementArea, string concreteClass)
        {
            TypeOfPavement = typeOfPavement;
            PavementTypeName = pavementTypeName;
            PointOfUse = pointOfUse;
            AcceptedLoad = acceptedLoad;
            PavementArea = pavementArea;
            ConcreteClass = concreteClass;
            PavementFullName = ""; //Add later
        }
    }
}
