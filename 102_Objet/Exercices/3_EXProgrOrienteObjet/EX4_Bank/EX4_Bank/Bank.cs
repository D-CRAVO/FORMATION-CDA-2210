using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Bank
    {
        /// <summary>
        /// Nom de la banque
        /// </summary>
        private string name { get; }
        /// <summary>
        /// Ville de la banque
        /// </summary>
        private string city { get; }
        /// <summary>
        /// Quartier de la banque
        /// </summary>
        private string district { get; }
        /// <summary>
        /// Liste des comptes de la banque
        /// </summary>
        private List<BankAccount> allBankAccount = new List<BankAccount>();

        /// <summary>
        /// Constructeur classique
        /// </summary>
        /// <param name="_name">Nom de la banque</param>
        /// <param name="_city">Ville de la banque</param>
        /// <param name="_district">Quartier de la banque</param>
        public Bank(string _name, string _city, string _district)
        {
            name = _name;
            city = _city;
            district = _district;
        }
        

        /// <summary>
        /// Réécriture de la méthode ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string resultBank =  $"La banque {name} de la ville de {city} du quartier {district} possède les comptes :\n";
            string resultAccount = "";
            for (int i = 0; i < allBankAccount.Count; i++)
            {
                resultAccount  += allBankAccount[i].ToString() + "\n";
            }
            return resultBank + resultAccount;
        }


        /// <summary>
        /// Ajout de compte bancaire à la banque
        /// </summary>
        /// <param name="_bankAccount">Compte bancaire ajouté</param>
        private void AddBankAccount(BankAccount _bankAccount)
        {
            allBankAccount.Add(_bankAccount);
        }

        /// <summary>
        /// Crée et ajoute un compte bancaire à la banque
        /// </summary>
        /// <param name="_owner">Propriétaire du compte bancaire</param>
        /// <param name="_overdraft">Découvert autorisé du compte bancaire</param>
        /// <param name="_balance">Solde du compte bancaire</param>
        public void AddBankAccount(string _owner, int _overdraft, float _balance)
        {
            BankAccount _bankAccount = new BankAccount(_owner, _balance, _overdraft);
            allBankAccount.Add(_bankAccount);
        }

        //public void ShowAllBankAccount()
        //{
        //    Console.WriteLine($"{this} possède les {allBankAccount.Count} comptes suivants : ");
        //    for (int i = 0; i < allBankAccount.Count; i++)
        //    {
        //        Console.WriteLine(allBankAccount[i].ToString());
        //    }
        //}

    }
}
