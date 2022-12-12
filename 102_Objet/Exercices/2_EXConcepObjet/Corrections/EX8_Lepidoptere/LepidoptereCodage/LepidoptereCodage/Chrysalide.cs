using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LepidoptereCodage
{
    public class Chrysalide : StadeEvolution
    {
        public Chrysalide() 
        {
        }

        public override string SeDeplacer()
        {
            return "Etre fixé";
        }

        public override StadeEvolution SeMetamorphoser()
        {
            return new Papillon();
        }
    }
}
