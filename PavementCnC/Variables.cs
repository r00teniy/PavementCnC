using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavementCnC
{
    public static class Variables
    {
        public static List<string[]> currentPavements = new();
        public static List<string[]> currentGreenery = new();
        public static string[] pointOfUseLayer = { "(Пр)", "(Пар)", "(Тр)", "(Пож)", "(Отм)", "(Дет)", "(Сп)", "(Хп)", "(По)", "(Оз)" };
        public static string[] pointOfUseText = { "проезды автотранспорта", "стоянки автотранспорта", "тротуары и дорожки", "пожарные проезды", "отмостка", "детские площадки", "спортивные площадки", "хозяйственные площадки", "площадки отдыха", "территория озеленения" };
        public static string[] typeOfCurb = { "Бетонный", "Гранитный", "Пластиковый", "Металлический" };
        public static string curbLayerStart = "31_Борт";
        public static string pavementLayerStart = "41_Покр";
        public static string greeneryItemsLayerStart = "51_Озелен_шт";
        public static string greeneryAreaLayerStart = "51_Озелен_шт";
        public static string streetFurnitureLayerStart = "61_МАФ";
        public static string plotBorderLayer = "10_Граница";
    }
}
