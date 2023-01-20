
using Library421;
using System.Security.Cryptography;
using System;
using System.Threading.Tasks.Sources;

namespace App421
{
    public class Program
    {
        static void Main(string[] args)
        {
            De de1 = new De();
            De de2 = new De();
            De de3 = new De();
            int result01 = de1.CompareTo(de2);
            

            


            try
            {
                Manche manche1 = new Manche();

                // Manche automatique
                while (manche1.AEncoreUnLance())
                {
                    bool estGagne = manche1.EstGagnee();
                    if (!estGagne)
                    {
                        manche1.RelanceAutomatique();
                    }
                    else
                    {
                        Console.WriteLine("Vous avez gagné !");
                    }
                }

                int nbManchesSouhaitees = int.Parse(Console.ReadLine());

                // Partie automatique
                Partie partie01 = new Partie(nbManchesSouhaitees);
                int score01 = 10 * nbManchesSouhaitees;
                Console.WriteLine(score01);
                do
                {
                    partie01.CreerUneNouvelleManche();
                    while (!partie01.EstCeQueLaMancheCouranteEstGagnee() && partie01.EstCeQueLaMancheCouranteAEncoreUnLance())
                    {
                        partie01.RelancerLesDesDeLaMancheCourante();
                    }
                    if (partie01.EstCeQueLaMancheCouranteEstGagnee())
                    {
                        Console.WriteLine("Vous avez gagné la manche");
                    }
                    else
                    {
                        Console.WriteLine("Vous avez perdu la manche");
                    }
                    score01 += partie01.GetScore();
                    partie01.EstCeQueLaMancheCouranteEstGagnee();
                } while (partie01.AEncoreUneMancheAJouer());
                Console.WriteLine(score01);

                // Partie manuelle
                Partie partie02 = new Partie(nbManchesSouhaitees);
                int score02 = 10 * nbManchesSouhaitees;
                do
                {
                    partie01.CreerUneNouvelleManche();
                    while (!partie01.EstCeQueLaMancheCouranteEstGagnee() && partie02.EstCeQueLaMancheCouranteAEncoreUnLance())
                    {
                        partie02.RelancerLesDesDeLaMancheCourante();
                    }
                    if (partie02.EstCeQueLaMancheCouranteEstGagnee())
                    {
                        Console.WriteLine("Vous avez gagné la manche");
                    }
                    else
                    {
                        Console.WriteLine("Vous avez perdu la manche");
                    }
                    score02 += partie02.GetScore();
                    partie02.EstCeQueLaMancheCouranteEstGagnee();
                } while (partie02.AEncoreUneMancheAJouer());
                Console.WriteLine(score02);

            }
            catch (Exception e)
            {
                string result = e.Message;
            }
            
        }
    }
}