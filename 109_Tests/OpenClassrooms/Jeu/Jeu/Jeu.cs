using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Jeu1
{
    public class Jeu
    {
        private readonly IFournisseurMeteo _fournisseurMeteo;
        public Heros Heros { get; }

        /*
        public Jeu() 
        {
            Heros = new Heros(15);
        }
        */

        public Jeu(IFournisseurMeteo fournisseurMeteo)
        {
            Heros = new Heros(15);
            _fournisseurMeteo = fournisseurMeteo;
        }

        public Resultat Tour(int deHeros, int deMonstre)
        {
            if (GagneLeCombat(deHeros, deMonstre))
            {
                Heros.GagneUnCombat();
                return Resultat.Gagne;
            }
            else
            {
                var temps = _fournisseurMeteo.QuelTempsFaitIl();
                if (temps == Meteo.Tempete)
                    Heros.PerdsUnCombat(2 * (deMonstre - deHeros));
                else
                    Heros.PerdsUnCombat(deMonstre - deHeros);
                return Resultat.Perdu;
            }
        }

        private bool GagneLeCombat(int de1, int de2)
        {
            return de1 >= de2;
        }
    }
}
