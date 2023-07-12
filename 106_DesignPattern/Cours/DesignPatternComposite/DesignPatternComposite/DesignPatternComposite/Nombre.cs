using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternComposite
{
    public class Nombre : Expression
    {
        private double valeur;
        public Nombre(Double _valeur) 
        {
            this.valeur = _valeur;
        }

        public override double Evalue()
        {
            return valeur;
        }

        public override string ToString()
        {
            return this.Evalue().ToString();
        }
    }
}
