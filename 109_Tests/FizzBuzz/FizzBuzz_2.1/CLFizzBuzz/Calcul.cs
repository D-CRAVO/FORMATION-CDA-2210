using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLFizzBuzz
{
    public class Calcul
    {
        public bool DivisibleParPremiereValeur(int nb, int _premiereValeur)
        {
            return nb % _premiereValeur == 0 ? true : false;
        }

        public bool DivisibleParDeuxiemeValeur(int nb, int _deuxiemeValeur)
        {
            return nb % _deuxiemeValeur == 0 ? true : false;
        }
    }
}
