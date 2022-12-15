using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LepidoptereRevision
{
    public class Oeuf : StadeEvolution
    {
        public Oeuf() { }

        public override string SeDeplacer()
        {
            return "Rouler";
        }

        public override StadeEvolution SeMetamorphoser()
        {
            return new Chenille();
        }

    }
}
