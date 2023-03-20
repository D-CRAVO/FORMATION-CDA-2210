using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryValidation
{
    public class Validation
    {
        private string nomClient;
        private uint capitalEmprunte;
        private string periodiciteRemboursement;
        private double tauxAnnuel;
        private int nombreRemboursements;
        private double montantRemboursements;

        public string NomClient { get { return nomClient; } }
        public uint CapitalEmprunte { get { return capitalEmprunte; } }
        public string PeriodiciteRemboursement { get { return periodiciteRemboursement; } }
        public double TauxAnnuel { get { return tauxAnnuel; } }
        public int NombreRemboursements { get { return nombreRemboursements; } }
        public double MontantRemboursements { get { return montantRemboursements; } }

        public Validation(string nomClient, uint capitalEmprunte, string periodiciteRemboursement, double tauxAnnuel, int nombreRemboursements, double montantRemboursements)
        {
            this.nomClient = nomClient;
            this.capitalEmprunte = capitalEmprunte;
            this.periodiciteRemboursement = periodiciteRemboursement;
            this.tauxAnnuel = tauxAnnuel;
            this.nombreRemboursements = nombreRemboursements;
            this.montantRemboursements = montantRemboursements;
        }
    }
}
