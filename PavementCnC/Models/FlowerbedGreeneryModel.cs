using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavementCnC.Models;

public class FlowerbedGreeneryModel : IGreenery
{
    public string GreeneryName { get; set; }
    public double GreeneryAmount { get; set; }
    public double SoilAmountInM3 { get; set; }
    public GreeneryType TypeOfGreenery { get; set; }
    public string FlowerSpecies { get; set; }
    public bool IsInsidePlanter { get; set; }

    public FlowerbedGreeneryModel(string greeneryName, double greeneryAmount, GreeneryType typeOfGreenery, string flowerSpecies, bool isInsidePlanter = false)
    {
        GreeneryName = greeneryName;
        GreeneryAmount = greeneryAmount;
        TypeOfGreenery = typeOfGreenery;
        FlowerSpecies = flowerSpecies;
        IsInsidePlanter = isInsidePlanter;
        SoilAmountInM3 = 0; //Add later
    }
}
