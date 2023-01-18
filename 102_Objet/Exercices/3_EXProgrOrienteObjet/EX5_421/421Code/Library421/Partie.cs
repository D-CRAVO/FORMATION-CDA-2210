using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library421
{
    public class Partie
    {
        private int nbManchesSouhaitees;
        private int nbManchesEffectuees;
        private int score;
        private Manche mancheCourante;

        public int NbManchesSouhaitees
        {
            get { return nbManchesSouhaitees; }
            set { nbManchesSouhaitees = value; }
        }

        public int NbManchesEffectuees
        {
            set { nbManchesEffectuees = value; }
        }

        public int Score
        {
            get { return score; }
        }

        public Partie(int _nbManchesSouhaitees)
        {
            nbManchesSouhaitees = _nbManchesSouhaitees;
            nbManchesEffectuees = 0;
        }

        public Partie() : this
            (
                10
            )
        {}

        public void CreerUneNouvelleManche()
        {
            Manche manche = new Manche();
            nbManchesEffectuees++;
        }

        public bool AEncoreUneMancheAJouer()
        {
            if (nbManchesEffectuees < nbManchesSouhaitees)
            {
                return true;
            }
            return false;
        }

        public bool EstCeQueLaMancheCouranteAEncoreUnLance()
        {
            if (mancheCourante.AEncoreUnLance())
            {
                return true;
            }
            return false;
        }

        public bool EstCeQueLaMancheCouranteEstGagnee()
        {
            if (mancheCourante.EstGagnee())
            {
                return true;
            }
            return false;
        }

        public void RelancerLesDesDeLaMancheCourante()
        {
            mancheCourante.Relance();
        }

        public int GetScore()
        {
            score = 10 * nbManchesSouhaitees;
            if (EstCeQueLaMancheCouranteEstGagnee())
            {
                score += 30;
            }
            else
            {
                score -= 10;
            }
            return score;
        }
    }
}
