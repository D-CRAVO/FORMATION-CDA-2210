using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace exercice_3_7_barnabe
{
    public class CalculNbMagasins
    {
        private int magasins_visites;
        public CalculNbMagasins()
        {
            magasins_visites = 0;
        }


        public int NbMagasinRealisePArBarnabe(float sommeDansLePorteMonnaieDeBarnabe)
        {

            while (sommeDansLePorteMonnaieDeBarnabe > 2)
            {
                sommeDansLePorteMonnaieDeBarnabe = sommeDansLePorteMonnaieDeBarnabe - (sommeDansLePorteMonnaieDeBarnabe / 2 + 1);
                magasins_visites++;
            }
            return magasins_visites + 1;
        }
    } 
}
