using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibraryValidationSaisie2
{
    public class Controles
    {

        public static bool ValideNom(string _nom)
        {
            Regex myRegex = new Regex(@"^[a-zA-Z]{1,25}$");
            return myRegex.IsMatch(_nom); // retourne true ou false selon la vérification
        }

        public static bool ValideDate(string _date)
        {
            Regex myRegex = new Regex(@"^[0-9]{2}/[0-9]{2}/[0-9]{4}");
            if (DateTime.TryParse(_date, out DateTime temp) && myRegex.IsMatch(_date))
            {
                DateTime.Parse(_date);
                return true;
            }
            return false;
        }

        public static bool ValideMontant(string _montant)
        {
            Regex myRegex = new Regex(@"^[0-9]{1,10}(?:(?:[.]|,)[0-9]{1,2})?$");
            return myRegex.IsMatch(_montant);
        }

        public static bool ValideCP(string _cp)
        {
            Regex myRegex = new Regex(@"^[0-9]{5,5}$");
            return myRegex.IsMatch(_cp);
        }
    }
}
