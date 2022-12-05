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

            /* Opérations sur les comptes */
            try
            {
                david.Crediter(500);
                Console.WriteLine(david);

                david.Debiter(500);
                Console.WriteLine(david);

                david.Transferer(john, 60);
                Console.WriteLine(david);
                Console.WriteLine(john);

                Console.WriteLine(jane);

                Console.WriteLine(jane.Comparer(john));
                Console.WriteLine(jane.Comparer(david));

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
