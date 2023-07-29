using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternComposite
{
    public abstract class Expression
    {
        public abstract double Evalue();

        public override string ToString()
        {
            return " = " + base.ToString();
        }
    }
}
