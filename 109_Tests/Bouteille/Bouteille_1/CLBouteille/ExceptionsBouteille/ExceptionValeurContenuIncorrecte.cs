using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouteille_1.ExceptionsBouteille
{
    public class ExceptionValeurContenuIncorrecte : Exception
    {
        public ExceptionValeurContenuIncorrecte() : base(String.Format("Volume incorrecte")) { }
    }
}
