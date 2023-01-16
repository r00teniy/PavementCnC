using Autodesk.AutoCAD.DatabaseServices;
using PavementCnC.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PavementCnC.Functions;

public static class ModelCreation
{
    public static ConstructionPlotModel GenerateModelsFromAutocad()
    {
        //Getting plot border as polyline
        List<Polyline> plotBorders = ImportFromAutocad.GetAllElementsOfTypeOnLayer<Polyline>(Variables.plotBorderLayer);
        //Getting layer lists from drawing
        List<string> curbLayers = ImportFromAutocad.GetAllLayersContainingString(Variables.curbLayerStart);
        List<string> pavementLayers = ImportFromAutocad.GetAllLayersContainingString(Variables.pavementLayerStart);
        List<string> greeneryItemsLayers = ImportFromAutocad.GetAllLayersContainingString(Variables.greeneryItemsLayerStart);
        List<string> greeneryAreaLayers = ImportFromAutocad.GetAllLayersContainingString(Variables.greeneryAreaLayerStart);
        List<string> streetFurnitureLayers = ImportFromAutocad.GetAllLayersContainingString(Variables.streetFurnitureLayerStart);
        //Getting layer elements for each layer
        List<List<Polyline>> curbs = new List<List<Polyline>>();
        foreach (var curbLayer in curbLayers)
        {
            curbs.Add(ImportFromAutocad.GetAllElementsOfTypeOnLayer<Polyline>(curbLayer));
        }
        //Checking if curbs are inside plot or not
        List<List<bool>> areCurbsInsidePlot = new List<List<bool>>();
        foreach (var curbList in curbs)
        {
            areCurbsInsidePlot.Add(FunctionsPrepairingData.AreObjectsInsidePlot(plotBorders, curbList));
        }
        List<List<Hatch>> pavements = new List<List<Hatch>>();
        foreach (var pavementLayer in pavementLayers)
        {
            pavements.Add(ImportFromAutocad.GetAllElementsOfTypeOnLayer<Hatch>(pavementLayer));
        }
        List<List<BlockReference>> greeneryItems = new();
        foreach (var greeneryLayer in greeneryItemsLayers)
        {
            greeneryItems.Add(ImportFromAutocad.GetAllElementsOfTypeOnLayer<BlockReference>(greeneryLayer));
        }
        List<List<Hatch>> greeneryAreas = new();
        foreach (var greeneryAreaLayer in greeneryAreaLayers)
        {
            greeneryAreas.Add(ImportFromAutocad.GetAllElementsOfTypeOnLayer<Hatch>(greeneryAreaLayer));
        }
        List<List<BlockReference>> streetFurniture = new();
        foreach (var streetFurnitureLayer in streetFurnitureLayers)
        {
            streetFurniture.Add(ImportFromAutocad.GetAllElementsOfTypeOnLayer<BlockReference>(streetFurnitureLayer));
        }
        //Creating new models for each element
        List<CurbModel> curbModels = new List<CurbModel>();
        for (int i = 0; i < curbLayers.Count; i++)
        {
            for (var j = 0; j < curbs[i].Count; j++)
            {
                curbModels.Add(new CurbModel(curbLayers[i], curbs[i][j].Length, areCurbsInsidePlot[i][j]));
            }
        }
        List<IPavement> pavementModels = new List<IPavement>();
        for (int i = 0; i < pavementLayers.Count; i++)
        {
            List<bool> arePavementsInsidePlot = new List<bool>();
            var layerSplit = pavementLayers[i].Split('+');
            arePavementsInsidePlot = FunctionsPrepairingData.AreObjectsInsidePlot(plotBorders, pavements[i]);
            var pavementAreas = FunctionsPrepairingData.GetHatchArea(pavements[i]);
            var pavementPositions = ImportFromAutocad.GetCenterOfAHatch(pavements[i]);
            switch (Array.IndexOf(Variables.typeOfPavement, layerSplit[2]))
            {
                case 0:
                    for (var j = 0; j < pavementAreas.Count; j++)
                    {
                        pavementModels.Add(new AsphaltPavementModel(layerSplit, pavementAreas[j], pavementPositions[j], arePavementsInsidePlot[j]));
                    }
                    break;
                case 1:
                    for (var j = 0; j < pavementAreas.Count; j++)
                    {
                        pavementModels.Add(new TilesPavementModel(layerSplit, pavementAreas[j], pavementPositions[j], arePavementsInsidePlot[j]));
                    }
                    break;
                case 2:
                    for (var j = 0; j < pavementAreas.Count; j++)
                    {
                        pavementModels.Add(new LooseFillPavementModel(layerSplit, pavementAreas[j], pavementPositions[j], arePavementsInsidePlot[j]));
                    }
                    break;
                case 3:
                    for (var j = 0; j < pavementAreas.Count; j++)
                    {
                        pavementModels.Add(new ConcretePavementModel(layerSplit, pavementAreas[j], pavementPositions[j], arePavementsInsidePlot[j]));
                    }
                    break;
                case 4:
                    for (var j = 0; j < pavementAreas.Count; j++)
                    {
                        pavementModels.Add(new RubberPavementModel(layerSplit, pavementAreas[j], pavementPositions[j], arePavementsInsidePlot[j]));
                    }
                    break;
                case 5:
                    for (var j = 0; j < pavementAreas.Count; j++)
                    {
                        pavementModels.Add(new GrassPavementModel(layerSplit, pavementAreas[j], pavementPositions[j], arePavementsInsidePlot[j]));
                    }
                    break;
                default:
                    throw new Exception("Неизвестный тип покрытия");
            }
        }
        List<IGreenery> greeneryModels = new();
        for (int i = 0; i < greeneryItemsLayers.Count; i++)
        {
            var layerSplit = greeneryItemsLayers[i].Split('+');
            switch (layerSplit[2])
            {
                case "Дерево":
                    for (var j = 0; j < greeneryItems[i].Count; j++)
                    {
                        greeneryModels.Add(new TreeGreeneryModel(GreeneryType.Tree, layerSplit, greeneryItems[i][j].Position));
                    }
                    break;
                case "Кустарник":
                    for (var j = 0; j < greeneryItems[i].Count; j++)
                    {
                        greeneryModels.Add(new ShrubGreeneryModel(GreeneryType.Shrub, layerSplit, greeneryItems[i][j].Position));
                    }
                    break;
                default:
                    throw new Exception("Неизвестный тип штучного озеленения");
            }

        }
        for (int i = 0; i < greeneryAreaLayers.Count; i++)
        {
            var layerSplit = greeneryAreaLayers[i].Split('+');
            var hatchAreas = FunctionsPrepairingData.GetHatchArea(greeneryAreas[i]);
            var hatchPositions = ImportFromAutocad.GetCenterOfAHatch(greeneryAreas[i]);
            switch (layerSplit[1])
            {
                case "Изгородь":
                    for (var j = 0; j < greeneryAreas[i].Count; j++)
                    {
                        greeneryModels.Add(new HedgeGreeneryModel(GreeneryType.Tree, layerSplit, hatchPositions[j], hatchAreas[j]));
                    }
                    break;
                case "Цветник":
                    for (var j = 0; j < greeneryAreas[i].Count; j++)
                    {
                        greeneryModels.Add(new FlowerbedGreeneryModel(GreeneryType.Tree, layerSplit, hatchPositions[j], hatchAreas[j]));
                    }
                    break;
                default:
                    throw new Exception("Неизвестный тип площадного озеленения");
            }

        }
        List<StreetFurnitureModel> streetFurnitureModels = new();
        foreach (var furn in streetFurniture)
        {
            var attr = ImportFromAutocad.GetAllAttributesFromBlockReferences(furn);
            for (var i = 0; i < furn.Count; i++)
            {
                streetFurnitureModels.Add(new StreetFurnitureModel(attr[i], furn[i].Position));
            }
        }
        return new ConstructionPlotModel(pavementModels, greeneryModels, streetFurnitureModels, curbModels, plotBorders.Sum(x => x.Area), 0);
    }
}
