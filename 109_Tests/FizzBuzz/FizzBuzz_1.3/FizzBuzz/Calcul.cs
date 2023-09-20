using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Calcul
    {
        public bool MultipleDeTrois(int nb)
        {
            if (nb % 3 == 0) { return true; }
            return false;
        }

        public bool MultipleDeCinq(int nb)
        {
            if (nb % 5 == 0) 
                return true; 
            return false;
        }

        public void Calculer()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (MultipleDeTrois(i) && MultipleDeCinq(i))
                {
                    Console.WriteLine($"{i} est multiple de 3 et de 5" + Environment.NewLine) ;
                }
                else if (MultipleDeTrois(i))
                {
                    Console.WriteLine($"{i} est multiple de 3" + Environment.NewLine);
                }
                else if (MultipleDeCinq(i))
                {
                    Console.WriteLine($"{i} est multiple de 5" + Environment.NewLine);
                }
                else
                {
                    Console.WriteLine($"{i}" + Environment.NewLine);
                }
            }
        }
        

    }
}
