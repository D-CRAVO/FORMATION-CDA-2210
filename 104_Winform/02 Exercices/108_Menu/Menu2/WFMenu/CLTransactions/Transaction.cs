using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLTransactions
{
    public class Transaction
    {
        private string nom;
        private DateOnly date;
        private float montant;
        private string cp;

        public string Nom { get { return nom; } }
        public DateOnly Date { get { return date; } }
        public float Montant { get { return montant; } }
        public string Cp { get { return cp; } }

        public Transaction(string nom, DateOnly date, float montant, string cp)
        {
            this.nom = nom;
            this.date = date;
            this.montant = montant;
            this.cp = cp;
        }

    }
}
