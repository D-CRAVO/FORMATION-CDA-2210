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
        public static bool ControleNom(string _nom)
        {
            Regex myRegex = new Regex(@"^([a-zA-Z]{1,50})$");
            return myRegex.IsMatch(_nom);
        }

        public static bool ControleDate(string _date)
        {
            if (!DateOnly.TryParseExact(_date, "dd/MM/yyyy", out DateOnly temp))
            {
                return false;
            }
            return true;
        }

        public static bool ControleMontant(string _montant)
        {
            Regex maRegex = new Regex(@"^(([0-9]{1,25})(?:(?:[.]|,)[0-9]{0,2})?)$");
            return maRegex.IsMatch(_montant);
        }

        public static bool ControleCP(string _cp)
        {
            Regex maRegex = new Regex(@"^([0-9]{5,5})$");
            return maRegex.IsMatch(_cp);
        }
    }
}
