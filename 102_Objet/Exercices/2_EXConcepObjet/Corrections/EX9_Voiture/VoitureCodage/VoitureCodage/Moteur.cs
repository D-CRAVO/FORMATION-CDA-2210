using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoitureCodage
{
    public class Moteur
    {
        /// <summary>
        /// Carburant utilisé par le moteur
        /// </summary>
        public string carburant;
        public bool enMarche { get; private set; }


        public Moteur(string _carburant, bool _enMarche)
        {
            carburant = _carburant;
            enMarche = _enMarche;
        }

        public Moteur() : this("gazole", false) { }

        public Moteur(Moteur _nouveauMoteur) 
            : this
            (
                  _nouveauMoteur.carburant,
                  _nouveauMoteur.enMarche
            )
        {
        }

        public bool Demarrer()
        {
            return (!enMarche) ? enMarche = true : false;
        }

        public bool Arreter()
        {
            return (enMarche) ? !(enMarche = false) : false;
        }

        public bool EntrainerRoue(Roue _roueAvantGauche, Roue _roueAvantDroite)
        {
            return (enMarche && _roueAvantGauche.FaireTourner() && _roueAvantDroite.FaireTourner()) ? true : false;
        }

        
    }
}
