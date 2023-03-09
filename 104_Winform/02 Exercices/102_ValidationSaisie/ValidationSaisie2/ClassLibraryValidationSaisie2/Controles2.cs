using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibraryValidationSaisie2
{
    public class Controles2
    {
        private string nom;

        public string Nom { get; set; }

        public Controles2()
        {
            nom = "";
        }

        public static bool ValideNom(string _nom)
        {
            Regex myRegex = new Regex(@"^[a-zA-Z]{1,25}$");
            return myRegex.IsMatch(_nom); // retourne true ou false selon la vérification
        }
    }
}
