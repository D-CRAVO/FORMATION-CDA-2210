

using System.Collections.Immutable;

namespace Library421
{
    public class De : IComparable<De>
    {
        /// <summary>
        /// valeur du dé
        /// </summary>
        private int valeur;
        /// <summary>
        /// valeur minimale du dé
        /// </summary>
        private int valeurMin;
        /// <summary>
        /// valeur maximale du dé
        /// </summary>
        private int valeurMax;

        /// <summary>
        /// Accesseur de la variable valeur
        /// </summary>
        public int Valeur { get { return valeur; } }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public De ()
        {
            valeurMin = 1;
            valeurMax = 6;
            valeur = Aleatoire.Instance().Nouveau(valeurMin, valeurMax);
        }

        /// <summary>
        /// Constructeur classique
        /// </summary>
        /// <param name="_valeurMin"></param>
        /// <param name="_valeurMax"></param>
        public De (int _valeurMin, int _valeurMax)
        {
            valeur = Aleatoire.Instance().Nouveau(valeurMin, valeurMax);
        }

        /// <summary>
        /// Compare les valeurs des dés
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Attribue une nouvelle valeur au dé
        /// </summary>
        /// <returns></returns>
        public int Rouler()
        {
            return valeur = Aleatoire.Instance().Nouveau(valeurMin, valeurMax);
        }

        public void TriDe1(De _de1, De _de2, De _de3)
        {
            De temp;
            //if (_de1 == null || _de2 == null || _de3 == null)
            //{
            //    throw new Exception("Veuillez lancer tous les dés");
            //}
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

        private void TriDe2(De _de1, De _de2, De _de3)
        {
            De[] tabDe = new De[] { _de1, _de2, _de3};
            Array.Sort(tabDe);
            Array.Reverse(tabDe);
            _de1 = tabDe[0];
            _de2 = tabDe[1];
            _de3 = tabDe[2];
        }

        private void TriDe3(De _de1, De _de2, De _de3)
        {
            List<De> listDe = new List<De>();
            listDe.Add(_de1);
            listDe.Add(_de2);
            listDe.Add(_de3);
            listDe.Sort();
            listDe.Reverse();
            _de1 = listDe[0];
            _de2 = listDe[1];
            _de3 = listDe[2];
        }
    }
}