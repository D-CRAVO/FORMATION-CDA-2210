﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu1
{
    public class FournisseurMeteo : IFournisseurMeteo
    {
        private readonly Random _random;

        public FournisseurMeteo()
        {
            _random = new Random();
        }

        public Meteo QuelTempsFaitIl()
        {
            var tirage = _random.Next(0, 21);
            if (tirage < 10)
                return Meteo.Soleil;
            if (tirage < 20)
                return Meteo.Pluie;
            return Meteo.Tempete;
        }
    }
}
