using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoitureRevision
{
    internal class Moteur
    {
        private bool enMarche;

        public Moteur (bool _enMarche)
        {
            enMarche = _enMarche;
        }

        public Moteur() : this(false){ }

        public Moteur(Moteur _moteurCopie) : this 
            (
                _moteurCopie.enMarche
            )
        {
        }

        public bool Demarrer()
        {
            if (!enMarche)
            {
                enMarche = true;
                return true;
            }
            return false;
        }

        public bool Eteindre()
        {
            if (enMarche)
            {
                enMarche = false;
                return true;
            }
            return false;
        }

        public bool EntrainerRoue(Roue _roueAvg, Roue _roueAvd)
        {
            return enMarche && _roueAvg.Tourner() && _roueAvd.Tourner();
        }
    }
}
