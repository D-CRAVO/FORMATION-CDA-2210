using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voiture
{
    internal class program
    {
        static void Main(string[] args)
        {
            Voiture cordoba = new Voiture();
            if (!cordoba.moteur.moteurTourne)
            {
                bool resultat00 = cordoba.moteur.Demarrer();
                if (resultat00)
                {
                    bool resultat01 = cordoba.Accelerer();
                }
                bool resultat02 = cordoba.moteur.Arreter();
            }

            //Voiture(marque,modele,vitesseKmh,vMaxKmh,carburant,cylindree,puissance,moteurTourne,poidsEquilibrage,largeur,hauteur,pression,matiere,couleur,rayonEnPouces)
            Voiture leon = new Voiture("Seat", "Leon", 200, 200, "diesel", 2.0, 184, false, 0, 205, 55, 1.9f, "aluminium", "gris", 17);

            if (!leon.moteur.moteurTourne)
            {
                bool resultat03 = leon.moteur.Demarrer();
                if (resultat03)
                {
                    bool resultat04 = leon.Ralentir();
                }
            }
            
        }
    }
}
