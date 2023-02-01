using Autodesk.AutoCAD.Geometry;
// Layer name structure: greeneryLayerStart(0) + ItemOrArea(1) + Code(2) + typeOfGreenery(3) + GreeneryName(4) + isRolled(5) + SeedsDetails(6)

namespace PavementCnC.Models
{
    public class GrassGreeneryModel : IGreeneryArea
    {
        public GreeneryType TypeOfGreenery { get; private set; } = GreeneryType.Grass;
        public string GreeneryName { get; private set; }
        public string SeedsDetails { get; private set; }
        public double Amount { get; private set; }
        public bool IsRolled { get; private set; }
        public double SoilAmountInM3 { get; private set; }
        public Point3d Position { get; private set; }
        public string Code { get; private set; }
        public ItemOrArea ItemOrArea { get; private set; } = ItemOrArea.Area;
        public string StoolBedSize { get; private set; } = "";
        public bool IsInsidePlot { get; private set; }
        public double NumberOfPlantsPerSQM { get; } = 0;
        public double Height { get; } = 0;
        public double CrownSizeInM { get; } = 0;
        public bool HasSpecialPavement { get; } = false;
        public string SpecialPavementName { get; } = "";
        public double SpecialPavementAreaInM2 { get; } = 0;
        public int NumberOfPlants { get; } = 0;

        public GrassGreeneryModel(string[] splitLayer, double area, Point3d position, bool isInsidePlot)
        {
            Position = position;
            Amount = area;
            SoilAmountInM3 = area * 0.2;// Change to Variable.
            Code = splitLayer[2];
            GreeneryName = splitLayer[4];
            IsRolled = splitLayer[5] == "рулонный";
            SeedsDetails = splitLayer[6];
            IsInsidePlot = isInsidePlot;
        }
    }
}
