using FiguresGeometriques;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLFigure
{
    public class Figures : Figure
    {
        private List<Figure> sesFigures = new List<Figure>();

        //private double xs;
        //private double ys;

        //public double Xs { get { return xs; } set { xs = value; } }
        //public double Ys { get { return ys; } set { ys = value; } }

        public Figures(List<Figure> _sesFigures, double _x, double _y) : base(_x, _y)
        {
            this.sesFigures = _sesFigures;
            //this.xs = _x;
            //this.ys = _y;
        }

        public override void Accept(IVisiteurDeFigure _visiteur)
        {
            _visiteur.Visit(this);  
            foreach (var f in sesFigures)
            {
                f.X = f.X + this.x;
                f.Y = f.Y + this.y;
                f.Accept(_visiteur);
            }
        }

        public void Add(Figure _figure) 
        {
            sesFigures.Add(_figure);
        }

        public void Remove(Figure _figure)
        { 
            sesFigures.Remove(_figure);
        }
    }
}
