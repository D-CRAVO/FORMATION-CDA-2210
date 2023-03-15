using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibraryControles
{
    public class Controles
    {
        public static bool controleNouvelElement(string _string)
        {
            Regex maRegex = new Regex(@"^([a-zA-Z]{0,50})(?:-[a-zA-Z]+)?$");
            return maRegex.IsMatch(_string);
        }

        public static bool controleIndex(string _index)
        {
            Regex maRegex = new Regex(@"^[0-9]$");
            return maRegex.IsMatch(_index);
        }

    }
}
