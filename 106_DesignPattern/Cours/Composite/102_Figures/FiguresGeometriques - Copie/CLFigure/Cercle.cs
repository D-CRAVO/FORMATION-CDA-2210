using FiguresGeometriques;

namespace CLFigure
{
    public class Cercle : Figure
    {
        private double rayon;
        public double Rayon { get { return rayon; } }
        public Cercle(double _rayon, double _x, double _y) : base (_x,_y)
        { 
            this.rayon = _rayon;
        }

        public override void Accept(IVisiteurDeFigure _visiteur)
        {
            _visiteur.Visit(this);
        }
    }
}