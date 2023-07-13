using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternComposite
{
    public class Addition : Binaire
    {
        public Addition(Expression op1, Expression op2) : base(op1, op2) { }
        public override double Evalue()
        {
            return op1.Evalue() + op2.Evalue();
        }

        public override string ToString()
        {
            return Evalue().ToString();
        }
    }
}
!