using CLFigure;
using FiguresGeometriques;

Cercle cercle = new Cercle(5, 0, 0);
cercle.Accept(new VisiteurDeFigurePourConsole());

Rectangle rectangle = new Rectangle(10, 20, 0, 0);
rectangle.Accept(new VisiteurDeFigurePourConsole());

List<Figure> mesFigures = new List<Figure>();
mesFigures.Add(cercle);
mesFigures.Add(rectangle);
Figures figures = new Figures(mesFigures, -5, -5);
figures.Accept(new VisiteurDeFigurePourConsole());
