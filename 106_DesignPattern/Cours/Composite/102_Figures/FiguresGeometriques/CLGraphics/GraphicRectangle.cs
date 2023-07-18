using System.Drawing;

namespace CLGraphics
{
    public class GraphicRectangle
    {
        private int x;
        private int y;
        private int largeur;
        private int longueur;

        public int X { get { return x; } }
        public int Y { get { return y; } }
        public int Largeur { get { return largeur; } }
        public int Longueur { get { return longueur; } }


        public GraphicRectangle(CLFigure.Rectangle _rectangle)
        {
            this.x = int.Parse(_rectangle.X.ToString());
            this.y = int.Parse(_rectangle.Y.ToString());
            this.largeur = int.Parse(_rectangle.Largeur.ToString());
            this.longueur = int.Parse(_rectangle.Longueur.ToString());
        }
        
        
    }
}