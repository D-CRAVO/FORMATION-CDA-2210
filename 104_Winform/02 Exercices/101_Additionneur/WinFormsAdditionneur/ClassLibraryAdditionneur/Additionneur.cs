using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryAdditionneur
{
    public class Additionneur
    {
        public Int32 sum;

        public Additionneur()
        {
            this.sum = 0;
        }

        public int Additionner(Int32 nb)
        {
            return this.sum += nb;
        }

        public override string ToString()
        {
            return $"= {sum} +";
        }

    }
}
