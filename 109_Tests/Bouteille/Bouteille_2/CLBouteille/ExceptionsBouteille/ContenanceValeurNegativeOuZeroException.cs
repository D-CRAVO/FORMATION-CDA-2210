using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLBouteille.ExceptionsBouteille
{
    public class ContenanceValeurNegativeOuZeroException: Exception
    {
        public ContenanceValeurNegativeOuZeroException() : base(String.Format("Le volume de la contenance ne peut pas être négative ou égale à Zero ")) { }
    }
}
