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

        private double x;
        private double y;

        public double X { get { return x; } }
        public double Y { get { return y; } }

        public Figures(List<Figure> _sesFigures, double _x, double _y) : base(_x, _y)
        {
            this.sesFigures = _sesFigures;
            x = _x;
            y = _y;
        }

        public override void Accept(IVisiteurDeFigure _visiteur)
        {
            _visiteur.Visit(this);  
            foreach (var f in sesFigures)
            {
                f.X = f.X + x;
                f.Y = f.Y + y;
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
