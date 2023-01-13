using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library421
{
    public class Manche
    {
        private byte nbLancesEffectue;
        private const byte nbLancesMax = 3;
        private De? de1;
        private De? de2;
        private De? de3;
        private De?[] mesDes;

        public De?[] MesDes
        {
            get => mesDes;
        }


        public Manche()
        {
            nbLancesEffectue = 0;
            mesDes = new De?[3] { null, null, null };

            //nbLancesEffectue = 1;
            //mesDes = new De[3] { new De(), new De(), new De() };
        }


        public void PremierLancer()
        {
            //foreach(De de in mesDes)
            //{
            //    de = new De();
            //}

            //mesDes[0] = new De();
            //mesDes[1] = new De();
            //mesDes[2] = new De();

            for (int i = 0;i < mesDes.Length; i++)
            {
                mesDes[i] = new De();
            }

            nbLancesEffectue++;
        }

        public bool AEncoreUnLance()
        {
            if (nbLancesEffectue < nbLancesMax)
            {
                return true;
            }
            return false;
        }

        public bool EstGagne()
        {
            trierDesManche(mesDes);
            if (mesDes[0].Valeur == 4 && mesDes[1].Valeur == 2 && mesDes[2].Valeur == 1)
            {
                return true;
            }
            return false;
            
        }

        private void trierDesManche(De[] mesDes)
        {
            Array.Sort(mesDes);
            Array.Reverse(mesDes);
        }

        private void trierDesManche1(De[] mesDes)
        {
            TrierDes(mesDes);
        }

        public void Relance(De _de)
        {
            _de.Valeur = _de.Rouler();
            nbLancesEffectue++;
        }

        public void Relance()
        {
            foreach (De _de in mesDes)
            {
                _de.Rouler();
                nbLancesEffectue++;
            }
        }
    }
}
