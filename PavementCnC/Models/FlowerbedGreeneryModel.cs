using Autodesk.AutoCAD.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavementCnC.Models;
// Layer name structure: greeneryNameStart + TypeOfGreenery + GreeneryName + FlowerSpecies + HasSpecialPavement (1/0) + SpecialPavementName
public class FlowerbedGreeneryModel : IGreenery
{
    public string GreeneryName { get; set; }
    public double GreeneryAmount { get; set; }
    public double SoilAmountInM3 { get; set; }
    public GreeneryType TypeOfGreenery { get; set; }
    public string FlowerSpecies { get; set; }
    //public bool IsInsidePlanter { get; set; } move these to furniture?
    public bool HasSpecialPavement { get; set; }
    public string SpecialPavementName { get; set; }
    public Point3d Position { get; set; }

    public FlowerbedGreeneryModel(GreeneryType typeOfGreenery, string[] layerSplit, Point3d position, double greeneryAmount)
    {
        GreeneryName = layerSplit[2];
        GreeneryAmount = greeneryAmount;
        TypeOfGreenery = typeOfGreenery;
        FlowerSpecies = layerSplit[3];
        //IsInsidePlanter = isInsidePlanter;
        SoilAmountInM3 = greeneryAmount * 0.3; //change later to variable or get from type?
        HasSpecialPavement = layerSplit[4] == "1";
        SpecialPavementName = layerSplit[5];
    }
}
