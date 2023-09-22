using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLBouteille.ExceptionsBouteille
{
    public class ArgumentValeurNegativeException : ArgumentOutOfRangeException
    {
        public ArgumentValeurNegativeException(string? paramName) : base(paramName,String.Format("La valeur ne peux être négative")) { }
    }
}
