using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoitureCodage
{
    public class Moteur
    {
        private bool enMarche;
        /// <summary>
        /// Constructeur générique d'un moteur. 
        /// </summary>
        /// <param name="_enMarche"></param>
        public Moteur(bool _enMarche)
        {
            this.enMarche = _enMarche;
        }
        /// <summary>
        /// Constructeur par défaut d'un moteur. 
        /// </summary>
        public Moteur()
        {
            this.enMarche = false;
        }
        //public Moteur() : this(false) { }
        /// <summary>
        /// Constructeur par copie d'un moteur. 
        /// </summary>
        /// <param name="_moteurACopier"></param>
        public Moteur(Moteur _moteurACopier)
        {
            this.enMarche = _moteurACopier.enMarche;
        }
        /// <summary>
        /// Bascule enMarche de false à true. 
        /// Si enMarche est déjà true, la méthode ne fait rien. 
        /// </summary>
        /// <returns>Retourne false si déjà enMarche est déjà true ou 
        /// retourne true si enMarche est initialement false. </returns>
        public bool Demarrer()
        {
            if (this.enMarche == true)
            {
                return false;
            }
            else
            {
                this.enMarche = true;
                return true;
            }
        }
        public bool EntrainerRoues(Roue roue1, Roue roue2)
        {
            if (this.enMarche)
            {
                bool rt1 = roue1.Tourner();
                bool rt2 = roue2.Tourner();
                if (rt1 == true && rt2 == true)//if (rt1 && rt2)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Permet de stopper 
        /// </summary>
        /// <param name="roue1"></param>
        /// <param name="roue2"></param>
        /// <returns></returns>
        public bool ArreterRoues(Roue roue1, Roue roue2)
        {
            bool rt1 = roue1.Stopper();
            bool rt2 = roue2.Stopper();
            if (rt1 && rt2)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Permet de passer enMarche de true à false. 
        /// </summary>
        /// <returns>Retourne true si enMarche passe de true à false. </returns>
        public bool Eteindre()
        {
            if (this.enMarche)
            {
                this.enMarche = false;
                return true;
            }
            return false;
        }
    }
}
