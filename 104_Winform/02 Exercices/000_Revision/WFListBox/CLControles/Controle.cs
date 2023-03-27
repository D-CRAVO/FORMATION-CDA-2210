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
        public bool ControleNouvelElement(string _nom)
        {
            Regex maRegex = new Regex(@"^[a-zA-Z](?:(?:-)[a-zA-Z]");
            return maRegex.IsMatch(_nom);
        }
    }
}
