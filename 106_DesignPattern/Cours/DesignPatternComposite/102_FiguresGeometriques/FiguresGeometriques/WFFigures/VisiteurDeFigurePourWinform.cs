using CLFigure;
using FiguresGeometriques;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFFigures
{
    internal class VisiteurDeFigurePourWinform : IVisiteurDeFigure
    {
        public void Visit(Cercle _cercle)
        {

        }

        public void Visit(CLFigure.Rectangle _rectangle) 
        {
            FormFigures formFigures = new FormFigures(_rectangle);
        }

        public void Visit(Figures _figures)
        {

        }
    }
}
