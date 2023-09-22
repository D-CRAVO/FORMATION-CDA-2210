using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLBouteille.ExceptionsBouteille
{
    public class ContenuSuperieurContenanceException :Exception
    {
        public ContenuSuperieurContenanceException(): base(String.Format("Volume de la contenance incorrecte")) { }
    }
}
