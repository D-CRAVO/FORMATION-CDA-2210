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
        /// Type de carburant utilisé par le moteur
        /// </summary>
        public string carburant;
        /// <summary>
        /// Indique si le moteur est en marche
        /// </summary>
        public bool enMarche { get; private set; }

        /// <summary>
        /// Constructeur générique du moteur
        /// </summary>
        /// <param name="_carburant">Type de carburant utilisé par le moteur</param>
        /// <param name="_enMarche">Indique si le moteur est en marche</param>
        public Moteur(string _carburant, bool _enMarche)
        {
            carburant = _carburant;
            enMarche = _enMarche;
        }

        /// <summary>
        /// Constructeur par défaut du moteur
        /// </summary>
        public Moteur() : this("gazole", false) { }

        /// <summary>
        /// Constructeur par copie du moteur
        /// </summary>
        /// <param name="_nouveauMoteur">Moteur à copier</param>
        public Moteur(Moteur _nouveauMoteur) 
            : this
            (
                  _nouveauMoteur.carburant,
                  _nouveauMoteur.enMarche
            )
        {
        }
        /// <summary>
        /// Demarre le moteur
        /// </summary>
        /// <returns>
        /// Passe à enMarche à true et renvoie true si la voiture est arrêtée
        /// Renvoie false si la voiture est déjà démarrée
        /// </returns>
        public bool Demarrer()
        {
            if (!enMarche)
            {
                enMarche=true;
                return true;
            }
            return false;
            //return (!enMarche) ? enMarche = true : false;
        }

        /// <summary>
        /// Arrête le moteur
        /// </summary>
        /// <returns>
        /// Passe enMarche à false et renvoie true si le moteur est en marche
        /// Renvoie false si le moteur est déjà arrêté
        /// </returns>
        public bool Eteindre()
        {
            if (enMarche)
            {
                enMarche = false;
                return true;
            }
            return false;
            // return (enMarche) ? !(enMarche = false) : false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_roueAvantGauche"></param>
        /// <param name="_roueAvantDroite"></param>
        /// <returns></returns>
        public bool EntrainerRoues(Roue _roueAvantGauche, Roue _roueAvantDroite)
        {
            return (enMarche && _roueAvantGauche.FaireTourner() && _roueAvantDroite.FaireTourner());
        }

        public bool ArreterRoues(Roue _roueAvantGauche, Roue _roueAvantDroite)
        {
            return (_roueAvantGauche.Stopper() && _roueAvantDroite.Stopper());
        }
    }
}
