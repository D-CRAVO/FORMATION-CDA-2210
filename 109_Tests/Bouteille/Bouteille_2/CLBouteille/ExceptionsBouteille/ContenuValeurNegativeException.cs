using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLBouteille.ExceptionsBouteille
{
    public class ContenuValeurNegativeException : Exception
    {
        public ContenuValeurNegativeException() : base(String.Format("La valeur du contenu ne peut être négative")) { }
    }
}
