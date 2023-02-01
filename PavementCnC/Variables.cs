﻿using System.Collections.Generic;

namespace PavementCnC
{
    public static class Variables
    {
        public static List<string[]> currentCurbs = new();
        public static List<string[]> currentPavements = new();
        public static List<string[]> currentGreenery = new();
        public static string[] pointOfUseLayer = { "(Пр)", "(Пар)", "(Тр)", "(Пож)", "(Отм)", "(Дет)", "(Сп)", "(Хп)", "(По)", "(Оз)" };
        public static string[] pointOfUseText = { "проезды автотранспорта", "стоянки автотранспорта", "тротуары и дорожки", "пожарные проезды", "отмостка", "детские площадки", "спортивные площадки", "хозяйственные площадки", "площадки отдыха", "территория озеленения" };
        public static string[] typeOfCurb = { "Гранитный", "Бетонный", "Пластиковый", "Металлический" };
        public readonly static string[] typeOfPavement = { "Асфальтовое", "Плиточное", "Насыпное", "Бетонное", "Резиновое", "Газон в георешетке" };
        public static string[] typeOfItemGreenery = { "Хвойное_дерево", "Лиственное_дерево", "Крупный_кустарник", "Лиана" };
        public static string[] typeOfAreaGreenery = { "Хвойные_кустарники", "Лиственные_кустарники", "Злаковые_декорвтивные_травы", "Многолетники", "Газон" };
        public static string[] typeOfStreetFurniture = { "Детская", "Спортивная", "Мусор", "Отдых", "Знак" };
        public static string[] curbsHeader = { "Условное обозначение", "MaterialCode", "Полное наименование", "Габариты дхшхв, мм", "Цвет", "Колличество, п.м.", "Примечание"};
        public static string[] pavementHeader = { "Условное обозначение", "MaterialCode", "Зона пременения", "Полное наименование", "Габариты дхшхв, мм", "Цвет", "Колличество, п.м.", "Примечание" };
        public static string[] GreeneryItemHeader = { "Условное обозначение", "MaterialCode", "Русское название / Латинское название", "Высота растения, м", "Обхват ствола, м", "Диаметр кроны, м", "Размер кома, м", "Колличество, шт.", "Материал приствольного круга", "Общая площадь мульчирующего материала", "Примечание" };
        public static string[] GreeneryAreaHeader = { "Условное обозначение", "MaterialCode", "Русское название / Латинское название", "Высота растения / диаметр кроны, м", "Размер кома, м", "Площадь, м2", "Норма шт/м2", "Колличество, шт.", "Мульчирующий материал", "Общая площадь мульчирующего материала", "Примечание" };
        public static string[] GreeneryGrassHeader = { "Условное обозначение", "MaterialCode", "Наименование", "Состав травосмеси", "Площадь, м2", "Примечания" };
        public static string[] streetFurnitureHeader = { "Условное обозначение", "MaterialCode", "Наименование, производитель, артикул", "Колличество", "Высота падения, м", "Способ крепления", "Примечание" };
        public static List<Dictionary<string, string>> pavementHatchStyles = new List<Dictionary<string, string>>
        {
            new Dictionary<string, string>() { { "styleName", "Плитка прямоуг." }, { "patName", "BRICK" }, { "scale", "0.1" }, { "rotation", "0" }, { "hasBackground", "true"} },
            new Dictionary<string, string>() { { "styleName", "Плитка без фона." }, { "patName", "BRICK" }, { "scale", "0.1" }, { "rotation", "0" }, { "hasBackground", "false"} },
            new Dictionary<string, string>() { { "styleName", "Проезд асфальт." }, { "patName", "SOLID"}, { "scale", "1" }, { "rotation", "0"}, { "hasBackground", "false"} }
        };
        public static List<Dictionary<string, string>> greeneryHatchStyles = new List<Dictionary<string, string>>
        {
            new Dictionary<string, string>() { { "styleName", "Изгородь" }, { "patName", "ANSI37" }, { "scale", "0.2" }, { "rotation", "0" }, { "hasBackground", "true"} },
            new Dictionary<string, string>() { { "styleName", "Газон" }, { "patName", "SOLID"}, { "scale", "1" }, { "rotation", "0"}, { "hasBackground", "false"} }
        };
        public static string[] ItemOrArea = { "(шт.)", "(пл.)" };
        public static string curbLayerStart = "31_Борт";
        public static string pavementLayerStart = "41_Покр";
        public static string greeneryLayerStart = "51_Озелен";
        public static string streetFurnitureLayerStart = "61_МАФ";
        public static string plotBorderLayer = "10_Граница";
        public static string tableStyleName = "Таблицы";
    }
}
