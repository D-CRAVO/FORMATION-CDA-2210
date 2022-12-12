using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointCodage
{
    internal class Point
    {
        private string name;
        private double x;
        private double y;


        /// <summary>
        /// Constructeur classique
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_x"></param>
        /// <param name="_y"></param>
        public Point(string _name, double _x, double _y)
        {
            name = _name;
            x = _x;
            y = _y;
        }


        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Point():this("O",0,0) 
        {
        }


        public Point(Point _nouveauPoint) : this
            (
                _nouveauPoint.name,
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
            return $"Le point {this.name} a pour coordonnées ({x},{y})";
        }


        /// <summary>
        /// Retourne la position du point
        /// </summary>
        /// <returns>
        /// Les caractéristiques du point
        /// </returns>
        public Point IndiquerPosition()
        {
            return new Point(name, x, y);
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
            return new Point(name, x, y);
        }

        public Point SymetrieOrdonnees()
        {
            y = -y;
            return new Point(name, x, y);
        }

        public Point SymetrieAbscisses()
        {
            x = -x;
            return new Point(name, x, y);
        }

        public Point SymetrieOrigine()
        {
            return this.SymetrieAbscisses().SymetrieOrdonnees();
        }
    }
}
