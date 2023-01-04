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

                bool result2 = david.Debiter(5000);

                bool result3 = david.TransfererVers(john, 60);


                string result4 = jane.Comparer(john);
                string result5 = jane.Comparer(david);

            }
            catch (Exception e)
            {
                string result = e.Message;
            }
            
        }
    }
}
