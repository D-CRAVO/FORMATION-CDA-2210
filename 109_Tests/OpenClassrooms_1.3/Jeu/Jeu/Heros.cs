﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu1
{
    public class Heros
    {
        public int PointDeVies { get; private set; }
        public int Points { get; private set; }

        public Heros(int pointDeVies) 
        {
            PointDeVies = pointDeVies;
        }

        public void GagneUnCombat()
        {
            Points++;
        }

        public void PerdsUnCombat(int nb)
        {
            PointDeVies -= nb;  
        }
    }
}
