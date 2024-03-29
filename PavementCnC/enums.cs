﻿namespace PavementCnC;

public enum CurbType
{
    Granite = 0,
    Concrete = 1,
    Metall = 2,
    Plastic = 3
}
public enum PavementType
{
    Asphalt,
    Concrete,
    Tiles,
    LooseFill,
    Rubber,
    Grass
}
public enum ItemOrArea
{
    Item,
    Area
}

public enum GreeneryType
{
    ConiferTree,
    DeciduousTree,
    SingleShrub,
    Creeper,
    ConiferShrubs,
    DeciduousShrubs,
    DecorativeGrasses,
    FlowerBed,
    Grass
}
public enum StreetFurnitureType
{
    Child,
    Sport,
    Trash,
    Rest,
    RoadSign
}

public enum PointOfUseType
{
    Road = 0,
    Parking = 1,
    Footpath = 2,
    FireLane = 3,
    PerimeterWalk = 4,
    Playground = 5,
    SportZone = 6,
    UtilityZone = 7,
    RestZone = 8,
    Greenery = 9
}
public enum TableType
{
    Curbs,
    Pavements,
    ItemGreenery,
    AreaGreenery,
    GrassGreenery,
    StreetFurniture,
    EarthVolumes
}