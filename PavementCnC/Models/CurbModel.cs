using System;
using System.Collections.Generic;


namespace PavementCnC.Models
{
    public class CurbModel
    {
        public CurbType TypeOfCurb { get; set; }
        public string CurbSize { get; set; }
        public string CurbColor { get; set; }
        public double CurbLength { get; set; }
        public bool IsInsidePlot { get; set; }

        public CurbModel(CurbType typeOfCurb, string curbSize, string curbColor, double curbLength, bool isInsidePlot = true)
        {
            TypeOfCurb = typeOfCurb;
            CurbSize = curbSize;
            CurbColor = curbColor;
            CurbLength = curbLength;
            IsInsidePlot = isInsidePlot;
        }
    }
}
