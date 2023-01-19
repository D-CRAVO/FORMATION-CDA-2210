using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library421
{
    public class Partie
    {
        /// <summary>
        /// Nombre de manches souhaitées
        /// </summary>
        private int nbManchesSouhaitees;
        /// <summary>
        /// Nombre de manches effectuées
        /// </summary>
        private int nbManchesEffectuees;
        /// <summary>
        /// Score de la manche
        /// </summary>
        private int score;
        /// <summary>
        /// Manche courante de la partie
        /// </summary>
        private Manche mancheCourante;

        /// <summary>
        /// Accesseur modifieur du nombre de manches
        /// </summary>
        public int NbManchesSouhaitees
        {
            get { return nbManchesSouhaitees; }
            set { nbManchesSouhaitees = value; }
        }

        /// <summary>
        /// Modifieur du nombre de manches
        /// </summary>
        public int NbManchesEffectuees
        {
            set { nbManchesEffectuees = value; }
        }

        /// <summary>
        /// Constructeur classique
        /// </summary>
        /// <param name="_nbManchesSouhaitees"></param>
        public Partie(int _nbManchesSouhaitees)
        {
            nbManchesSouhaitees = _nbManchesSouhaitees;
            nbManchesEffectuees = 0;
        }

        /// <summary>
        /// Constructeur par défaut avec interdépendance
        /// </summary>
        public Partie() : this
            (
                10
            )
        {}

        /// <summary>
        /// Crée une nouvelle manche pour la partie et incrémente le nombre de parties jouées
        /// </summary>
        public void CreerUneNouvelleManche()
        {
            mancheCourante = new Manche();
            nbManchesEffectuees++;
        }

        /// <summary>
        /// Détermine s'il reste encore une manche à jouer
        /// </summary>
        /// <returns>
        /// True s'il reste encore une manche à jouer
        /// False dans le cas contraire
        /// </returns>
        public bool AEncoreUneMancheAJouer()
        {
            if (nbManchesEffectuees < nbManchesSouhaitees)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Indique si la manche courante a encore un lancé
        /// </summary>
        /// <returns>
        /// True si c'est les cas
        /// False dans le cas contraire
        /// </returns>
        public bool EstCeQueLaMancheCouranteAEncoreUnLance()
        {
            if (mancheCourante.AEncoreUnLance())
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Détermine si la manche courante est gagnée
        /// </summary>
        /// <returns>
        /// True si c'est le cas
        /// False dans le cas contraire
        /// </returns>
        public bool EstCeQueLaMancheCouranteEstGagnee()
        {
            if (mancheCourante.EstGagnee())
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Demande la relance des dés de la manche courante
        /// </summary>
        public void RelancerLesDesDeLaMancheCourante()
        {
            mancheCourante.Relance();
        }

        /// <summary>
        /// Calcule le score de la manche courante
        /// </summary>
        /// <returns>
        /// Le score de la manche courante
        /// </returns>
        public int GetScore()
        {
            if (EstCeQueLaMancheCouranteEstGagnee())
            {
                score = 30;
            }
            else
            {
                score = -10;
            }
            return score;
        }
    }
}
