using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibraryValidationSaisie
{
    public class Controles
    {



        public Controles()
        {

        }

        private static bool ValideNom(string _nom)
        {
            Regex myRegex = new Regex(@"^[a-zA-Z]{1,30}$");
            return myRegex.IsMatch(_nom); // retourne true ou false selon la vérification
        }

        private static bool ValideDate(string _date)
        {
            Regex myRegex = new Regex(@"^[0-9]{2}/[0-9]{2}/[0-9]{4}");
            return myRegex.IsMatch(_date);
        }

        private static bool ValideMontant(string _montant)
        {
            Regex myRegex = new Regex(@"^[0-9]{1,25}.[0-9]{1,2}$");
            return myRegex.IsMatch(_montant);
        }

        private static bool ValideCP(string _cp)
        {
            Regex myRegex = new Regex(@"^[0-9]{1,5}$");
            return myRegex.IsMatch(_cp);
        }

        //bool result = NomValide("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
    }
}
