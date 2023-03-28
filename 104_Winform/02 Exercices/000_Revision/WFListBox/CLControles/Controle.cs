using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CLControles
{
    public class Controle
    {
        public static bool ControleNouvelElement(string _nom)
        {
            Regex maRegex = new Regex(@"^[a-zA-Z]{0,25}(?:(?:-)[a-zA-Z]{1,25})?$");
            return maRegex.IsMatch(_nom);
        }

        public static bool ControleIndexSelection(string _index)
        {
            Regex maRegex = new Regex(@"^[0-9]$");
            return maRegex.IsMatch(_index);
        }
    }
}
