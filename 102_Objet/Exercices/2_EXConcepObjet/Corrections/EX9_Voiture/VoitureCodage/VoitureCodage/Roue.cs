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
        private bool tourne;
      

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
            return (!tourne) ? false : true;
        }
    }
}
