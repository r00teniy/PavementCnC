using Autodesk.AutoCAD.Geometry;
using System;
using System.Collections.Generic;

namespace PavementCnC.Models;

public class StreetFurnitureModel : IElement
{
    public StreetFurnitureType TypeOfFurniture { get; private set; }
    public string Name { get; private set; }
    public string Manufacturer { get; private set; }
    public string Id { get; private set; }
    public string FullName { get; private set; }
    public double SafeDropHeight { get; private set; }
    public Point3d Position { get; private set; }
    public string Code { get; private set; }
    public double Amount { get; private set; } = 1;
    public bool IsInsidePlot { get; private set; }
    public string MountType { get; private set; }

    //do we need foundation prop?

    public StreetFurnitureModel(Dictionary<string, string> attr, Point3d position)
    {
        TypeOfFurniture = attr["Тип"] switch // = (StreetFurnitureType)Array.IndexOf(Varianles.typeOfStreetFurniture, attr["Тип"])
        {
            "Детская" => StreetFurnitureType.Child,
            "Спортивная" => StreetFurnitureType.Sport,
            "Мусор" => StreetFurnitureType.Trash,
            "Отдых" => StreetFurnitureType.Rest,
            "Знак" => StreetFurnitureType.RoadSign,
            _ => throw new Exception("Неизвестный тип фурнитуры")
        };
        Name = attr["Название"];
        Manufacturer = attr["Производитель"];
        Id = attr["Артикул"];
        SafeDropHeight = Convert.ToDouble(attr["Выс.Падения"]);
        MountType = attr["Крепление"];
        Code = attr["MaterialCode"];
        Position = position;
        FullName = $"{Name}, {Manufacturer}, {Id}";
    }
}
