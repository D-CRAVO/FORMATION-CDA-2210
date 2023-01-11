

namespace Library421
{
    public class De
    {
        private int valeur;
        private static int valeurMax = 6;

        public int Valeur { get { return valeur; } }

        public De ()
        {
           valeur = Aleatoire.Instance().Nouveau(1, valeurMax);
        }

       
    }
}