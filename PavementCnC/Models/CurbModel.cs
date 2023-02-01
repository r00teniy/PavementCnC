using System;


namespace PavementCnC.Models;
// Layer name structure: curbLayerStart(0) + Code(1) + typeOfCurb(2) + curbSize(3) + curbModelName(4) + curbProducer(5) + curbColor(6)
public class CurbModel : IElement
{
    public CurbType TypeOfCurb { get; private set; }
    private string _curbModelName;
    private string _curbProducer;
    public string CurbSize { get; private set; }
    public string CurbColor { get; private set; }
    public bool IsInsidePlot { get; private set; }
    public string CurbFullName { get; private set; }
    public string Code { get; private set; }
    public double Amount { get; private set; }

    public CurbModel(string curbLayer, double curbLength, bool isInsidePlot)
    {
        var layerSplit = curbLayer.Split('+');
        Code = layerSplit[1];
        TypeOfCurb = (CurbType)Array.IndexOf(Variables.typeOfCurb, layerSplit[2]);
        CurbSize = layerSplit[3];
        _curbModelName = layerSplit[4];
        _curbProducer = layerSplit[5];
        CurbColor = layerSplit[6];
        Amount = curbLength;
        IsInsidePlot = isInsidePlot;
        var type = TypeOfCurb switch
        {
            CurbType.Concrete => "бетонный",
            CurbType.Granite => "гранитный",
            CurbType.Plastic => "пластиковый",
            CurbType.Metall => "металлический",
            _ => throw new Exception("Неизвестный тип борта")
        };
        CurbFullName = $"Борт {type} {_curbModelName}, {_curbProducer}";
    }
}
