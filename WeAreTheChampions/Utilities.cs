using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions
{
    public static class Utilities
    {

        public static string UpperCaseFirst(this string str) 
        {
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }
    }
}
