using CLFigure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresGeometriques
{
    internal class VisiteurDeFigurePourConsole : IVisiteurDeFigure
    {

        public void Visit(Cercle _cercle)
        {
            Console.WriteLine("Je suis un cercle à la position (" + _cercle.X + ";" + _cercle.Y + ") de rayon " + _cercle.Rayon);
        }

        public void Visit(Rectangle _rectangle)
        {
            Console.WriteLine("Je suis un rectangle à la position (" + _rectangle.X + ";" + _rectangle.Y + ") de longueur " + _rectangle.Longueur); 
        }

        public void Visit(Figures _figures)
        {
            Console.WriteLine("Je suis une figure de référentiel (" + _figures.X + ";" + _figures.Y +")");
        }
    }
}
