using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Calculs
{
    public abstract class Binaire : Expression
    {
        protected Expression ex1;
        protected Expression ex2;

        public Binaire(Expression ex1, Expression ex2)
        {
            this.ex1 = ex1;
            this.ex2 = ex2;

        }
        
    }
}
