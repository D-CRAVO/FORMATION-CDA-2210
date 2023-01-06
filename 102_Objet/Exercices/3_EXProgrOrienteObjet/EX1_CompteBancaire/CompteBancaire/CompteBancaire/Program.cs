using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaire
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Création des comptes bancaires */
            CompteBancaire david = new CompteBancaire("David", 0, -250);
            CompteBancaire john = new CompteBancaire("John", 0, -500);
            CompteBancaire jane = new CompteBancaire();

            // Console.WriteLine(david);

            /* Opérations sur les comptes */
            try
            {
                david.Crediter(500);
                string informationsCompte = david.ToString();    

                bool debiterTrue = david.Debiter(100); // true
                // bool debiterFalse = david.Debiter(5000); // exception

                bool transfererTrue = david.TransfererVers(john, 60); // true
                // bool transfererFalse = david.TransfererVers(john, 5000); // exception


                string result4 = jane.Comparer(john);
                string result5 = david.Comparer(john);
                bool superieurTrue = david.SuperieurA(john); // true
                bool superieurFalse = jane.SuperieurA(david); // false

            }
            catch (Exception e)
            {
                string result = e.Message;
            }
            
        }
    }
}
