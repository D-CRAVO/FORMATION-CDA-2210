using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTransactions
{
    public class Transactions
    {
        private string nom;
        private DateOnly date;
        private float montant;
        private int codePostal;

        public string Nom { get { return nom; } }
        public DateOnly Date { get { return date; } }
        public float Montant { get { return montant; } }
        public int CodePostal { get { return codePostal; } }

        public Transactions(string _nom, DateOnly _date, float _montant, int _codePostal) 
        {
            nom = _nom;
            date = _date;
            montant = _montant;
            codePostal = _codePostal;
        }

        
    }
}
