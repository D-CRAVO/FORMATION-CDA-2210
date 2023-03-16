using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCalculs
{
    public class Calculs
    {
        public static int calculNbMensualites(string _periodicite, int _nbMensualites)
        {
            if (_periodicite == "Mensuelle")
            {
                return _nbMensualites;
            }
            else if (_periodicite == "Bimestrielle")
            {
                return _nbMensualites / 2;
            }
            else if (_periodicite == "Trimestrielle")
            {
                return _nbMensualites / 3;
            }
            else if (_periodicite == "Semestrielle")
            {
                return _nbMensualites / 6;
            }
            else
            {
                return _nbMensualites / 12;
            }
        }

        public static double calculMensualites(double _capitalEmprunte, double _tauxAnnuel, int _nbMensualites)
        {
            return _capitalEmprunte * (_tauxAnnuel / (1 - Math.Pow((1 + _tauxAnnuel), -_nbMensualites)));
        }
    }
}
