using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoitureRevision
{
    public class Roue
    {
        /// <summary>
        /// Indique si la roue tourne
        /// </summary>
        private bool tourne;


        /// <summary>
        /// Constructeur classique
        /// </summary>
        /// <param name="_tourne">Indique si la roue tourne</param>
        public Roue(bool _tourne)
        {
            this.tourne = _tourne;
        }


        /// <summary>
        /// Constructeur par défaut par dépendance
        /// </summary>
        public Roue() : this(false)
        {
            
        }


        /// <summary>
        /// Constructeur de copie par dépendance
        /// </summary>
        /// <param name="_roueCopie">Roue à copier</param>
        public Roue (Roue _roueCopie): this
            (
                _roueCopie.tourne
            )
        { 
        }


        /// <summary>
        /// Fait s'arrêter la roue
        /// </summary>
        /// <returns>
        /// "true" si la roue s'arrête
        /// "false" dans le cas contraire
        /// </returns>
        public bool Arreter()
        {
            if (tourne)
            {
                tourne = false;
                return true;
            }
            return false;
        }


        /// <summary>
        /// Fait tourner la roue
        /// </summary>
        /// <returns>
        /// "true" si la roue se met à tourner
        /// "false" dans le cas contraire
        /// </returns>
        public bool Tourner()
        {
            if (!tourne)
            {
                tourne = true;
                return true;
            }
            return false;
        }
    }
}
