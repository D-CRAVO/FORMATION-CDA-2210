using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class BankAccount
    {
        /**
         * Constantes
         */
        public static uint accountNumberSeed = 1;

        /**
         * Propriétés
         */
        private float balance { get; set; }
        private uint number { get; set; }
        private int overdraft { get; set; }
        private string owner { get; set; }


        /**
         * Méthodes
         */


        /*
         * Constructeur
         */
        public BankAccount(string _owner, float _balance, int _overdraft)
        {
            number = accountNumberSeed;
            accountNumberSeed++;
            owner = _owner;
            balance = _balance;
            overdraft = _overdraft;
        }



        /**
         * Affiche toutes les informations du compte bancaire.
         */
        public override string ToString()
        {
            return $"Le compte {number} a pour propriétaire {owner}, pour solde {balance} euros, et pour découvert autorisé {overdraft} euros";
        }

        public string Compare(BankAccount _otherBankAccount)
        {
            if (balance < _otherBankAccount.balance)
            {
                return $"Le solde du compte de {owner} est inférieur au solde du compte de {_otherBankAccount.owner}";
            }
            return $"Le solde du compte de {owner} est supérieur au solde du compte de {_otherBankAccount.owner}";
        }
    }
}
