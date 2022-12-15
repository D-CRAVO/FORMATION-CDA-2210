using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoitureRevision
{
    internal class Voiture
    {
        private string marque;
        private Moteur moteur;
        private Roue[] roues;
        Voiture (string _marque, bool _enMarche, bool _tourne)
        {
            marque = _marque;
            moteur = new Moteur (_enMarche);
            roues = new Roue[4];
            roues[0] = new Roue(_tourne);
            roues[1] = new Roue(_tourne);
            roues[2] = new Roue(_tourne); 
            roues[3] = new Roue(_tourne);
        }

        Voiture (string _marque, Moteur _moteur, Roue _roueAvg, Roue _roueAvd, Roue _roueArg, Roue _roueArd)
        {
            marque = _marque;
            moteur = _moteur;
            roues = new Roue[4];
            roues[0] = _roueAvg;
            roues[1] = _roueAvd;
            roues[2] = _roueArg;
            roues[3] = _roueArd;
        }
        
        Voiture() : this
            (
                "Peugeot",
                false,
                false
            ) 
        {
        }

        Voiture(Voiture _voitureCopie) : this
            (
                _voitureCopie.marque,
                new Moteur(_voitureCopie.moteur),
                _voitureCopie.roues[0],
                _voitureCopie.roues[1],
                _voitureCopie.roues[2],
                _voitureCopie.roues[3]
            )
        {
        }
    }
}
