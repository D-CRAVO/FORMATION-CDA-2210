using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoitureCodage
{
    internal class program
    {
        static void Main(string[] args)
        {
            Roue[] roues = new Roue[] { new Roue(), new Roue(), new Roue(), new Roue(), new Roue(), new Roue() };
            Moteur moteur = new Moteur();
            string marque = "Citroen";
            //Utilisation du constructeur V1 : public Voiture(string _marque, Moteur _sonMoteur, Roue[] _ses4roues)
            Voiture voiture = new Voiture(marque, moteur, roues);
            Roue roueA = new Roue();
            Roue roueB = new Roue();
            Roue roueC = new Roue();
            Roue roueD = new Roue();
            Moteur moteurB = new Moteur();
            //Utilisation du constructeur V2 : public Voiture(string _marque, Moteur _sonMoteur,
            //Roue _roue1, Roue _roue2, Roue _roue3, Roue _roue4)
            Voiture voitureB = new Voiture(marque, moteur, roueA, roueB, roueC, roueD);
            //Utilisation du constructeur V3 : public Voiture(string _marque, bool _enMarche,
            // bool _tourne, string _dimensionPneu)
            Voiture voitureC = new Voiture(marque, false, false, "240/15/10V");
        }
    }
}

