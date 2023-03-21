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
        private string? nomClient;
        private uint capitalEmprunte;
        private int nbMois;
        private string periodicite;
        private double tauxAnnuel;

        public static readonly string mensuelle = "Mensuelle";
        public static readonly string bimestrielle = "Bimestrielle";
        public static readonly string trimestrielle = "Trimestrielle";
        public static readonly string semestrielle = "Semestrielle";
        public static readonly string annuelle = "Annuelle";

        public enum enumPeriodicite
        {
            mensuelle = 1,
            bimestrielle = 2,
            trimestrielle = 3,
            semestrielle = 6,
            annuelle = 12
        }

        public string? NomClient { get { return nomClient; } set { nomClient = value; } }
        public uint CapitalEmprunte { get { return capitalEmprunte; } set { capitalEmprunte = value; } }
        public int NbMois { get { return nbMois; } set { nbMois = value; } }
        public string Periodicite { get { return periodicite; } set { periodicite = value; } }
        public double TauxAnnuel { get { return tauxAnnuel; } set { tauxAnnuel = value; } }

        //public string Mensuelle { get { return mensuelle; } }
        //public string Bimestrielle { get { return bimestrielle; } }
        //public string Trimestrielle { get {  return trimestrielle; } }
        //public string Semestrielle { get { return semestrielle; } }
        //public string Annuelle { get { return annuelle; } }

        /// <summary>
        /// Constructeur classique
        /// </summary>
        /// <param name="_nomClient"></param>
        /// <param name="_capitalEmprunte"></param>
        /// <param name="_nbMois"></param>
        /// <param name="_periodicite"></param>
        /// <param name="_tauxAnnuel"></param>
        public Emprunts(string? _nomClient, uint _capitalEmprunte, int _nbMois, string _periodicite, double _tauxAnnuel)
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
            periodicite = _periodicite;
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
                _nouvelEmprunt.periodicite,
                _nouvelEmprunt.tauxAnnuel
            )
        { 
        }

        /// <summary>
        /// Calcule le nombre de remboursements en fonction de la périodicité de remboursement
        /// </summary>
        /// <returns>Nombre de remboursements</returns>
        public int calculNbRemboursements()
        {
            if (periodicite == mensuelle)
            {
                return nbMois;
            }
            else if (periodicite == bimestrielle)
            {
                return nbMois / 2;
            }
            else if (periodicite == trimestrielle)
            {
                return nbMois / 3;
            }
            else if (periodicite == semestrielle)
            {
                return nbMois / 6;
            }
            else
            {
                return nbMois / 12;
            }
        }

        /// <summary>
        /// Calcul le taux d'intérêt en fonction de la périodicité de remboursement
        /// </summary>
        /// <returns>Le taux pour le calcul du montant des remboursements</returns>
        private double calculTauxRemboursements()
        {
            if (periodicite == mensuelle)
            {
                return (tauxAnnuel / 12);
            }
            else if (periodicite == bimestrielle)
            {
                return (tauxAnnuel / 6);
            }
            else if (periodicite == trimestrielle)
            {
                return (tauxAnnuel / 4);
            }
            else if (periodicite == semestrielle)
            {
                return (tauxAnnuel / 2);
            }
            else
            {
                return tauxAnnuel;
            }
        }

        /// <summary>
        /// Calcule le montant des remboursements
        /// </summary>
        /// <returns>Le montant des remboursements</returns>
        public double calculRemboursements()
        {
            return capitalEmprunte * (calculTauxRemboursements() / (1 - Math.Pow((1 + calculTauxRemboursements()), -calculNbRemboursements())));
        }
    }
}
