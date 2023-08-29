using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    public class Expresso : Cafe
    {
        public Expresso() { }

        public override string GetDescription()
        {
            return "Expresso";
        }

        public override double GetPrice()
        {
            return 1.5;
        }
    }
}
