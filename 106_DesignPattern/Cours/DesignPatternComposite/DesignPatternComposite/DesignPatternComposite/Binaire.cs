using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternComposite
{
    public abstract class Binaire : Expression
    {
        protected Expression op1;
        protected Expression op2;

        public Binaire(Expression op1, Expression op2)
        {
            this.op1 = op1;
            this.op2 = op2;
        }
    }
}
