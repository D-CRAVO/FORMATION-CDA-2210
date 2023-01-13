using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library421
{
    public class Partie
    {
        private int nombreDeManchesSouhaitees;
        private int nombreDeManchesEffectuees;
        private ushort score;

        public Partie()
        { 

        }

        public Partie(int nombreDeManchesSouhaitees)
        {
            this.nombreDeManchesSouhaitees = nombreDeManchesSouhaitees;
            this.nombreDeManchesEffectuees = 0;
            this.score = 0;
        }
    }
}
