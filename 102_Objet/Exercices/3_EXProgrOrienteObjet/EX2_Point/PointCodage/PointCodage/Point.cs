using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointCodage
{
    internal class Point
    {
        private float x;
        private float y;

        /// <summary>
        /// Constructeur classique
        /// </summary>
        /// <param name="_x"></param>
        /// <param name="_y"></param>
        public Point(float _x, float _y)
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
        /// <param name="_nouveauX">Déplacement sur axe des abscisses</param>
        /// <param name="_nouveauY">Déplacement sur axe des ordonnées</param>
        /// <returns>
        /// Les nouvelles caractéristiques du point
        /// </returns>
        public void SeDeplacer(float _nouveauX, float _nouveauY)
        {
            x = _nouveauX;
            y = _nouveauY;
        }

        /// <summary>
        /// Construit un point symétrique par rapport à l'axe des ordonnées
        /// </summary>
        /// <returns></returns>
        public Point SymetrieOrdonnees()
        {
            return new Point(-x, y);
        }

        /// <summary>
        /// Construit un point symétrique par rapport à l'axe des abscisses
        /// </summary>
        /// <returns></returns>
        public Point SymetrieAbscisses()
        {
            return new Point(x, -y);
        }

        /// <summary>
        /// Construit un point symétrique par rapport à l'origine
        /// </summary>
        /// <returns></returns>
        public Point SymetrieOrigine()
        {
            return this.SymetrieAbscisses().SymetrieOrdonnees();
        }

        /// <summary>
        /// Construit un point symétrique par rapport à la bissectrice des axes Ox, Oy
        /// </summary>
        /// <returns></returns>
        public Point SymetrieBissectrice()
        {
            return new Point(y, x);
        }
    }
}
