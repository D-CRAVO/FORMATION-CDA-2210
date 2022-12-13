using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoitureCodage
{
    internal class program
    {
        static void Main(string[] args)
        {
            Voiture auto = new Voiture();
            bool result01 = auto.Demarrer();
            bool result02 = auto.Demarrer();
            bool result03 = auto.Arreter();
            bool result04 = auto.Arreter();
            Voiture auto2 = new Voiture("Peugeot", "Sans Plomb" , true, 17, true);
            Voiture autoCopie = new Voiture(auto2);
        }
    }
}
