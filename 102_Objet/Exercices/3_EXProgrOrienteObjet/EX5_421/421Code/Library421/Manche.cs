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
                return false;
                // throw new Exception("Veuillez lancer tous les dés");
            }
            else if (mesDes[0].Valeur == 4  && mesDes[1].Valeur == 2 && mesDes[2].Valeur == 1)
            {
                return true;
            }
            return false;
        }

        public void PremierLancer()
        {
            mesDes[0] = new De();
            mesDes[1] = new De();
            mesDes[2] = new De();
            nbLanceEffectue++;
        }

        public void Relance()
        {
            mesDes[0].Rouler();
            mesDes[1].Rouler();
            mesDes[2].Rouler();
            nbLanceEffectue++;
        }

        public void Relance(De _de)
        {
            _de.Rouler();
            nbLanceEffectue++;
        }


        //public void TrierDes(De[] _mesDes)
        //{
        //    De _de1 = _mesDes[0];
        //    De _de2 = _mesDes[1];
        //    De _de3 = _mesDes[2];
        //    De temp;
        //    //if (_de1 == null || _de2 == null || _de3 == null)
        //    //{
        //    //    throw new Exception("Veuillez lancer tous les dés");
        //    //}
        //    if (_de1.CompareTo(_de2) == -1)
        //    {
        //        if (_de2.CompareTo(_de3) == -1)
        //        {
        //            temp = _de1;
        //            _de1 = _de3;
        //            _de3 = temp;
        //        }
        //        else
        //        {
        //            if (_de3.CompareTo(_de1) == -1)
        //            {
        //                temp = _de1;
        //                _de1 = _de2;
        //                _de2 = temp;
        //            }
        //            else
        //            {
        //                temp = _de1;
        //                _de1 = _de2;
        //                _de2 = _de3;
        //                _de3 = temp;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        if (_de2.CompareTo(_de3) == -1)
        //        {
        //            if (_de1.CompareTo(_de3) == -1)
        //            {
        //                temp = _de1;
        //                _de1 = _de3;
        //                _de3 = _de2;
        //                _de2 = temp;
        //            }
        //            else
        //            {
        //                temp = _de2;
        //                _de2 = _de3;
        //                _de3 = temp;

        //            }
        //        }
        //    }
        //}

        public void TrierDes()
        {
            Array.Sort(mesDes);
            Array.Reverse(mesDes);
        }
    }
}
