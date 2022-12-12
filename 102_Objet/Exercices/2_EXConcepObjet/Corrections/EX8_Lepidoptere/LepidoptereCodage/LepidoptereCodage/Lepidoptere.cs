using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LepidoptereCodage
{
    public class Lepidoptere
    {
        private StadeEvolution stadeCourant;

        public Lepidoptere(StadeEvolution _stadeCourant)
        {
            stadeCourant = _stadeCourant;
        }

        public string SeDeplacer()
        {
            return "Se déplacer";
        }

        public void SeMetamorphoser() { }
    }
}
