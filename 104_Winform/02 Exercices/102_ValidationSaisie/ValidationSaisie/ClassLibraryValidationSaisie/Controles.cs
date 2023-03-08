using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryValidationSaisie
{
    public class Controles
    {

        public Controles()
        {

        }


        public bool NomValide()
        {
            if (textBoxNom.Text.ToString().Length <= 30)
            {
                return true;
            }
            return false;
        }

    }
}
