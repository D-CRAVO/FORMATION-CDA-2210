using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    public class Cappuccino : Cafe
    {
        public Cappuccino() { }

        public override string GetDescription()
        {
            return "Cappuccino";
        }

        public override double GetPrice()
        {
            return 1.5;
        }
    }
}
