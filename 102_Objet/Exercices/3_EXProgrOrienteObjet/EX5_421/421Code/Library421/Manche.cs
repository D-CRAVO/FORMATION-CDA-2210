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
        private De?[] mesDes;


        public Manche()
        {
            nbLanceEffectue = 0;
            mesDes = new De?[] { null, null, null };
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
            if (mesDes[0].Valeur != 4  && mesDes[1].Valeur != 2 && mesDes[2].Valeur != 1)
            {
                return true;
            }
            return false;
        }
    }
}
