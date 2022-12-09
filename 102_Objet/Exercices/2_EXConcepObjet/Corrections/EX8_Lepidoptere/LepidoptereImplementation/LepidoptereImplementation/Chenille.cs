using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LepidoptereImplementation
{
    internal class Chenille : StadeEvolution
    {
        public override string SeDeplacer()
        {
            return "essai";
        }

        public override StadeEvolution SeMetamorphoser() { return new Chenille(); }

    }
}
