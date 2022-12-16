using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LepidoptereRevision
{
    internal class Chenille : StadeEvolution
    {
        public Chenille() { }

        public override string SeDeplacer()
        {
            return "Marcher";
        }

        public override StadeEvolution SeMetamorphoser()
        {
            return new Chrysalide();
        }
    }
}
