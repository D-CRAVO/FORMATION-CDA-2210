using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Création des banques */
            Bank creditMutuel41001 = new Bank("Crédit Mutuel", "Blois", "Bibliothèque");
            Bank creditMutuel41000 = new Bank("Crédit Mutuel", "Blois", "Centre-Ville");
            Bank creditAgricole41000 = new Bank("Crédit Agricole", "Blois", "Centre-Ville");

            /* Création des comptes bancaires */
            BankAccount david = new BankAccount("David", 5000, -250);
            BankAccount john = new BankAccount("John", 2000, -250);
            BankAccount jane = new BankAccount("Jane", 0, 0);


            /* Opérations */
            Console.WriteLine(david.Compare(john));
            creditMutuel41000.AddBankAccount("Rambo", 5000, -250);
            creditMutuel41000.AddBankAccount("Shrek", 2000, -250);
            creditAgricole41000.AddBankAccount("Cendrillon", 0, 0);

            string result01 = creditMutuel41000.ToString(); 

            /* Affichages */
            Console.WriteLine(creditMutuel41001);
            Console.WriteLine(creditMutuel41000);
            Console.WriteLine(creditAgricole41000);
            Console.WriteLine(david);
            Console.WriteLine(john);
            Console.WriteLine(jane);
        }
    }
}
