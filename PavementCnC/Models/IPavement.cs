using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavementCnC.Models
{
    public interface IPavement
    {
        public PavementType TypeOfPavement { get; set; }
        public string PavementTypeName { get; set; }
        public string PavementFullName { get; set; }
        public PointOfUseType PointOfUse { get; set; }
        public int AcceptedLoad { get; set; }
        public double PavementArea { get; set; }
    }
}
