using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LepidoptereCodage
{
    public class Larve : StadeEvolution
    {
        public Larve() { }

        public override string SeDeplacer()
        {
            return "Se tortiller";
        }

        public override StadeEvolution SeMetamorphoser()
        {
            return new Chenille();
        }
    }
}
