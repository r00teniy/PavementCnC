using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavementCnC.Models;

public class HedgeGreeneryModel : IGreenery
{
    public string GreeneryName { get; set; }
    public double GreeneryAmount { get; set; }
    public double SoilAmountInM3 { get; set; }
    public GreeneryType TypeOfGreenery { get; set; }
    public double Height { get; set; }
    public double Width { get; set; }
    public double ShrubsPerM2 { get; set; }

    public HedgeGreeneryModel(string greeneryName, double greeneryAmount, GreeneryType typeOfGreenery, double height, double width, double shrubsPerM2)
    {
        GreeneryName = greeneryName;
        GreeneryAmount = greeneryAmount;
        TypeOfGreenery = typeOfGreenery;
        Height = height;
        Width = width;
        ShrubsPerM2 = shrubsPerM2;
        SoilAmountInM3 = 0; //Add later
    }
}
