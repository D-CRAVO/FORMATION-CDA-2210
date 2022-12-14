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
        private Moteur sonMoteur;
        private Roue[] ses4roues;
        //version dictionnaire
        //private Dictionary<string, Roue> ses4Roues2;
        /// <summary>
        /// Constructeur par défaut de Voiture. 
        /// </summary>
        public Voiture()
        {
            this.marque = "Peugeot";
            this.sonMoteur = new Moteur();
            //this.ses4roues = new Roue[4] {new Roue(),
            //new Roue(), new Roue(), new Roue()};
            this.ses4roues = new Roue[4];
            this.ses4roues[0] = new Roue();//roue avant droite
            this.ses4roues[1] = new Roue();//roue avant gauche
            this.ses4roues[2] = new Roue();//roue arriere droite
            this.ses4roues[3] = new Roue();//roue arriere gauche
            //version dictionnaire
            /*ses4Roues2 = new Dictionary<string, Roue>();
            ses4Roues2.Add("rad", new Roue());
            ses4Roues2.Add("rag", new Roue());
            ses4Roues2.Add("rard", new Roue());
            ses4Roues2.Add("rarg", new Roue());*/
        }
        /// <summary>
        /// Constructeur classique d'une voiture V1. 
        /// </summary>
        /// <param name="_marque"></param>
        /// <param name="_sonMoteur"></param>
        /// <param name="_ses4roues"></param>
        public Voiture(string _marque, Moteur _sonMoteur, Roue[] _ses4roues)
        {
            this.marque = _marque;
            this.sonMoteur = _sonMoteur;
            this.ses4roues = _ses4roues;
        }
        /// <summary>
        /// Autre constructeur classique de Voiture V2. 
        /// </summary>
        /// <param name="_marque"></param>
        /// <param name="_sonMoteur"></param>
        /// <param name="_roue1"></param>
        /// <param name="_roue2"></param>
        /// <param name="_roue3"></param>
        /// <param name="_roue4"></param>
        public Voiture(string _marque, Moteur _sonMoteur, Roue _roue1, Roue _roue2,
            Roue _roue3, Roue _roue4)
        {
            this.marque = _marque;
            this.sonMoteur = _sonMoteur;
            this.ses4roues = new Roue[4] { _roue1, _roue2, _roue3, _roue4 };
        }
        /// <summary>
        /// Encore un autre constructeur classique de Voiture V3. 
        /// </summary>
        /// <param name="_marque"></param>
        /// <param name="_enMarche"></param>
        /// <param name="_tourne"></param>
        /// <param name="_dimensionPneu"></param>
        public Voiture(string _marque, bool _enMarche, bool _tourne, string _dimensionPneu)
        {
            this.marque = _marque;
            this.sonMoteur = new Moteur(_enMarche);
            this.ses4roues = new Roue[4] {new Roue(_tourne,_dimensionPneu),
                new Roue(_tourne, _dimensionPneu) , new Roue(_tourne,_dimensionPneu),
                new Roue(_tourne,_dimensionPneu)};
        }
        /// <summary>
        /// Constructeur par copie de Voiture. 
        /// </summary>
        /// <param name="_voitureACopier"></param>
        /*public Voiture(Voiture _voitureACopier)
        {
            this.marque = _voitureACopier.marque;
            this.sonMoteur = new Moteur(_voitureACopier.sonMoteur);
            //this.sonMoteur = _voitureACopier.sonMoteur; //ne pas faire ça 
            this.ses4roues = new Roue[] {new Roue(_voitureACopier.ses4roues[0]),
            new Roue(_voitureACopier.ses4roues[1]),
            new Roue(_voitureACopier.ses4roues[2]),
            new Roue(_voitureACopier.ses4roues[3])};
        }*/
        /// <summary>
        /// Autre constructeur par recopie avec référence avec un constructeur classique. 
        /// </summary>
        /// <param name="_voitureACopier"></param>
        public Voiture(Voiture _voitureACopier) : this(_voitureACopier.marque,
            new Moteur(_voitureACopier.sonMoteur),
            new Roue[] { new Roue(_voitureACopier.ses4roues[0]),
            new Roue(_voitureACopier.ses4roues[1]),
            new Roue(_voitureACopier.ses4roues[2]),
            new Roue(_voitureACopier.ses4roues[3])})
        { }
        /// <summary>
        /// Appelle la méthode Démarrer de Moteur. 
        /// </summary>
        /// <returns>Voir retour de Moteur.Demarrer(). </returns>
        public bool Demarrer()
        {
            return sonMoteur.Demarrer();
        }
        /// <summary>
        /// Permet d'appeler la méthode EntrainerRoue de Moteur. 
        /// </summary>
        /// <returns>Voir retour de Moteur.EntrainerRoue. </returns>
        public bool Avancer()
        {
            return sonMoteur.EntrainerRoues(ses4roues[0], ses4roues[1]);
            //return sonMoteur.EntrainerRoue(ses4Roues2["rad"], ses4Roues2["rag"]);//version dictionnaire
        }
        /// <summary>
        /// Permet d'appeler la méthode Freiner de Moteur. 
        /// </summary>
        /// <returns>Voir retour de Moteur.Freiner. </returns>
        public bool Freiner()
        {
            return sonMoteur.ArreterRoues(ses4roues[0], ses4roues[1]);
        }
        /// <summary>
        /// Permet d'éteindre le moteur si les roues ne tournent pas. 
        /// </summary>
        /// <returns>Voir retour de Moteur.Eteindre. </returns>
        public bool CouperContact()
        {
            //ses4roues[0].Tourne = true; impossible car pas de set dans la propriété Tourne. 
            //if !(ses4roues[0].Tourne || ses4roues[1].Tourne)
            //if (ses4roues[0].Tourne==false && ses4roues[1].Tourne==false)
            if (!ses4roues[0].Tourne && !ses4roues[1].Tourne)
            {
                return sonMoteur.Eteindre();
            }
            return false;
        }
    }
}
