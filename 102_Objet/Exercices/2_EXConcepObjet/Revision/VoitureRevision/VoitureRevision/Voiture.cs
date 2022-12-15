using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoitureRevision
{
    public class Voiture
    {
        private string marque;
        private Moteur moteur;
        private Roue[] roues;

        public Voiture (string _marque, bool _enMarche, bool _tourne)
        {
            marque = _marque;
            moteur = new Moteur (_enMarche);
            roues = new Roue[4];
            roues[0] = new Roue(_tourne);
            roues[1] = new Roue(_tourne);
            roues[2] = new Roue(_tourne); 
            roues[3] = new Roue(_tourne);
        }

        public Voiture(string _marque, Moteur _moteur, Roue _roueAvg, Roue _roueAvd, Roue _roueArg, Roue _roueArd)
        {
            marque = _marque;
            moteur = _moteur;
            roues = new Roue[4];
            roues[0] = _roueAvg;
            roues[1] = _roueAvd;
            roues[2] = _roueArg;
            roues[3] = _roueArd;
        }
        
        public Voiture() : this
            (
                "Peugeot",
                false,
                false
            ) 
        {
        }

        public Voiture(Voiture _voitureCopie) : this
            (
                _voitureCopie.marque,
                new Moteur(_voitureCopie.moteur),
                new Roue(_voitureCopie.roues[0]),
                new Roue(_voitureCopie.roues[1]),
                new Roue(_voitureCopie.roues[2]),
                new Roue(_voitureCopie.roues[3])
            )
        {
        }

        public bool Demarrer()
        {
            return moteur.Allumer();
        }

        public bool CouperContact()
        {
            return !roues[0].Tourne && !roues[1].Tourne && moteur.Eteindre();
        }

        public bool Avancer()
        {
            return moteur.EnMarche && roues[0].Tourner() && roues[1].Tourner();
        }

        public bool Freiner()
        {
            return roues[0].Arreter() && roues[1].Arreter();
        }
    }
}
