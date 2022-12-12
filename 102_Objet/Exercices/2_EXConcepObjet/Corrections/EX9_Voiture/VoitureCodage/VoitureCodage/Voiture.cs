using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoitureCodage
{
    internal class Voiture
    {
        private string marque;
        private Moteur moteur;
        private Roue[] roues = new Roue[5];
        private bool estArrete;

        public Voiture (string _marque, string _carburant, uint _diametre, bool _estArrete)
        {
            marque = _marque;
            moteur = new Moteur (_carburant);
            roues[1] = roues[2] = roues[3] = roues[4] = new Roue(_diametre);
            estArrete = _estArrete;
        }

        public Voiture () : this
        { }
    }
}
