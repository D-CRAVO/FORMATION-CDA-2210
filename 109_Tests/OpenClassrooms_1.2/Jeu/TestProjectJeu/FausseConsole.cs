using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jeu1;

namespace TestProjectJeu
{
    public class FausseConsole : IConsole
    {
        public StringBuilder StringBuilder = new StringBuilder();

        public void Ecrire(string message)
        {
            StringBuilder.Append(message);
        }

        public void EcrireLigne(string message)
        {
            StringBuilder.AppendLine(message);
        }
    }
}
