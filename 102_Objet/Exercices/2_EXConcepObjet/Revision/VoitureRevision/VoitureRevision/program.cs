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
            Roue roueAvg = new Roue(false);
            Roue roueAvdDefaut = new Roue();
            Roue roueAvgDefaut = new Roue();
            Roue RoueAvdCopie = new Roue(roueAvdDefaut);
            Roue roueAvgCopie = new Roue(roueAvgDefaut);
            bool result01 = roueAvd.Tourner();
            bool result02 = roueAvd.Tourner();
            bool result03 = roueAvd.Arreter();
            bool result04 = roueAvd.Arreter();

            Moteur moteurClassique = new Moteur(false);
            Moteur moteurDefaut = new Moteur();
            Moteur moteurCopie = new Moteur(moteurDefaut);
            bool result05 = moteurClassique.Demarrer();
            bool result06 = moteurClassique.Demarrer();
            bool result07 = moteurClassique.Eteindre();
            bool result08 = moteurClassique.Eteindre();
            bool result09 = moteurClassique.Demarrer();
            bool result10 = moteurClassique.EntrainerRoue(roueAvg, roueAvd);
            bool result11 = moteurClassique.EntrainerRoue(roueAvg, roueAvg);

            Voiture voitureClassique = new Voiture("Seat", false, false);
        }
    }
}
