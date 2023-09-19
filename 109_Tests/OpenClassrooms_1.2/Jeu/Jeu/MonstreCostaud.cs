using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu1
{
    public class MonstreCostaud : IMonstre
    {
        private int _ptsDeVie;

        public MonstreCostaud(int ptsDeVie)
        {
            _ptsDeVie = ptsDeVie;
        }

        public bool EstVivant()
        {
            return _ptsDeVie > 0;
        }

        public void PerdsUnCombat(int nb)
        {
            _ptsDeVie -= nb;
        }
    }
}
