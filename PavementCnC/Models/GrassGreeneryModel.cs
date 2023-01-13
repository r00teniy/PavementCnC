using Autodesk.AutoCAD.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Layer name structure: greeneryLayerStart + typeOfGreenery + GreeneryName + isRolled + SeedsDetails

namespace PavementCnC.Models
{
    public class GrassGreeneryModel : IGreenery
    {
        public GreeneryType TypeOfGreenery { get; set; }
        public string GreeneryName { get; set; }
        public string SeedsDetails { get; set; }
        public double GreeneryAmount { get; set; }
        public bool IsRolled { get; set; }
        public double SoilAmountInM3 { get; set; }
        public Point3d Position { get; set; }
        public GrassGreeneryModel(GreeneryType typeOfGreenery, string[] splitLayer, double area, Point3d position)
        {
            Position= position;
            GreeneryAmount= area;
            TypeOfGreenery= typeOfGreenery;
            GreeneryName= splitLayer[2];
            IsRolled = splitLayer[3] == "рулонный";
            SeedsDetails= splitLayer[4];
        }
    }
}
