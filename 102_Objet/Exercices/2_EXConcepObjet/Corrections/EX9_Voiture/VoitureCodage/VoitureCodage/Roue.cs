using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoitureCodage
{
    public class Roue
    {
        private bool tourne;
        private string dimensionPneu;
        public bool Tourne { get => tourne; /*set => tourne = value;*/ }
        /// <summary>
        /// Constructeur générique d'une roue. 
        /// </summary>
        /// <param name="_tourne"></param>
        /// <param name="_dimensionPneu"></param>
        public Roue(bool _tourne, string _dimensionPneu)
        {
            this.tourne = _tourne;
            this.dimensionPneu = _dimensionPneu;
        }
        /// <summary>
        /// Constructeur par défaut d'une roue. 
        /// </summary>
        public Roue()
        {
            this.tourne = false;
            this.dimensionPneu = "1.0";
        }
        //public Roue() : this(false, "1.0") { }
        /// <summary>
        /// Constructeur par copie d'une roue. 
        /// </summary>
        /// <param name="_roueACopier"></param>
        public Roue(Roue _roueACopier)
        {
            this.tourne = _roueACopier.tourne;
            this.dimensionPneu = _roueACopier.dimensionPneu;
        }
        /*public Roue(Roue _roueACopier) :
        this(_roueACopier.tourne,
            _roueACopier.dimensionPneu)
        { }*/
        public bool Tourner()
        {
            if (this.tourne == true)
            {
                return false;
            }
            else
            {
                this.tourne = true;
                return true;
            }
        }
        /// <summary>
        /// Méthode pour stopper une roue. 
        /// </summary>
        /// <returns>Retourne true si on passe de tourne=true à tourne=false. </returns>
        public bool Stopper()
        {
            if (this.tourne)
            {
                this.tourne = false;
                return true;
            }
            return false;
        }
    }
}
