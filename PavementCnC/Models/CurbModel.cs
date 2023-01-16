using System;


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

    public CurbModel(string curbLayer, double curbLength, bool isInsidePlot = true)
    {
        var layerSplit = curbLayer.Split('+');
        TypeOfCurb = (CurbType)Array.IndexOf(Variables.typeOfCurb, layerSplit[1]);
        CurbName = layerSplit[2];
        CurbColor = layerSplit[3];
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
