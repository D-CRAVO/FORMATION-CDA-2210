using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTransaction
{
    public class Transaction
    {
        private string nom;
        private DateOnly date;
        private float montant;
        private int codePostal;

        public string Nom { get { return nom; } }
        public DateOnly Date { get { return date; } }
        public float Montant { get { return montant; } }
        public int CodePostal { get { return codePostal; } }
        public Transaction(string _nom, DateOnly _date, float _montant, int _codePostal)
        {
            this.nom = _nom;
            this.date = _date;
            this.montant = _montant;
            this.codePostal = _codePostal;
        }
    }
}
