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
            Roue roueArd = new Roue(false);
            Roue roueArg = new Roue(false);
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
            bool result05 = moteurClassique.Allumer();
            bool result06 = moteurClassique.Allumer();
            bool result07 = moteurClassique.Eteindre();
            bool result08 = moteurClassique.Eteindre();
            bool result09 = moteurClassique.Allumer();
            bool result10 = moteurClassique.EntrainerRoue(roueAvg, roueAvd);
            bool result11 = moteurClassique.EntrainerRoue(roueAvg, roueAvg);

            Voiture voitureClassique = new Voiture("Seat", false, false);
            Voiture voitureClassique2 = new Voiture("Seat", moteurClassique, roueAvg, roueAvd, roueArg, roueArd);
            Voiture voitureDefaut = new Voiture();
            Voiture voitureCopie = new Voiture(voitureDefaut);
            bool result12 = voitureClassique.Demarrer();//true
            bool result13 = voitureClassique.Demarrer();//false
            bool result14 = voitureClassique.Avancer();//true
            bool result15 = voitureClassique.Avancer();//false
            bool result16 = voitureClassique.CouperContact();//false
            bool result17 = voitureClassique.Freiner();//true
            bool result18 = voitureClassique.Freiner();//false
            bool result19 = voitureClassique.CouperContact();//true
            bool result20 = voitureClassique.CouperContact();//false
        }
    }
}
