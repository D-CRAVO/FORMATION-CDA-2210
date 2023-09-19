using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu1
{
    public class ConsoleDeSortie : IConsole
    {
        public void Ecrire(string message)
        {
            Console.WriteLine(message);
        }

        public void EcrireLigne(string message) 
        { 
            Console.Write(message);
        }
    }
}
