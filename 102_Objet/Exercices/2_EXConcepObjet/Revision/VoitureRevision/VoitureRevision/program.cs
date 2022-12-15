using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoitureRevision
{
    internal class program
    {
        static void Main(string[] args)
        {
            Roue roueAvd = new Roue(false);
            Roue roueAvg = new Roue();
            bool result01 = roueAvd.Tourner();
            bool result02 = roueAvd.Tourner();
            bool result03 = roueAvd.Arreter();
            bool result04 = roueAvd.Arreter();
        }
    }
}
