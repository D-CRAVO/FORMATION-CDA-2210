﻿using System;
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
            Point pointA = new Point("A",4,2);
            Point pointB = new Point(pointA);
            Point pointC = new Point(pointA);
            Console.WriteLine(pointO.IndiquerPosition());
            Point result01 = pointO.SeDeplacer(2, 3);

            Point result02 = pointB.SymetrieOrdonnees();
            Point result03 = pointB.SymetrieAbscisses();
            Point result04 = pointC.SymetrieOrigine();
        }
    }
}