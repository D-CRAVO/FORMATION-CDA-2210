using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LepidoptereImplementation
{
    public abstract class StadeEvolution
    {
        StadeEvolution() 
        {

        }

        public abstract string SeDeplacer();

        public abstract StadeEvolution SeMetamorphoser();
    }

    
    
}
