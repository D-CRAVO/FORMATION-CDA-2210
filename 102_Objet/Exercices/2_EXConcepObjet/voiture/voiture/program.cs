using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voiture
{
    internal class program
    {
        static void Main(string[] args)
        {
            //Moteur leonMoteur = new Moteur("diesel", 2.0, 184, false);
            //Roue leonRoue = new Roue(0, new Pneu(205, 55, 1.9), new Jante("aluminium", "gris", 17));
            Voiture leon = new Voiture("Seat", "Leon", 0, 200, new Moteur("diesel", 2.0, 184, false), new Roue(0, new Pneu(205, 55, 1.9), new Jante("aluminium", "gris", 17)));
        }
    }
}
