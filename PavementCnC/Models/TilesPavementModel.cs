using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavementCnC.Models
{
    internal class TilesPavementModel : IPavement
    {
        public PavementType TypeOfPavement { get; set; }
        public string PavementTypeName { get; set; }
        public string PavementFullName { get; set; }
        public PointOfUseType PointOfUse { get; set; }
        public int AcceptedLoad { get; set; }
        public double PavementArea { get; set; }
        public string TileSize { get; set; }
        public string TileManufacturer { get; set; }
        public string TileColor { get; set; }
        public string TileCollection { get; set; }

        public TilesPavementModel(PavementType typeOfPavement, string pavementTypeName, PointOfUseType pointOfUse, int acceptedLoad, double pavementArea, string tileSize, string tileManufacturer, string tileColor, string tileCollection)
        {
            TypeOfPavement = typeOfPavement;
            PavementTypeName = pavementTypeName;
            PointOfUse = pointOfUse;
            AcceptedLoad = acceptedLoad;
            PavementArea = pavementArea;
            TileSize = tileSize;
            TileManufacturer = tileManufacturer;
            TileColor = tileColor;
            TileCollection = tileCollection;
            PavementFullName = ""; //Add later
        }
    }
}
