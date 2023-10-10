using exercice_3_7_barnabe;
using System;
using System.Security.Cryptography.X509Certificates;

namespace ex37_barnabe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCICE 3.7 BARNABE FAIT SES COURSES

            // VARIABLES

            float argent = 0;
            int magasins_visites = 0;

            CalculNbMagasins calculNbMagasins = new CalculNbMagasins();

            // DEBUT PROGRAMME

            Console.Write("Veuillez entrer la somme de départ : ");
            argent = float.Parse(Console.ReadLine());
            magasins_visites = calculNbMagasins.NbMagasinRealisePArBarnabe(argent);
            // On affiche magasins_visites + 1 pour tenir compte du
            // dernier magasin où il dépense le solde.
            Console.WriteLine("Barbabé a visité " + (magasins_visites + 1) + " magasins.");

            // FIN PROGRAMME

            // DEBUT FONCTION

            // Je vous demande d'établir les tests unitaires pour vérifier que ma fonction
            // int NbMagasinRealisePArBarnabe(decimal sommeDansLePorteMonnaieDeBarnabe)
            
            
        }

        // FIN FONCTION
    }
    
}
