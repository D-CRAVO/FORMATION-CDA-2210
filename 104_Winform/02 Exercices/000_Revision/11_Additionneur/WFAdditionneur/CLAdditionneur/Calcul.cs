using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLAdditionneur
{
    internal class Calcul
    {
        private List<int>? valeurs;
        private int somme;

        public int addition()
        {
            somme = 0;
            for (int i = 0; i < valeurs.Count; i++)
            {
                somme += valeurs[i];
            }
            return somme;
        }

        public void enregistrerValeur(int _nb)
        {
            valeurs.Add(_nb);
        }

        public void initialiserValeurs()
        {
            somme = 0;
            valeurs = new List<int>();
        }
    }
}
