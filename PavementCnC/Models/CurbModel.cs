using System;
using System.Collections.Generic;


namespace PavementCnC.Models;
// Layer name structure: curbLayerStart + typeOfCurb + curbName + curbColor
public class CurbModel
{
    public CurbType TypeOfCurb { get; set; }
    public string CurbName { get; set; }
    public string CurbColor { get; set; }
    public double CurbLength { get; set; }
    public bool IsInsidePlot { get; set; }
    public string CurbFullName { get; set; }

    public CurbModel(CurbType typeOfCurb, string curbName, string curbColor, double curbLength, bool isInsidePlot = true)
    {
        TypeOfCurb = typeOfCurb;
        CurbName = curbName;
        CurbColor = curbColor;
        CurbLength = curbLength;
        IsInsidePlot = isInsidePlot;
        var type = TypeOfCurb switch
        {
            CurbType.Concrete => "бетонный",
            CurbType.Granite => "гранитный",
            CurbType.Plastic => "пластиковый",
            CurbType.Metall => "металлический",
            _ => throw new Exception("Неизвестный тип борта")
        };
        CurbFullName = $"Бортовой камень {type} {CurbName} (Цвет: {CurbColor})";
    }
}
