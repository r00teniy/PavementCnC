using Autodesk.AutoCAD.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavementCnC.Models
{
    public class StreetFurnitureModel
    {
        public StreetFurnitureType TypeOfFurniture { get; set; }
        public string FurnitureName { get; set; }
        public string FurnitureManufacturer { get; set; }
        public string FurnitureId { get; set; }
        public double DropHeight { get; set; }
        public Point3d Position { get; set; }
        //do we need foundation prop?

        public StreetFurnitureModel(StreetFurnitureType typeOfFurniture, string furnitureName, string furnitureManufacturer, string furnitureId, Point3d position, double dropHeight = 0)
        {
            TypeOfFurniture = typeOfFurniture;
            FurnitureName = furnitureName;
            FurnitureManufacturer = furnitureManufacturer;
            FurnitureId = furnitureId;
            DropHeight = dropHeight;
            Position = position;
        }        
    }
}
