using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointCodage
{
    internal class program
    {
        static void Main(string[] args)
        {
            Point pointO = new Point();
            Point pointA = new Point(4,2);
            Point pointB = new Point(pointA);
            Point pointC = new Point(pointA);
            string information1 = pointA.ToString(); // (4, 2)
            pointA.SeDeplacer(-2, -3);
            string information2 = pointA.ToString(); // (-2, -3)

            Point symetriqueOrdonnee = pointB.SymetrieOrdonnees(); // (-4, 2)
            Point symetriqueAbcisse = pointB.SymetrieAbscisses(); // (4, -2)
            Point symetriqueOrigine = pointB.SymetrieOrigine(); // (-4, -2)
            Point symetriqueBissectrice = pointB.SymetrieBissectrice(); // (2, 4)
        }
    }
}
