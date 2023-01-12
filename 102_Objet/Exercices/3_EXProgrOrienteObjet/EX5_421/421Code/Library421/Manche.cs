using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library421
{
    internal class Manche
    {
        private byte nbLanceEffectue;
        private const byte nbLanceMax = 3;
        private De de1;
        private De de2;
        private De de3;
        private int?[] combinaison;


        public Manche()
        {
            nbLanceEffectue = 0;
            combinaison = new int?[] { de1.Valeur, de2.Valeur, de3.Valeur };
        }

        public bool AEncoreUnLance()
        {
            if (nbLanceEffectue < nbLanceMax)
            {
                return true;
            }
            return false;
        }

        public bool EstGagne()
        {
            if (combinaison[0])
            else if (!AEncoreUnLance() && combinaison[0] != 4  && combinaison[1] != 2 && combinaison[2] != 1)
            {
                return false;
            }
            return true;
        }
    }
}
