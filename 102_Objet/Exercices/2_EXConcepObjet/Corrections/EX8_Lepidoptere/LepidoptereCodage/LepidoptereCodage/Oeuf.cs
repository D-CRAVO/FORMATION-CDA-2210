using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LepidoptereCodage
{
    public class Oeuf : StadeEvolution
    {
        public Oeuf() 
        {
        }

        public override string SeDeplacer()
        {
            return "Coller";
        }

        public override StadeEvolution SeMetamorphoser()
        {
            return new Larve();
        }
    }
}
