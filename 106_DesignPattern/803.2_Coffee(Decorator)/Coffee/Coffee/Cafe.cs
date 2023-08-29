using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    public abstract class Cafe
    {
        protected string description;

        public Cafe()
        {
            description = string.Empty;
        }

        public abstract double GetPrice();
        public abstract string GetDescription();

    }
}
