using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLBouteille.ExceptionsBouteille
{
    public class ExceptionQuantiteAjouterTropImportante : Exception
    {
        public ExceptionQuantiteAjouterTropImportante() : base(String.Format("Quantité à ajouter trop importante")) { }
    }
}
