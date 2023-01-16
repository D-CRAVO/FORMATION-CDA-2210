using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library421
{
    public class Manche
    {
        private byte nbLanceEffectue;
        private const byte nbLanceMax = 3;
        private De?[] mesDes;

        public De?[] MesDes
        {
            get { return mesDes; }
        }

        public byte NbLanceEffectue
        {
            get { return nbLanceEffectue; }
            set { nbLanceEffectue = value; }
        }

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
            TrierDes();
            if (mesDes[0] == null || mesDes[1] == null || mesDes[2] == null)
            {
                // return false;
                throw new Exception("Veuillez lancer tous les dés");
            }
            else if (mesDes[0].Valeur == 4  && mesDes[1].Valeur == 2 && mesDes[2].Valeur == 1)
            {
                return true;
            }
            return false;
        }

        public void PremierLance()
        {
            mesDes[0] = new De();
            mesDes[1] = new De();
            mesDes[2] = new De();
            nbLanceEffectue++;
        }

        public void Relance()
        {
            for (int i = 0; i < 3; i++)
            {
                if (MesDes[i].Valeur != 4 && MesDes[i].Valeur != 2 && MesDes[i].Valeur != 1)
                {
                    RelanceDe(MesDes[i]);
                }
            }
            NbLanceEffectue++;
        }

        public void RelanceDe(De _de)
        {
            _de.Rouler();
        }

        public void TrierDes()
        {
            Array.Sort(mesDes);
            Array.Reverse(mesDes);
        }
    }
}
