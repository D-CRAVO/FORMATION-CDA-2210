

namespace Library421
{
    public class De : IComparable<De>
    {
        private int valeur;
        private static int valeurMin;
        private static int valeurMax;

        public int Valeur { get { return valeur; } }

        public De ()
        {
            valeurMin = 1;
            valeurMax = 6;
            valeur = Aleatoire.Instance().Nouveau(valeurMin, valeurMax);
        }

        public De (int _valeurMin, int _valeurMax)
        {
            valeur = Aleatoire.Instance().Nouveau(valeurMin, valeurMax);
        }

        public int CompareTo(De? other)
        {
            if (other == null)
            {
                throw new Exception("Veuillez lancer le dé");
            }
            else if (this.Valeur < other.Valeur)
            {
                return -1;
            }
            else if (this.Valeur > other.Valeur) 
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Rouler()
        {
            return Aleatoire.Instance().Nouveau(valeurMin, valeurMax);
        }

        public void triDe(De _de1, De _de2, De _de3)
        {
            De temp;
            if (_de1 == null || _de2 == null || _de3 == null)
            {
                throw new Exception("Veuillez lancer tous les dés");
            }
            if (_de1.CompareTo(_de2) == -1)
            {
                if (_de2.CompareTo(_de3) == -1)
                {
                    temp = _de1;
                    _de1 = _de3;
                    _de3 = temp;
                }
                else
                {
                    if (_de3.CompareTo(_de1) == -1)
                    {
                        temp = _de1;
                        _de1 = _de2;
                        _de2 = temp;
                    }
                    else
                    {
                        temp = _de1;
                        _de1 = _de2;
                        _de2 = _de3;
                        _de3 = temp;
                    }
                }
            }
            else 
            {
                if (_de2.CompareTo(_de3) == -1)
                {
                    if (_de1.CompareTo(_de3) == -1)
                    {
                        temp = _de1;
                        _de1 = _de3;
                        _de3 = _de2;
                        _de2 = temp;
                    }
                    else
                    {
                        temp = _de2;
                        _de2 = _de3;
                        _de3 = temp;

                    }
                }
            }
        }



    }
}