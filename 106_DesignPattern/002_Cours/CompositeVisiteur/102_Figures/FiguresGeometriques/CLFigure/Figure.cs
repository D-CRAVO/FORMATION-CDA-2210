using FiguresGeometriques;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CLFigure
{
    public abstract class Figure 
    {
        protected double x;
        protected double y;
        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }

        public Figure(double _x, double _y)
        {
            x = _x;
            y = _y;
        }

        public abstract void Accept(IVisiteurDeFigure _visiteur);
        
    }
}
