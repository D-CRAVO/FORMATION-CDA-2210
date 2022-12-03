using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bouteille
{
    internal class Bouteille
    {
        private int contenanceEnCl;
        private string contenuActuel;
        private string matiere;
        private int pourcentageDeRemplissage;
        private bool bouteilleFermee;
        private float quantitePresente;

        public float vider(float quantite)
        {
            if (quantite > quantitePresente)
            {
                quantitePresente = 0;
            }
            else
            {
                quantitePresente = quantitePresente - quantite;
            }
            return quantitePresente;
        }

        public float remplir(float quantite)
        {
            if (quantitePresente + quantite > contenanceEnCl)
            {
                quantitePresente = contenanceEnCl;
            }
            else
            {
                quantitePresente = quantitePresente + quantite;
            }
            return quantitePresente;
        }
        public bool fermer()
        {
            if (bouteilleFermee == false)
            {
                bouteilleFermee = true;
            }
            else
            {
                Console.WriteLine("Bouteille déjà fermée");
            }
            return bouteilleFermee;
        }

        public bool ouvrir()
        {
            if (bouteilleFermee == true)
            {
                bouteilleFermee = false;
            }
            else
            {
                Console.WriteLine("Bouteille déjà ouverte");
            }
            return bouteilleFermee;
        }
    }
}

