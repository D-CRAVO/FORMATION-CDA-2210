using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLBouteille.ExceptionsBouteille
{
    public class ExceptionValeurContenanceIncorrecte : Exception
    {
        public ExceptionValeurContenanceIncorrecte() : base(String.Format("Volume de la contenance incorrecte")) { }
    }
}
