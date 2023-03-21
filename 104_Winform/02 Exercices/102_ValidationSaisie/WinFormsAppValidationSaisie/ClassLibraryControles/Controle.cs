using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibraryControles
{
    internal class Controle
    {
        public static bool controleNom(string _nom)
        {
            Regex maRegex = new Regex(@"^[a-zA-Z]{1,30}$");
            return maRegex.IsMatch(_nom);
        }

        public static bool controleDate(string _date)
        {
            Regex maRegex = new Regex(@"^[0-9]{2}/[0-9]{2}/[0,9]{4}$");
            return maRegex.IsMatch(_date);
        }

        public static bool controleMontant(string _montant)
        {
            Regex maRegex = new Regex(@"^[0-9]{1,11}(?:(?:[.]|,)[0-9]{2})?$");
            return maRegex.IsMatch(_montant);
        }

        public static bool controleCP(string _cp)
        {
            Regex maRegex = new Regex(@"^[0-9]{5}$");
            return maRegex.IsMatch(_cp);
        }
    }
}
