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
        public static bool controleCapitalEmprunte(string _montant) 
        {
            Regex maRegex = new Regex(@"^[0-9]{1,10}$");
            return maRegex.IsMatch(_montant);
        }

        public static bool controleNom(string _nom)
        {
            Regex maRegex = new Regex(@"^([a-zA-Z]{0,50})(\s([a-zA-Z]{0,50}))?(?:-[a-zA-Z]{0,50})?$");
            return maRegex.IsMatch(_nom);
        }

    }
}
