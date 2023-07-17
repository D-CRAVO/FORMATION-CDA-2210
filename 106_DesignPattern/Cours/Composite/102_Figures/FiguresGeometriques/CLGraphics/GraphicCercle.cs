using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLGraphics
{
    public class GraphicCercle
    {
        private int x;
        private int y;
        private int longueur;
        private int largeur;

        public int X { get { return x; } }
        public int Y { get { return y; } }
        public int Longueur { get { return longueur; } }
        public int Largeur { get { return largeur; } }

        public GraphicCercle(CLFigure.Cercle _cercle) 
        { 
            this.x = int.Parse((_cercle.X - _cercle.Rayon).ToString());
            this.y = int.Parse((_cercle.Y - _cercle.Rayon).ToString());
            this.longueur = int.Parse((_cercle.Rayon*2).ToString());
            this.largeur = this.longueur;
        }
    }
}
