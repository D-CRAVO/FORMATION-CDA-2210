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
        // private Roue[] roues;

        /// <summary>
        /// Constructeur générique de Voiture
        /// </summary>
        /// <param name="_marque">Marque de la voiture</param>
        /// <param name="_carburant">Type de carburant utilisé par le moteur</param>
        /// <param name="_enMarche">Indique si le moteur est en marche</param>
        /// <param name="_diametre">Diametre de la roue</param>
        /// <param name="_tourne">Indique si la roue tourne</param>
        public Voiture (string _marque, string _carburant, bool _enMarche, uint _diametre, bool _tourne)
        {
            marque = _marque;
            moteur = new Moteur (_carburant, _enMarche);
            roues.Add("avd", new Roue(_diametre, _tourne));
            roues.Add("avg", new Roue(_diametre, _tourne));
            roues.Add("ard", new Roue(_diametre, _tourne));
            roues.Add("arg", new Roue(_diametre, _tourne));
            // roues = new Roue[4];
            // roues[0] = new Roue(); // Roue avant droite
            // roues[1] = new Roue(); // Roue avant gauche
            // roues[2] = new Roue(); // Roue arrière droite
            // roues[3] = new Roue(); // Roue arrière gauche
        }

        //public Voiture(string _marque, Moteur _moteur, Roue _r1, Roue _r2, Roue _r3, Roue _r4)
        //{
        //    marque = _marque;
        //    moteur = new Moteur(_moteur);
        //    roues.Add("avd", new Roue(_r1));
        //    roues.Add("avg", new Roue(_r2));
        //    roues.Add("ard", new Roue(_r3));
        //    roues.Add("arg", new Roue(_r4));
        //}


        /// <summary>
        /// Constructeur par défaut de la voiture
        /// </summary>
        public Voiture () : this("Seat", "Gazole", false, 15, false)
        { }

        
        //public Voiture(Voiture _nouvelleVoiture) : this
        //    (
        //        _nouvelleVoiture.marque,
        //        _nouvelleVoiture.moteur,
        //        _nouvelleVoiture.roues["avd"],
        //        _nouvelleVoiture.roues["avg"],
        //        _nouvelleVoiture.roues["ard"],
        //        _nouvelleVoiture.roues["arg"]
        //    )
        //{
        //}

        /// <summary>
        /// Constructeur par copie de voiture
        /// </summary>
        /// <param name="_nouvelleVoiture">Voiture à copier</param>
        public Voiture(Voiture _nouvelleVoiture)
        {
            marque = _nouvelleVoiture.marque;
            moteur = new Moteur(_nouvelleVoiture.moteur);
            roues["avd"] = new Roue(_nouvelleVoiture.roues["avd"]);
            roues["avg"] = new Roue(_nouvelleVoiture.roues["avg"]);
            roues["ard"] = new Roue(_nouvelleVoiture.roues["ard"]);
            roues["arg"] = new Roue(_nouvelleVoiture.roues["arg"]);
        }

        /// <summary>
        /// Demarrer la voiture
        /// </summary>
        /// <returns></returns>
        public bool Demarrer()
        {
            return moteur.Demarrer();
        }
        
        /// <summary>
        /// Faire avancer la voiture
        /// </summary>
        /// <returns></returns>
        public bool Avancer()
        {
            return moteur.EntrainerRoues(roues["avg"], roues["avd"]);
            // return moteur.EntrainerRoues(roues[0], roues[1]);
        }

        /// <summary>
        /// Freiner la voiture
        /// </summary>
        /// <returns></returns>
        public bool Freiner()
        {
            return moteur.ArreterRoues(roues["avg"], roues["avd"]);
            // return moteur.ArreterRoues(roues[0], roues[1]);
        }

        /// <summary>
        /// Permet de couper le contact
        /// </summary>
        /// <returns></returns>
        public bool CouperContact()
        {
            if (!roues["avg"].Tourne && !roues["avd"].Tourne)
            {
                return moteur.Eteindre();
            }
            return false;
        }
    }
}
