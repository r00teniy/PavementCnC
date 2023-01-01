using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavementCnC.Models
{
    public interface IGreenery
    {
        public string GreeneryName { get; set; }
        public double GreeneryAmount { get; set; }
        public double SoilAmountInM3 { get; set; }
        public GreeneryType TypeOfGreenery { get; set; }
    }
}
