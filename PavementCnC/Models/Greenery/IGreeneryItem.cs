using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavementCnC.Models;

public interface IGreeneryItem : IGreenery
{
    public double TrunkGirthInM { get; }
}
