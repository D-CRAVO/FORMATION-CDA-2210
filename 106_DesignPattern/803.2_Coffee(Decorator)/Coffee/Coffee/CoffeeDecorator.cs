using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    public abstract class CoffeeDecorator : Cafe
    {
        protected Cafe decoratedCoffee;
        public CoffeeDecorator(Cafe coffee) 
        { 
            decoratedCoffee = coffee;
        }
    }
}
