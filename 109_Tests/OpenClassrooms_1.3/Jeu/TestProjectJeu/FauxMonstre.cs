using Jeu1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectJeu
{
    public class FauxMonstre : IMonstre
    {
        private bool _estVivant;
        public FauxMonstre() 
        {
            _estVivant = false;
        }

        public bool EstVivant()
        {
            return _estVivant;
        }

        public void PerdsUnCombat(int nb)
        {
            _estVivant = false;
        }
    }
}
