using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFraction
{
    public class Fraction
    {
        public int numerateur;
        public int denominateur;

        /// <summary>
        /// Constructeur classique
        /// </summary>
        /// <param name="_numerateur"></param>
        /// <param name="_denominateur"></param>
        /// <exception cref="InvalidOperationException"></exception>
        public Fraction(int _numerateur, int _denominateur)
        {
            numerateur = _numerateur;
            if (_denominateur == 0)
            {
                throw new InvalidOperationException("Il est impossible de diviser par zéro");
            }
            denominateur = _denominateur;
            if (denominateur < 0 && numerateur < 0)
            {
                denominateur = -denominateur;
                numerateur = -numerateur;
            }
            else if (denominateur < 0 && numerateur > 0)
            {
                numerateur = -numerateur;
                denominateur = -denominateur;
            }
        }

        /// <summary>
        /// Constructeur par défaut avec interdépendance
        /// </summary>
        public Fraction() : this(0, 1)
        {
        }

        /// <summary>
        /// Constructeur par copie avec interdépendance
        /// </summary>
        /// <param name="_fraction"></param>
        public Fraction(Fraction _fraction) : this
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
        public Fraction(int _numerateur) : this
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
            }
            else if (this.denominateur == 0)
            {
                return "0";
            }
            else
            {
                return $"{this.numerateur}/{this.denominateur}";
            }
        }

        //private void Signe()
        //{
        //    if (this.denominateur < 0 && this.numerateur < 0)
        //    {
        //        this.denominateur = -this.denominateur;
        //        this.numerateur = -this.numerateur;
        //    }
        //    else if (this.denominateur < 0 && this.numerateur > 0)
        //    {
        //        this.numerateur = -this.numerateur;
        //        this.denominateur = -this.denominateur;
        //    }
        //}

        /// <summary>
        /// Construit l'opposé de la fraction
        /// </summary>
        /// <returns></returns>
        public void Oppose()
        {
            denominateur = -denominateur;
        }

        /// <summary>
        /// Construit l'inverse de la fraction 
        /// </summary>
        /// <returns></returns>
        public void Inverse()
        {
            int temp = denominateur;
            denominateur = numerateur;
            numerateur = temp;
        }

        /// <summary>
        /// Construit une copie de la fraction courante avec le même dénominateur que la fraction passée en paramètre
        /// </summary>
        /// <param name="_fraction"></param>
        /// <returns></returns>
        private Fraction DenominateurCommun(Fraction _fraction)
        {
            return new Fraction(this.numerateur * _fraction.denominateur, this.denominateur * _fraction.denominateur);
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
            if (a.numerateur > b.numerateur)
            {
                return true;
            }
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
            Fraction a = this.DenominateurCommun(_fraction);
            Fraction b = _fraction.DenominateurCommun(this);
            if (a.numerateur == b.numerateur)
            {
                return true;
            }
            //if (this.numerateur * _fraction.denominateur == _fraction.numerateur * this.denominateur)
            //{
            //    return true;
            //}
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
            if (a != 0 && b != 0)
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
            if (this.numerateur == 0)
            {
                return new Fraction();
            }
            int pgcd = this.GetPgcd();
            return new Fraction(this.numerateur / pgcd, this.denominateur / pgcd);
        }

        /// <summary>
        /// Additionne la fraction courante à la fraction passée en paramètre
        /// </summary>
        /// <param name="_fraction"></param>
        /// <returns></returns>
        public Fraction Plus(Fraction _fraction)
        {
            Fraction a = this.DenominateurCommun(_fraction);
            Fraction b = _fraction.DenominateurCommun(this);
            Fraction c = new Fraction(a.numerateur + b.numerateur, a.denominateur);
            return c.Reduire();
        }

        /// <summary>
        /// Soustrait la fraction passée en paramètre à la fraction courante
        /// </summary>
        /// <param name="_fraction"></param>
        /// <returns></returns>
        public Fraction Moins(Fraction _fraction)
        {
            Fraction a = this.DenominateurCommun(_fraction);
            Fraction b = _fraction.DenominateurCommun(this);
            b.Oppose();
            Fraction c = a.Plus(b);
            return c;
        }

        /// <summary>
        /// Multiplie la fraction courante par la fraction passée en paramètre
        /// </summary>
        /// <param name="_fraction"></param>
        /// <returns></returns>
        public Fraction Multiplie(Fraction _fraction)
        {
            return new Fraction(this.numerateur * _fraction.numerateur, this.denominateur * _fraction.denominateur).Reduire();
        }

        /// <summary>
        /// Divise la fraction courante par la fraction passée en paramètre
        /// </summary>
        /// <param name="_fraction"></param>
        /// <returns></returns>
        public Fraction Divise(Fraction _fraction)
        {
            _fraction.Inverse();
            return this.Multiplie(_fraction);
        }


        public static Fraction operator +(Fraction left, Fraction right)
        {
            return new Fraction(left.Plus(right));
        }

        public static Fraction operator -(Fraction left, Fraction right)
        {
            return new Fraction(left.Moins(right));
        }

        public static Fraction operator *(Fraction left, Fraction right)
        {
            return new Fraction(left.Multiplie(right));
        }

        public static Fraction operator /(Fraction left, Fraction right)
        {
            return new Fraction(left.Divise(right));
        }
    }
}
