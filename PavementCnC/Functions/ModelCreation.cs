using PavementCnC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PavementCnC.Functions;
using Autodesk.AutoCAD.DatabaseServices;

namespace PavementCnC.Functions;

public static class ModelCreation
{
    static string curbLayerStart = "31_Борт";
    static string pavementLayerStart = "41_Покр";
    public static ConstructionPlotModel GenerateModelsFromAutocad()
    {
        //Getting layer lists from drawing
        List<string> curbLayers = ImportFromAutocad.GetAllLayersContainingString(curbLayerStart);
        List<string> pavementLayers = ImportFromAutocad.GetAllLayersContainingString(pavementLayerStart);
        //Getting layer elements for each layer
        List<List<Polyline>> curbs = new List<List<Polyline>>();
        foreach (var curbLayer in curbLayers)
        {
            curbs.Add(ImportFromAutocad.GetAllElementsOfTypeOnLayer<Polyline>(curbLayer));
        }
        List<List<Hatch>> pavements = new List<List<Hatch>>();
        foreach (var pavementLayer in pavementLayers)
        {
            pavements.Add(ImportFromAutocad.GetAllElementsOfTypeOnLayer<Hatch>(pavementLayer));
        }
        //Creating new models for each element
        List<CurbModel> curbModels= new List<CurbModel>();
        for (int i = 0; i < curbLayers.Count; i++)
        {
            var layerSplit = curbLayers[i].Split('+');
            var type = layerSplit[1] switch
            {
                "Бетонный" => CurbType.Concrete,
                "Гранитный" => CurbType.Granite,
                "Пластиковый" => CurbType.Plastic,
                "Металлический" => CurbType.Metall,
                _ => throw new Exception("Неизвестный тип борта")
            };
            foreach (var item in curbs[i])
            {
                curbModels.Add(new CurbModel(type, layerSplit[2], layerSplit[3], item.Length));
            }
        }
        List<IPavement> pavementModels = new List<IPavement>();
        for (int i = 0; i < pavementLayers.Count; i++)
        {
            var layerSplit = pavementLayers[i].Split('+');
            switch (layerSplit[1])
            {
                case "Асфальтовое":
                    foreach (var item in FunctionsPrepairingData.GetHatchArea(pavements[i]))
                    {
                        pavementModels.Add(new AsphaltPavementModel(PavementType.Asphalt, layerSplit[2], GetPointOfUse(layerSplit[3]), Convert.ToInt32(layerSplit[4]), item));
                    }
                    break;
                case "Бетоннное":
                    foreach (var item in FunctionsPrepairingData.GetHatchArea(pavements[i]))
                    {
                        pavementModels.Add(new ConcretePavementModel(PavementType.Concrete, layerSplit[2], GetPointOfUse(layerSplit[3]), Convert.ToInt32(layerSplit[4]), item, layerSplit[5]));
                    }
                    break;
                case "Газоннное":
                    foreach (var item in FunctionsPrepairingData.GetHatchArea(pavements[i]))
                    {
                        pavementModels.Add(new GrassPavementModel(PavementType.Grass, layerSplit[4], GetPointOfUse(layerSplit[5]), Convert.ToInt32(layerSplit[6]), item, layerSplit[3] == "в георешетке", layerSplit[2] == "рулонный"));
                    }
                    break;
                case "Насыпное":
                    foreach (var item in FunctionsPrepairingData.GetHatchArea(pavements[i]))
                    {
                        pavementModels.Add(new LooseFillPavementModel(PavementType.LooseFill, layerSplit[4], GetPointOfUse(layerSplit[5]), Convert.ToInt32(layerSplit[6]), item, layerSplit[3] == "в георешетке", layerSplit[2], layerSplit[7]));
                    }
                    break;
                case "Резиновое":
                    foreach (var item in FunctionsPrepairingData.GetHatchArea(pavements[i]))
                    {
                        pavementModels.Add(new RubberPavementModel(PavementType.Rubber, layerSplit[5], GetPointOfUse(layerSplit[6]), item, layerSplit[3], layerSplit[4], Convert.ToInt32(layerSplit[7]), layerSplit[2], Convert.ToDouble(layerSplit[8])));
                    }
                    break;
                case "Плиточное":
                    foreach (var item in FunctionsPrepairingData.GetHatchArea(pavements[i]))
                    {
                        pavementModels.Add(new TilesPavementModel(PavementType.Tiles, layerSplit[4], GetPointOfUse(layerSplit[5]), Convert.ToInt32(layerSplit[6]), item, layerSplit[2], layerSplit[7], layerSplit[3], layerSplit[8]));
                    }
                    break;
                default:
                    throw new Exception("Неизвестный тип покрытия");
            }
        }
        
        return new ConstructionPlotModel();
    }

    //Getting enum for pointOfUse
    internal static PointOfUseType GetPointOfUse(string str)
    {
        switch (str)
        {
            case ("(Пр)"):
                return PointOfUseType.Road;
            case ("(Пар)"):
                return PointOfUseType.Parking;
            case ("(Тр)"):
                return PointOfUseType.Footpath;
            case ("(Пож)"):
                return PointOfUseType.FireLane;
            case ("(Отм)"):
                return PointOfUseType.PerimeterWalk;
            case ("(Дет)"):
                return PointOfUseType.Playground;
            case ("(Сп)"):
                return PointOfUseType.SportZone;
            case ("(Хп)"):
                return PointOfUseType.UtilityZone;
            case ("(По)"):
                return PointOfUseType.RestZone;
            case ("(Оз)"):
                return PointOfUseType.Greenery;
            default:
                throw new Exception("Неизвестное место применения");                
        }
    }
}
