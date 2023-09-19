using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu1
{
    public class Monstre : IMonstre
    {
        private bool _estVivant;

        public Monstre() 
        {
            _estVivant = true;  
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
