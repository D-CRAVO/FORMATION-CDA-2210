using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLElementsChimiques
{
    public abstract class ElementChimique
    {
        private string nom;
        protected IReaction? reaction;

        public string Nom { get { return nom; } }

        public ElementChimique(string nom, IReaction? reaction)
        {
            this.nom = nom;
            this.reaction = reaction;
        }

        public abstract void Associer();

    }
}
