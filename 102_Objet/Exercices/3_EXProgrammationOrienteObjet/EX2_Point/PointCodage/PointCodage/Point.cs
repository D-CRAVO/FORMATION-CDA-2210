using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointCodage
{
    internal class Point
    {
        private double x;
        private double y;

        /// <summary>
        /// Constructeur classique
        /// </summary>
        /// <param name="_x"></param>
        /// <param name="_y"></param>
        public Point(double _x, double _y)
        {
            x = _x;
            y = _y;
        }

        /// <summary>
        /// Constructeur par défaut avec interdépendance
        /// </summary>
        public Point():this(0,0) 
        {
        }

        /// <summary>
        /// Constructeur par copie avec interdépendance
        /// </summary>
        /// <param name="_nouveauPoint"></param>
        public Point(Point _nouveauPoint) : this
            (
                _nouveauPoint.x,
                _nouveauPoint.y
            )
        {
        }

        /// <summary>
        /// Permet d'afficher les caractéristiques du point
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Le point a pour coordonnées ({x},{y})";
        }

        /// <summary>
        /// Déplace le point de _dx suivant les abscisses
        /// Et de _dy suivant les ordonnées
        /// </summary>
        /// <param name="_dx">Déplacement sur axe des abscisses</param>
        /// <param name="_dy">Déplacement sur axe des ordonnées</param>
        /// <returns>
        /// Les nouvelles caractéristiques du point
        /// </returns>
        public Point SeDeplacer(double _dx, double _dy)
        {
            x += _dx;
            y += _dy;
            return new Point(x, y);
        }

        public Point SymetrieOrdonnees()
        {
            return new Point(-x, y);
        }

        public Point SymetrieAbscisses()
        {
            return new Point(x, -y);
        }

        public Point SymetrieOrigine()
        {
            return this.SymetrieAbscisses().SymetrieOrdonnees();
        }
    }
}
