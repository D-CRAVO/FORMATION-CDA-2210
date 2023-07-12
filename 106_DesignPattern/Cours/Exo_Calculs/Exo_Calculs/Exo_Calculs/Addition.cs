using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Calculs
{
    public class Addition : Binaire
    {
        public Addition (Expression ex1, Expression ex2) : base(ex1 , ex2){}

        public override double Evalue()
        {
            double somme =  ex1.Evalue() + ex2.Evalue();
            return somme;
        }

        public override string ToString()
        {
            return Evalue().ToString();
        }
    }
}
