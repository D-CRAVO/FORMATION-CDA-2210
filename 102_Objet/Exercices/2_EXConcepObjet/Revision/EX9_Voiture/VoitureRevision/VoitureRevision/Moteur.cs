using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoitureRevision
{
    public class Moteur
    {
        private bool enMarche;

        public bool EnMarche { get => enMarche ;}

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

        public bool Allumer()
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
