using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoitureCodage
{
    public class Roue
    {
        /// <summary>
        /// Diametre de la jante en Pouces
        /// </summary>
        private uint diametre;
        private bool tourne ;
      
        public bool Tourne { get => tourne;  /*set => tourne = value;*/ }

        public Roue(uint _diametre, bool _tourne)
        {
            diametre = _diametre;
            tourne = _tourne;
        }

        public Roue() : this(15, false) { }

        public Roue(Roue _nouvelleRoue) 
            : this
            (
                _nouvelleRoue.diametre,
                _nouvelleRoue.tourne
            )
        {
        }

        public bool FaireTourner() 
        {
            if (!tourne)
            {
                tourne=true;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Methode pour stopper une roue
        /// </summary>
        /// <returns>
        /// Retourne true et passe tourne à false
        /// Sinon retourne false
        /// </returns>
        public bool Stopper()
        {
            if (tourne)
            {
                tourne = false;
                return true;
            }
            return false;
        }
    }
}
