using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Calculs
{
    public class Nombre : Expression
    {
        private double valeur;
 

        /// <summary>
        /// Contructeur classic
        /// </summary>
        public Nombre(double valeur)
        {
            this.valeur = valeur;
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
