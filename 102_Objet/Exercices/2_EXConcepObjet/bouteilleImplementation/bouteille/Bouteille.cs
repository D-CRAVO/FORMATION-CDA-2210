using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bouteille
{
    public class Bouteille
    {
        private int contenanceEnCl;
        private string contenuActuel;
        private string matiere;
        private bool bouteilleFermee;
        private float quantitePresente;

        public Bouteille(int contenanceEnCl, string contenuActuel, string matiere, bool bouteilleFermee, float quantitePresente)
        {
            this.contenanceEnCl = contenanceEnCl;
            this.contenuActuel = contenuActuel;
            this.matiere = matiere;
            this.bouteilleFermee = bouteilleFermee;
            this.quantitePresente = quantitePresente;
        }

        public override string ToString()
        {
            return $"La bouteille est en {matiere}, a une contenance de {contenanceEnCl} Cl et contient {quantitePresente} de {contenuActuel}";
        }

        /*
        public enum matiere
        {
            plastique,
            metal,
            verre
        }
        */

        public bool Fermer()
        {
            if (!bouteilleFermee)
            {
                bouteilleFermee = true;
            }
            else
            {
                Console.WriteLine("Bouteille déjà fermée");
            }
            return bouteilleFermee;
        }

        public bool Ouvrir()
        {
            if (bouteilleFermee)
            {
                bouteilleFermee = false;
            }
            else
            {
                Console.WriteLine("Bouteille déjà ouverte");
            }
            return bouteilleFermee;
        }

        public float Vider(float quantite)
        {
            if (bouteilleFermee)
            {
                Console.WriteLine("Une bouteille fermée ne peut être vidée");
            }
            else if (quantite < 0)
            {
                Console.WriteLine("Veuillez saisir une valeur positive");
            }
            else if (quantite > quantitePresente)
            {
                quantitePresente = 0;
            }
            else
            {
                quantitePresente = quantitePresente - quantite;
            }
            Console.Write($"La nouvelle quantité de {contenuActuel} dans la bouteille en Cl est de : ");
            return quantitePresente;
        }

        public float Remplir(float quantite)
        {
            if (bouteilleFermee)
            {
                Console.WriteLine("Une bouteille fermée ne peut être vidée");
            }
            else if (quantite < 0)
            {
                Console.WriteLine("Veuillez saisir une valeur positive");
            }
            else if (quantitePresente + quantite > contenanceEnCl)
            {
                quantitePresente = contenanceEnCl;
            }
            else
            {
                quantitePresente = quantitePresente + quantite;
            }
            Console.Write($"La nouvelle quantité de {contenuActuel} dans la bouteille en Cl est de : ");
            return quantitePresente;
        }

        public float ViderCompletement()
        {
            if (bouteilleFermee)
            {
                this.Ouvrir();
            }
            Console.Write($"La nouvelle quantité de {contenuActuel} dans la bouteille en Cl est de : ");
            return quantitePresente = 0;
        }

        public void ChangerContenu(string nouveauContenu)
        {
            if (bouteilleFermee)
            {
                this.Ouvrir();
            }
            if (quantitePresente > 0)
            {
                this.ViderCompletement();
            }
            if (nouveauContenu == contenuActuel)
            {
                Console.WriteLine("Contenu déjà présent dans la bouteille");
            }
            contenuActuel = nouveauContenu;
        }

        public string Recycler()
        {
            if (matiere == "plastique")
            {
                return "La bouteille en plastique va dans la poubelle jaune";
            }
            else if (matiere == "metal")
            {
                return "La bouteille en metal va dans la poubelle jaune";
            }
            else if (matiere == "verre")
            {
                return "La bouteille en verre va dans la poubelle verte";
            }
            else
            {
                return "Demandez à l'employé du centre de tri";
            }

        }
        
    }
}

