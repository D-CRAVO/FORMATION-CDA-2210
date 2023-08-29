using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    public class Milk : CoffeeDecorator
    {
        public Milk(Cafe coffee) : base (coffee)
        {
            
        }

        public override string GetDescription()
        {
            return decoratedCoffee.GetDescription() + " with Milk";
        }

        public override double GetPrice()
        {
            return decoratedCoffee.GetPrice() + 0.5;
        }
    }
}
