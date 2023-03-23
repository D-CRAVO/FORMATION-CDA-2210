using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLCalcul
{
    public class Calcul
    {
        private List<int>? valeurs;
        private int somme;

        public Calcul() 
        {
            valeurs = new List<int>();
            somme = 0;
        }

        public int addition()
        {
            
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
            //somme = 0;
            valeurs = new List<int>();
        }
    }
}
