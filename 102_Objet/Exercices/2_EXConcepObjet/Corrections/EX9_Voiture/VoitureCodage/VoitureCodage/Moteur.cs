using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoitureCodage
{
    internal class Moteur
    {
        /// <summary>
        /// Carburant utilisé par le moteur
        /// </summary>
        private string carburant;


        public Moteur(string _carburant)
        {
            carburant = _carburant;
        }

        public Moteur() : this("gazole") { }

        public Moteur(Moteur _nouveauMoteur) 
            : this
            (
                  _nouveauMoteur.carburant
            )
        {
        }
    }
}
