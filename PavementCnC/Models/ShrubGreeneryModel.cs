using Autodesk.AutoCAD.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavementCnC.Models
{
    public class ShrubGreeneryModel : IGreenery
    {
        public string GreeneryName { get; set; }
        public double GreeneryAmount { get; set; }
        public double SoilAmountInM3 { get; set; }
        public GreeneryType TypeOfGreenery { get; set; }
        public double PitSizeInM3 { get; set; }
        public double StoolbedInM3 { get; set; }
        public double Age { get; set; }
        public double Height { get; set; }
        public double CrownSizeInM { get; set; }
        public bool HasSpecialPavement { get; set; }
        public string SpecialPavementName { get; set; }
        public Point3d Position { get; set; }

        public ShrubGreeneryModel(string greeneryName, double greeneryAmount, GreeneryType typeOfGreenery, double pitSizeInM3, double stoolbedInM3, double age, double height, double crownSizeInM, Point3d position, bool hasSpecialPavement = false, string specialPavementName = "")
        {
            GreeneryName = greeneryName;
            GreeneryAmount = greeneryAmount;
            SoilAmountInM3 = pitSizeInM3 - stoolbedInM3;
            TypeOfGreenery = typeOfGreenery;
            PitSizeInM3 = pitSizeInM3;
            StoolbedInM3 = stoolbedInM3;
            Age = age;
            Height = height;
            CrownSizeInM = crownSizeInM;
            HasSpecialPavement = hasSpecialPavement;
            SpecialPavementName = specialPavementName;
            Position = position;
        }
    }
}
