using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Calcul
    {
        private string str;
        private int i;
        private static int debut;
        private static int fin;

        public Calcul()
        {
            debut = 1;
            fin = 100;
        }
        

        public bool MultipleDeCinq(int nb)
        {
            if (nb % 5 == 0) 
                return true; 
            return false;
        }

        public int Parcourir(int _debut, int _fin)
        {
            i = _debut;
            while (i < _fin)
                i++;
            return i;
        }
        public string Calculer()
        {
            if (MultipleDeTrois(Parcourir(debut, fin)) && MultipleDeCinq(Parcourir(debut, fin)))
            {
                str = $"{Parcourir(debut, fin)} est multiple de 3 et de 5" + Environment.NewLine;
            }
            else if (MultipleDeTrois(Parcourir(debut, fin)))
            {
                str = $"{Parcourir(debut, fin)} est multiple de 3" + Environment.NewLine;
            }
            else if (MultipleDeCinq(Parcourir(debut, fin)))
            {
                str = $"{Parcourir(debut, fin)} est multiple de 5" + Environment.NewLine;
            }
            else
            {
                str = $"{Parcourir(debut, fin)}" + Environment.NewLine;
            }
            return str; 
        }
    }
}
