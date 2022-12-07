using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bouteille
{
    public class Bouteille
    {
        private float contenanceEnCl;
        private float contenuActuelEnCl;
        private bool estOuverte;


        //constructeur par default
        public Bouteille()
        {
            contenanceEnCl = 100;
            contenuActuelEnCl = 100;
            estOuverte = false;
        }


        //constructeur classique
        public Bouteille(float _contenanceEnCl,
            float _contenuActuelEnCl,
            bool _estOuverte)
        {
            contenanceEnCl = _contenanceEnCl;
            contenuActuelEnCl = _contenuActuelEnCl;
            estOuverte = _estOuverte;
        }


        //constructeur par recopie(clonage)
        public Bouteille(Bouteille _bouteilleACopier)
        {
            contenanceEnCl = _bouteilleACopier.contenanceEnCl;
            contenuActuelEnCl = _bouteilleACopier.contenuActuelEnCl;
            estOuverte = _bouteilleACopier.estOuverte;
        }


        /// <summary>
        /// Ouvre la bouteille, peut échouer si elle est déja ouverte
        /// </summary>
        /// <returns>renvoie un booleen true si réussi, false sinon</returns>
        public bool Ouvrir()
        {
            if (estOuverte == true)
            {
                return false;
            }
            else
            {
                estOuverte = true;
                return true;
            }
        }


        /// <summary>
        /// Fermer la bouteille
        /// </summary>
        /// <returns></returns>
        public bool Fermer()
        {
            if (estOuverte == false)
            {
                return false;
            }
            else
            {
                estOuverte = false;
                return true;
            }
        }


        /// <summary>
        ///  Used to empty the bottle with the quantity in parameter
        /// </summary>
        /// <param  type="float" name="quantiteAViderEnCl">the quantity to empty in CL</param>
        /// <returns>true if allow ,false instead</returns>
        public bool Vider(float quantiteAViderEnCl)
        {
            if (this.estOuverte 
                && this.contenuActuelEnCl >= quantiteAViderEnCl 
                && quantiteAViderEnCl > 0)
            {
                this.contenuActuelEnCl -= quantiteAViderEnCl;
                return true;
            }
            return false;
        }


        /// <summary>
        /// Used to totally empty the bottle
        /// </summary>
        /// <seealso cref="Vider(float param)"/>
        /// <returns type="bool">true if allow, false instead</returns>
        public bool Vider()
        {
            return Vider(this.contenuActuelEnCl);
        }


        /// <summary>
        /// Used to fill the bottle with the quantity in parameter
        /// </summary>
        /// <param name="quantiteARemplirEnCl">the quantity to fill in CL</param>
        /// <returns>true if allow ,false instead</returns>
        public bool Remplir(float quantiteARemplirEnCl)
        {
            if (estOuverte 
                && quantiteARemplirEnCl > 0 
                && quantiteARemplirEnCl <= contenanceEnCl - contenuActuelEnCl)
            {
                contenuActuelEnCl += quantiteARemplirEnCl;
                return true;
            }
            return false;
        }
       

        /// <summary>
        /// Used to fill the bottle
        /// </summary>
        /// <remarks><seealso cref="Remplir(float)"/></remarks>
        /// <returns>true if allow ,false instead</returns>
        public bool Remplir()
        {
            return Remplir(contenanceEnCl - contenuActuelEnCl);
        }
    }
}


