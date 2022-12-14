using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bouteille
{
    public class Bouteille
    {
        /**
         * Déclaration des attributs
         */
        private int contenanceEnCl;
        private string contenuActuel;
        private string matiere;
        private bool bouteilleFermee;
        private float quantitePresente;

        /**
         * Constructeur à vide
         */
        public Bouteille()
        {
            this.contenanceEnCl = 100;
            this.contenuActuel = "Eau";
            this.matiere = "plastique";
            this.bouteilleFermee = false;
            this.quantitePresente = 100;
        }

        /**
         * Constructeur classique en supprimant le this
         */
        public Bouteille(int _contenanceEnCl, string _contenuActuel, string _matiere, bool _bouteilleFermee, float _quantitePresente)
        {
            contenanceEnCl = _contenanceEnCl;
            contenuActuel = _contenuActuel;
            matiere = _matiere;
            bouteilleFermee = _bouteilleFermee;
            quantitePresente = _quantitePresente;
        }

        /**
         * Constructeur de clonage avec interdépendance
         */
        public Bouteille(Bouteille _bouteilleCopie)
            : this(
                    _bouteilleCopie.contenanceEnCl,
                    _bouteilleCopie.contenuActuel,
                    _bouteilleCopie.matiere,
                    _bouteilleCopie.bouteilleFermee,
                    _bouteilleCopie.quantitePresente
                  )
        {
        }

        /**
         * Réécriture de la méthode ToString()
         */
        public override string ToString()
        {
            return $"La bouteille est en {matiere}, a une contenance de {contenanceEnCl} Cl et contient {quantitePresente} de {contenuActuel}";
        }

        /**
         * Fermer la bouteille
         */
        public bool Fermer()
        {
            if (!bouteilleFermee)
            {
                bouteilleFermee = true;
                return true;
            }
            return false;
        }

        /**
         * Ouvrir la bouteille
         */
        public bool Ouvrir()
        {
            if (bouteilleFermee)
            {
                bouteilleFermee = false;
                return true;
            }
            return false;
        }

        /**
         * Vider la bouteille d'une quantité "_quantite"
         */
        public bool Vider(float _quantite)
        {
            if (bouteilleFermee)
            {
                throw new Exception("Une bouteille fermée ne peut être vidée");
            }
            else if (_quantite < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(_quantite), "La quantité ne peut être négative");
            }
            else if (_quantite > quantitePresente)
            {
                quantitePresente = 0;
            }   
            else
            {
                quantitePresente = quantitePresente - _quantite;
            }
            return true;
        }

        /**
         * Remplir la bouteille d'une quantité "_quantite"
         */
        public bool Remplir(float _quantite)
        {
            if (bouteilleFermee)
            {
                throw new Exception("Une bouteille fermée ne peut être vidée");
            }
            else if (_quantite < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(_quantite), "La quantité ne peut être négative");
            }
            else if (quantitePresente + _quantite > contenanceEnCl)
            {
                quantitePresente = contenanceEnCl;
            }
            else
            {
                quantitePresente = quantitePresente + _quantite;
            }
            return true;
        }

        /**
         * Vider complètement la bouteille
         */
        public bool ViderCompletement()
        {
            if (bouteilleFermee)
            {
                throw new Exception("Une bouteille fermée ne peut être vidée");
            }
            quantitePresente = 0;
            return true;
        }

        /**
         * Changer le contenu de la bouteille
         */
        public bool ChangerContenu(string _nouveauContenu)
        {
            if (quantitePresente > 0)
            {
                this.ViderCompletement();
            }
            if (_nouveauContenu == contenuActuel)
            {
                Console.WriteLine("Contenu déjà présent dans la bouteille");
            }
            contenuActuel = _nouveauContenu;
            return true;
        }

        /**
         * Méthodes de recyclage des bouteilles
         */
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

