using Autodesk.AutoCAD.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavementCnC.Models;

public class StreetFurnitureModel
{
    public StreetFurnitureType TypeOfFurniture { get; set; }
    public string FurnitureName { get; set; }
    public string FurnitureManufacturer { get; set; }
    public string FurnitureId { get; set; }
    public double DropHeight { get; set; }
    public Point3d Position { get; set; }
    //do we need foundation prop?

    public StreetFurnitureModel(Dictionary<string,string> attr, Point3d position)
    {
        TypeOfFurniture = attr["Тип"] switch
        {
            "Детская" => StreetFurnitureType.Child,
            "Спортивная" => StreetFurnitureType.Sport,
            "Мусор" => StreetFurnitureType.Trash,
            "Отдых" => StreetFurnitureType.Rest,
            "Знак" => StreetFurnitureType.RoadSign,
            _ => throw new Exception("Неизвестный тип фурнитуры")
        };
        FurnitureName = attr["Название"];
        FurnitureManufacturer = attr["Производитель"];
        FurnitureId = attr["Артикул"];
        DropHeight = Convert.ToDouble(attr["Выс.Падения"]);
        Position = position;
    }        
}
