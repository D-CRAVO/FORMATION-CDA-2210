using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryEmpruntsControles;

namespace ClassLibraryEmprunts
{
    public class Emprunts
    {
        private string nomClient;
        private uint capitalEmprunte;
        private int nbMois;
        private string periodiciteRemboursement;
        private double tauxAnnuel;
        private static int nombreRemboursements;
        

        public string NomClient { get { return nomClient; } set { nomClient = value; } }
        public uint CapitalEmprunte { get { return capitalEmprunte; } set { capitalEmprunte = value; } }
        public int NbMois { get { return nbMois; } set { nbMois = value; } }
        public string PeriodiciteRemboursement { get { return periodiciteRemboursement; } set { periodiciteRemboursement = value; } }
        public double TauxAnnuel { get { return tauxAnnuel; } set { tauxAnnuel = value; } }
        public int NombreRemboursements { get { return nombreRemboursements; } set { nombreRemboursements = value; } }

        /// <summary>
        /// Constructeur classique
        /// </summary>
        /// <param name="_nomClient"></param>
        /// <param name="_capitalEmprunte"></param>
        /// <param name="_nbMois"></param>
        /// <param name="_periodiciteRemboursement"></param>
        /// <param name="_tauxAnnuel"></param>
        public Emprunts(string _nomClient, uint _capitalEmprunte, int _nbMois, string _periodiciteRemboursement, double _tauxAnnuel)
        {
            if (Controles.controleNom(_nomClient))
            {
                nomClient = _nomClient;
            }
            if (Controles.controleCapitalEmprunte(_capitalEmprunte.ToString()))
            {
                capitalEmprunte = _capitalEmprunte;
            }
            nbMois = _nbMois;
            periodiciteRemboursement = _periodiciteRemboursement;
            tauxAnnuel = _tauxAnnuel;
        }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Emprunts() : this (string.Empty, 1, 1, "Mensuelle", 0.07) { }

        /// <summary>
        /// Constructeur par copie
        /// </summary>
        /// <param name="_nouvelEmprunt"></param>
        public Emprunts(Emprunts _nouvelEmprunt) : this
            (
                _nouvelEmprunt.nomClient,
                _nouvelEmprunt.capitalEmprunte,
                _nouvelEmprunt.nbMois,
                _nouvelEmprunt.periodiciteRemboursement,
                _nouvelEmprunt.tauxAnnuel
            )
        { 
        }

        /// <summary>
        /// Calcule le nombre de remboursements en fonction de la périodicité de remboursement
        /// </summary>
        /// <param name="_emprunt"></param>
        /// <returns>Le nombre de remboursements</returns>
        public int calculNbRemboursements()
        {
            if (periodiciteRemboursement == "Mensuelle")
            {
                return nbMois;
            }
            else if (periodiciteRemboursement == "Bimestrielle")
            {
                return nbMois / 2;
            }
            else if (periodiciteRemboursement == "Trimestrielle")
            {
                return nbMois / 3;
            }
            else if (periodiciteRemboursement == "Semestrielle")
            {
                return nbMois / 6;
            }
            else
            {
                return nbMois / 12;
            }
        }

        /// <summary>
        /// Calcule le montant des remboursements
        /// </summary>
        /// <param name="_emprunt"></param>
        /// <returns>Le montant des remboursements</returns>
        public double calculRemboursements()
        {
            nombreRemboursements = calculNbRemboursements();
            double tauxCalcul = calculTauxRemboursements();
            return capitalEmprunte * (tauxCalcul / (1 - Math.Pow((1 + tauxCalcul), -nombreRemboursements)));
        }

        /// <summary>
        /// Calcul le taux d'intérêt en fonction de la périodicité de remboursement
        /// </summary>
        /// <param name="_emprunt"></param>
        /// <returns>Le taux calculé</returns>
        private double calculTauxRemboursements()
        {
            if (periodiciteRemboursement == "Mensuelle")
            {
                return (tauxAnnuel / 12);
            }
            else if (periodiciteRemboursement == "Bimestrielle")
            {
                return (tauxAnnuel / 6);
            }
            else if (periodiciteRemboursement == "Trimestrielle")
            {
                return (tauxAnnuel / 4);
            }
            else if (periodiciteRemboursement == "Semestrielle")
            {
                return (tauxAnnuel / 2);
            }
            else
            {
                return tauxAnnuel;
            }
        }
    }
}
