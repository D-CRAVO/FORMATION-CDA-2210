using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternComposite
{
    abstract class Binaire : Expression
    {
        private Expression op1;
        private Expression op2;
        public Binaire(Expression _op1, Expression _op2)
        {
            this.op1 = _op1;
            this.op2 = _op2;
        }
    }
}
