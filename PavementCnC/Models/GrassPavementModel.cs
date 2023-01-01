﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavementCnC.Models
{
    public class GrassPavementModel : IPavement
    {
        public PavementType TypeOfPavement { get; set; }
        public string PavementTypeName { get; set; }
        public string PavementFullName { get; set; }
        public PointOfUseType PointOfUse { get; set; }
        public int AcceptedLoad { get; set; }
        public double PavementArea { get; set; }
        public bool IsInsideGeocells { get; set; }
        public bool IsRolled { get; set; }
        public bool IsInsidePlot { get; set; }

        public GrassPavementModel(PavementType typeOfPavement, string pavementTypeName, PointOfUseType pointOfUse, int acceptedLoad, double pavementArea, bool isInsideGeocells, bool isRolled, bool isInsidePlot = true)
        {
            TypeOfPavement = typeOfPavement;
            PavementTypeName = pavementTypeName;
            PointOfUse = pointOfUse;
            AcceptedLoad = acceptedLoad;
            PavementArea = pavementArea;
            IsInsideGeocells = isInsideGeocells;
            IsRolled = isRolled;
            IsInsidePlot = isInsidePlot;
            var type = PointOfUse switch
            {
                PointOfUseType.FireLane => "пожарные проезды",
                PointOfUseType.Playground => "детские площадки",
                PointOfUseType.SportZone => "спортивные площадки",
                PointOfUseType.UtilityZone => "хозяйственные площадки",
                PointOfUseType.RestZone => "площадки отдыха",
                PointOfUseType.Greenery => "территория озеленения",
                _ => throw new Exception("Неизвестное место применения")
            };
            PavementFullName = $"Покрытие из {(isRolled ? "рулонного" : "посевного")} газона {(isInsideGeocells ? "в георешетке" : "")} ({type}). {(isInsideGeocells ? "Основание под нагрузку " + AcceptedLoad + "т/ось." : "")}";
        }
    }
}