using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LepidoptereCodage
{
    public class Papillon : StadeEvolution
    {
        public Papillon() { }
        public override string SeDeplacer()
        {
            return "Voler";
        }

        public override StadeEvolution SeMetamorphoser()
        {
            return new Papillon();
        }
    }
}
