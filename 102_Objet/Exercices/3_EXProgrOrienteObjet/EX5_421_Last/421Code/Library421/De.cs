

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
        public De () : this(1, 6) { }
        
        /// <summary>
        /// Constructeur classique
        /// </summary>
        /// <param name="_valeurMin"></param>
        /// <param name="_valeurMax"></param>
        public De (int _valeurMin, int _valeurMax)
        {
            this.valeurMin = _valeurMin;
            this.valeurMax = _valeurMax;
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
                throw new ArgumentNullException();
            }
            //else if (this.Valeur < other.Valeur)
            //{
            //    return -1;
            //}
            //else if (this.Valeur > other.Valeur) 
            //{
            //    return 1;
            //}
            //else
            //{
            //    return 0;
            //}
            else 
            {
                return this.valeur.CompareTo(other.valeur);
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
    }
}