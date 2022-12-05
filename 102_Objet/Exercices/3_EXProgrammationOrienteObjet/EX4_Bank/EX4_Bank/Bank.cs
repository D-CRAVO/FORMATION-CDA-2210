using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Bank
    {
        /**
         * Propriétés
         */
        private string name { get; }
        private string city { get; }
        private string district { get; }

        /**
         * Constructeur
         */
        public Bank(string _name, string _city, string _district)
        {
            this.name = _name;
            this.city = _city;
            this.district = _district;
        }
        private List<BankAccount> allBankAccount = new List<BankAccount>();

        /**
         * Affichage
         */
        public override string ToString()
        {
            return $"La banque {name} de la ville de {city} du quartier {district}.";
        }


        /**
         * 
         */
        public void AddBankAccount(BankAccount _bankAccount)
        {
            allBankAccount.Add(_bankAccount);
        }

        public void ShowAllBankAccount()
        {
            Console.WriteLine($"{this} possède les {allBankAccount.Count} comptes suivants : ");
            for (int i = 0; i < allBankAccount.Count; i++)
            {
                Console.WriteLine(allBankAccount[i].ToString());
            }
        }

    }
}
