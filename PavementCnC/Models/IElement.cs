using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavementCnC.Models;

public interface IElement
{
    public string Code { get; }
    public double Amount { get; }
    public bool IsInsidePlot { get; }
}
