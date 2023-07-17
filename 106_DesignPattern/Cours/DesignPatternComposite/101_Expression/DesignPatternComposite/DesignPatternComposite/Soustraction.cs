using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternComposite
{
    public class Soustraction : Binaire
    {
        public Soustraction(Expression op1, Expression op2) : base(op1, op2) { }

        public override double Evalue()
        {
            return op1.Evalue() - op2.Evalue();
        }
    }
}
