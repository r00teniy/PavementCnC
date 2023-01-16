using System;
using System.Globalization;
using System.Linq;

namespace PavementCnC.Functions
{
    public static class FormValidation
    {
        public static bool CheckTextField(string text, string[] values = null)
        {
            if (values == null)
            {
                return (text != "" && text != null);
            }
            return values.Contains(text);
        }
        public static int? CheckIntField(string text)
        {
            int al;
            return (text == "" || text == null || !Int32.TryParse(text, out al)) ? null : al;
        }
        public static double? CheckDoubleField(string text)
        {
            double al;
            return (text == "" || text == null || !Double.TryParse(text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out al)) ? null : al;
        }
    }
}
