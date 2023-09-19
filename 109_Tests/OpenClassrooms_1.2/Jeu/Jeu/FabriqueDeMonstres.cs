using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu1
{
    public class FabriqueDeMonstres : IFabriqueDeMonstres
    {
        private readonly Random _random;

        public FabriqueDeMonstres()
        {
            _random = new Random();
        }
        public IEnumerable<IMonstre> GetMonstres()
        {
            int nbMonstres = _random.Next(1,10);

            for (int i = 0; i < nbMonstres; i++)
            {
                if (_random.Next(0, 2) == 0)
                {
                    yield return new Monstre();
                }
                else
                {
                    int nbPtsDeVie = _random.Next(1, 10);
                    yield return new MonstreCostaud(nbPtsDeVie);
                }
            }
        }
    }
}
