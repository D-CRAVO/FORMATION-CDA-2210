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
        private char cp;

        public Transaction(string nom, DateOnly date, float montant, char cp)
        {
            this.nom = nom;
            this.date = date;
            this.montant = montant;
            this.cp = cp;
        }

    }
}
