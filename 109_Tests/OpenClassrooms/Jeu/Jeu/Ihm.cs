﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu
{
    public class Ihm
    {
        public void Demarre()
        {
            De de = new De();
            var jeu = new Jeu();
            Console.WriteLine($"A l'attaque : points/vie {jeu.Heros.Points}/{jeu.Heros.PointDeVies}");
            while (jeu.Heros.PointDeVies > 0)
            {
                var resultat = jeu.Tour(de.Lance(), de.Lance());
                switch (resultat)
                {
                    case Resultat.Gagne:
                        Console.WriteLine($"Monstre battu");
                        break;
                    case Resultat.Perdu:
                        Console.WriteLine($"Combat perdu");
                        break;
                }
                Console.WriteLine($": points/vie {jeu.Heros.Points}/{jeu.Heros.PointDeVies}");
            }
        }
    }
}
