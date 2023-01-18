using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleException
{
    internal class Fractions
    {
        int numerateur;
        int denominateur;

        public Fractions(int _numerateur, int _denominateur)
        {
            numerateur= _numerateur;
            denominateur= _denominateur;    
        }

        public Fractions(int _numerateur) : this (_numerateur, 1) { }
    }
}
