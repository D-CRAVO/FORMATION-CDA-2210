using FiguresGeometriques;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLFigure
{
    public class Rectangle : Figure
    {
        private double largeur;
        private double longueur;

        public double Largeur { get { return largeur; } set { largeur = value; } }
        public double Longueur { get { return longueur; } set { longueur = value; } }

        public Rectangle(double _largeur, double _longueur, double _x, double _y) : base(_x, _y)
        {
            this.largeur = _largeur;
            this.longueur = _longueur;
        }

        public override void Accept(IVisiteurDeFigure _visiteur)
        {
            _visiteur.Visit(this);
        }
    }
}
