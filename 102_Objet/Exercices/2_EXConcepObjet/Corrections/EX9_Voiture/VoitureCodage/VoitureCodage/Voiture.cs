using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoitureCodage
{
    public class Voiture
    {
        private string marque;
        private Moteur moteur;
        public Dictionary<string, Roue> roues = new Dictionary<string, Roue>(4);

        public Voiture (string _marque, string _carburant, bool _enMarche, uint _diametre, bool _tourne)
        {
            marque = _marque;
            moteur = new Moteur (_carburant, _enMarche);
            roues.Add("avd", new Roue(_diametre, _tourne));
            roues.Add("avg", new Roue(_diametre, _tourne));
            roues.Add("ard", new Roue(_diametre, _tourne));
            roues.Add("arg", new Roue(_diametre, _tourne));
        }

        public Voiture () : this("Seat", "Gazole", false, 15, false)
        { }

        public Voiture(Voiture _nouvelleVoiture) : this
            (
                _nouvelleVoiture.marque,
                _nouvelleVoiture.moteur),
                _nouvelleVoiture.roues,
                _nouvelleVoiture.estDemarre
            )
        {
        }

        public bool Demarrer()
        {
            return moteur.Demarrer();
        }

        public bool Arreter()
        {
            return  moteur.Arreter();
        }

        public bool Avancer()
        {
            return moteur.EntrainerRoue(roues["avg"], roues["avd"]);
        }
    }
}
