using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavementCnC.Models
{
    public interface IGreeneryArea : IGreenery
    {
        public double NumberOfPlantsPerSQM { get; }
        public int NumberOfPlants { get; }
    }
}
