using CLFigure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresGeometriques
{
    public interface IVisiteurDeFigure
    {
        public abstract void Visit(Cercle _cercle);
        public abstract void Visit(Rectangle _rectangle);
        public abstract void Visit(Figures _figures);
    }
}
