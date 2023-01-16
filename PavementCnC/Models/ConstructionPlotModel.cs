using System.Collections.Generic;
using System.Linq;

namespace PavementCnC.Models;

public class ConstructionPlotModel
{
    public double PlotArea { get; set; }
    public double BuildingFootprint { get; set; }
    public double HardPavementInsidePlot { get; set; }
    public double GreeneryAreaInsidePlot { get; set; }
    public double HardPavementOutsidePlot { get; set; }
    public double GreeneryAreaOutsidePlot { get; set; }
    public double LooseFillInsidePlot { get; set; }
    public double LooseFillOutsidePlot { get; set; }
    public List<AsphaltPavementModel> AsphaltPavements { get; set; }
    public List<ConcretePavementModel> ConcretePavements { get; set; }
    public List<GrassPavementModel> GrassPavements { get; set; }
    public List<LooseFillPavementModel> LooseFillPavements { get; set; }
    public List<RubberPavementModel> RubberPavements { get; set; }
    public List<TilesPavementModel> TilesPavements { get; set; }
    public List<CurbModel> Curbs { get; set; }
    public List<StreetFurnitureModel> StreetFurniture { get; set; }
    public List<FlowerbedGreeneryModel> Flowerbeds { get; set; }
    public List<HedgeGreeneryModel> Hedges { get; set; }
    public List<ShrubGreeneryModel> Shrubs { get; set; }
    public List<TreeGreeneryModel> Trees { get; set; }

    public ConstructionPlotModel(List<IPavement> pavementList, List<IGreenery> greeneryList, List<StreetFurnitureModel> streetFurnitureList, List<CurbModel> curbs, double plotArea, double buildingFootprint)
    {
        Curbs = curbs;
        PlotArea = plotArea;
        BuildingFootprint = buildingFootprint;
        StreetFurniture = streetFurnitureList;
        //Separating pavements by type
        AsphaltPavements = pavementList.Where(x => x.TypeOfPavement == PavementType.Asphalt).Select(x => x as AsphaltPavementModel).ToList();
        ConcretePavements = pavementList.Where(x => x.TypeOfPavement == PavementType.Concrete).Select(x => x as ConcretePavementModel).ToList();
        GrassPavements = pavementList.Where(x => x.TypeOfPavement == PavementType.Grass).Select(x => x as GrassPavementModel).ToList();
        LooseFillPavements = pavementList.Where(x => x.TypeOfPavement == PavementType.LooseFill).Select(x => x as LooseFillPavementModel).ToList();
        RubberPavements = pavementList.Where(x => x.TypeOfPavement == PavementType.Rubber).Select(x => x as RubberPavementModel).ToList();
        TilesPavements = pavementList.Where(x => x.TypeOfPavement == PavementType.Tiles).Select(x => x as TilesPavementModel).ToList();
        //Separating greenery by type
        Flowerbeds = greeneryList.Where(x => x.TypeOfGreenery == GreeneryType.FlowerBed).Select(x => x as FlowerbedGreeneryModel).ToList();
        Hedges = greeneryList.Where(x => x.TypeOfGreenery == GreeneryType.Hedge).Select(x => x as HedgeGreeneryModel).ToList();
        Shrubs = greeneryList.Where(x => x.TypeOfGreenery == GreeneryType.Shrub).Select(x => x as ShrubGreeneryModel).ToList();
        Trees = greeneryList.Where(x => x.TypeOfGreenery == GreeneryType.Tree).Select(x => x as TreeGreeneryModel).ToList();
        //Calculating total area of hard pavements, loose fill, and greenery
        HardPavementInsidePlot = pavementList.Where(x => x.TypeOfPavement != PavementType.Grass && x.TypeOfPavement != PavementType.LooseFill && x.IsInsidePlot).Select(x => x.PavementArea).Sum();
        GreeneryAreaInsidePlot = pavementList.Where(x => x.TypeOfPavement == PavementType.Grass && x.IsInsidePlot).Select(x => x.PavementArea).Sum();
        LooseFillInsidePlot = pavementList.Where(x => x.TypeOfPavement == PavementType.LooseFill && x.IsInsidePlot).Select(x => x.PavementArea).Sum();
        HardPavementOutsidePlot = pavementList.Where(x => x.TypeOfPavement != PavementType.Grass && x.TypeOfPavement != PavementType.LooseFill && x.IsInsidePlot == false).Select(x => x.PavementArea).Sum();
        GreeneryAreaOutsidePlot = pavementList.Where(x => x.TypeOfPavement == PavementType.Grass && x.IsInsidePlot == false).Select(x => x.PavementArea).Sum();
        LooseFillOutsidePlot = pavementList.Where(x => x.TypeOfPavement == PavementType.LooseFill && x.IsInsidePlot == false).Select(x => x.PavementArea).Sum();
    }

}
