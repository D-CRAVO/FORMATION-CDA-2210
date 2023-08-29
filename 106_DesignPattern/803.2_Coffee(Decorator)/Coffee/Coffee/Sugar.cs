using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    public class Sugar : CoffeeDecorator
    {
        public Sugar(Cafe coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return decoratedCoffee.GetDescription() + "with Sugar";
        }

        public override double GetPrice()
        {
            return decoratedCoffee.GetPrice() + 0.5;
        }
    }
}
