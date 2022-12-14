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
            bool result03 = auto.Demarrer();
            bool result04 = auto.Avancer();
            bool result05 = auto.Avancer();
            bool result06 = auto.Freiner();
            bool result07 = auto.Freiner();
            bool result08 = auto.CouperContact();
            bool result09 = auto.CouperContact();
            Voiture auto2 = new Voiture("Peugeot", "Sans Plomb" , true, 17, true);
            Voiture autoCopie = new Voiture(auto2);
            bool result11 = auto2.Demarrer();
            bool result12 = auto2.Freiner();
            bool result13 = auto2.Avancer();
            bool result14 = auto2.CouperContact();
            bool result15 = auto2.Freiner();
            bool result16 = auto2.CouperContact();


        }
    }
}
