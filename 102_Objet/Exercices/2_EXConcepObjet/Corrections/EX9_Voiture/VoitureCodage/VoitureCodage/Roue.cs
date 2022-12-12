using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoitureCodage
{
    internal class Roue
    {
        /// <summary>
        /// Diametre de la jante en Pouces
        /// </summary>
        private uint diametre;
      

        public Roue(uint _diametre)
        {
            diametre = _diametre;
        }

        public Roue() : this(15) { }

        public Roue(Roue _nouvelleRoue) 
            : this
            (
                _nouvelleRoue.diametre
            )
        {
        }
    }
}
