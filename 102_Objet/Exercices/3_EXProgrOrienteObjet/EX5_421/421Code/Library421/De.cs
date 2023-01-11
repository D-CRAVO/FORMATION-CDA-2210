

namespace Library421
{
    public class De
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
       
    }
}