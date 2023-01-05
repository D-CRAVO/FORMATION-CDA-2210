using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCodage
{
    internal class Fraction
    {
        public int numerateur;
        public int denominateur;

        /// <summary>
        /// Constructeur classique
        /// </summary>
        /// <param name="_numerateur"></param>
        /// <param name="_denominateur"></param>
        /// <exception cref="InvalidOperationException"></exception>
        public Fraction (int _numerateur, int _denominateur)
        {
            this.numerateur = _numerateur;
            if (_denominateur == 0)
            {
                throw new InvalidOperationException ("Il est impossible de diviser par zéro");
            }
            this.denominateur = _denominateur;
        }

        /// <summary>
        /// Constructeur par défaut avec interdépendance
        /// </summary>
        public Fraction () : this (0, 1) 
        {
        }

        /// <summary>
        /// Constructeur par copie avec interdépendance
        /// </summary>
        /// <param name="_fraction"></param>
        public Fraction (Fraction _fraction) : this
            (
                _fraction.numerateur,
                _fraction.denominateur
            )
        {
        }

        /// <summary>
        /// Constructeur sans passage de dénominateur avec interdépendance
        /// </summary>
        /// <param name="_numerateur"></param>
        public Fraction (int _numerateur) : this 
            (
                _numerateur,
                1
            )
        {
        }

        /// <summary>
        /// Réécriture de la méthode ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (this.denominateur == 1)
            {
                return $"{this.numerateur}";
            }else if (this.denominateur == 0)
            {
                return "0";
            }
            else
            {
                return $"{this.numerateur}/{this.denominateur}";
            }
        }

        /// <summary>
        /// Construit l'opposé de la fraction
        /// </summary>
        /// <returns></returns>
        public Fraction Oppose()
        {
            return new Fraction(-this.numerateur, this.denominateur);
        }

        /// <summary>
        /// Construit l'inverse de la fraction 
        /// </summary>
        /// <returns></returns>
        public Fraction Inverse()
        {
            return new Fraction(this.denominateur, this.numerateur);
        }

        /// <summary>
        /// Verifie si la fraction courante est supérieur à la fraction passée en paramètre
        /// </summary>
        /// <param name="_fraction"></param>
        /// <returns>
        /// True si la fraction courante est supérieure à la fraction passée en paramètre
        /// False dans le cas contraire
        /// </returns>
        public bool SuperieurA(Fraction _fraction)
        {
            Fraction a = this.DenominateurCommun(_fraction);
            Fraction b = _fraction.DenominateurCommun(this);
            //if (this.numerateur * _fraction.denominateur > _fraction.numerateur * this.denominateur)
            //{
            //    return true;
            //}
            return false;
        }

        /// <summary>
        /// Verifie si la fraction courante est égale à la fraction passée en paramètre
        /// </summary>
        /// <param name="_fraction"></param>
        /// <returns>
        /// True s'il y a égalité
        /// False dans le cas contraire
        /// </returns>
        public bool EgalA(Fraction _fraction)
        {
            if (this.numerateur * _fraction.denominateur == _fraction.numerateur * this.denominateur)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Determine le plus grand dénominateur commun de la fraction
        /// </summary>
        /// <returns>
        /// Le pgcd de la fraction
        /// </returns>
        private int GetPgcd()
        {
            int a = this.numerateur;
            int b = this.denominateur;
            int pgcd = 1;
            if (a!=0 && b != 0)
            {
                if (a < 0) a = -a;
                if (b < 0) b = -b;
                while (a != b) 
                {
                    if (a < b)
                    {
                        b = b - a;
                    }
                    else
                    {
                        a = a - b;
                    }
                }
                pgcd = a;
            }
            return pgcd;
        }

        /// <summary>
        /// Reduit la fraction courante
        /// </summary>
        /// <returns>
        /// La fraction réduite
        /// </returns>
        private Fraction Reduire()
        {
            if (this.denominateur<0 && this.numerateur < 0)
            {
                this.denominateur = -this.denominateur;
                this.numerateur = -this.numerateur;
            }
            else if (this.denominateur < 0 && this.numerateur > 0)
            {
                this.numerateur = -this.numerateur;
                this.denominateur = -this.denominateur;
            }
            int pgcd = this.GetPgcd();
            return new Fraction(this.numerateur/pgcd, this.denominateur/pgcd);
        }

        public Fraction DenominateurCommun(Fraction _fraction)
        {
            return new Fraction(this.numerateur * _fraction.denominateur, this.denominateur * _fraction.denominateur);
        }



    }
}
