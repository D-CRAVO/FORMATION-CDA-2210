using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LepidoptereRevision
{
    internal class Lepidoptere
    {
        private StadeEvolution stadeCourant;

        public Lepidoptere(StadeEvolution _stadeCourant)
        {
            this.stadeCourant = _stadeCourant;
        }

        public string SeDeplacer()
        {
            return stadeCourant.SeDeplacer();
        }

        public void SeMetamorphoser()
        {
            stadeCourant.SeMetamorphoser();
        }
    }
}
