using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library421
{
    public class Aleatoire : Random
    {
        private static Aleatoire monAleatoire = null;

        private Aleatoire()
        {
        }

        public static Aleatoire Instance()
        {
            if (monAleatoire == null)
            {
                monAleatoire = new Aleatoire();
            }
            return monAleatoire;
        }

        public int Nouveau(int valMin, int valMax)
        {
            return base.Next(valMin, valMax+1);
        }
    }
}
