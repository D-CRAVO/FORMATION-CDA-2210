using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLElementsChimiques
{
    public abstract class Element
    {
        private string nom;

        public string Nom { get { return nom; } }

        public Element(string nom)
        {
            this.nom = nom;
        }

        public abstract void Associer();

    }
}
