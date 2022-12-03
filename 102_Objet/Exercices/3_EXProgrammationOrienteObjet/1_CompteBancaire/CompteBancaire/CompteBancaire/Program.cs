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
            // Console.WriteLine($"Le Compte Bancaire {CompteBancaire.numero}")
            // Aurait pu être utilisé si la propriété numero avait été "public" et non "private"

            /* Opérations sur les comptes */
            david.Crediter(500);
            Console.WriteLine(david);

            david.Debiter(500);
            Console.WriteLine(david);

            david.Transferer(john, 60);
            Console.WriteLine(david);
            Console.WriteLine(john);

            Console.WriteLine(jane);
        }
    }
}
