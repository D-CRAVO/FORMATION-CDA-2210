using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLBouteille.ExceptionsBouteille
{
    public class ExceptionValeurContenuIncorrecte : Exception
    {
        public ExceptionValeurContenuIncorrecte() : base(String.Format("Volume du contenu incorrecte")) { }
    }
}
