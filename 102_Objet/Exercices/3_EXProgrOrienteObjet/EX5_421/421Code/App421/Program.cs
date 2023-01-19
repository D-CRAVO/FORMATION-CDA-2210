
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

                int i = 0;
                while (i < manche1.NbLancesEffectues)
                {
                    bool estGagne = manche1.EstGagnee();
                    if (!estGagne)
                    {
                        manche1.Relance();
                    }
                    else
                    {
                        Console.WriteLine("Vous avez gagné !");
                    }
                    i++;
                }

                Console.WriteLine("test");
                int nbManchesSouhaitees = int.Parse(Console.ReadLine());
                Console.WriteLine("test");

                Partie partie01 = new Partie(nbManchesSouhaitees);
                int score = 10 * nbManchesSouhaitees;
                Console.WriteLine(score);
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
                    score += partie01.GetScore();
                    partie01.EstCeQueLaMancheCouranteEstGagnee();
                } while (partie01.AEncoreUneMancheAJouer());
                Console.WriteLine(score);


            }
            catch (Exception e)
            {
                string result = e.Message;
            }
            
        }
    }
}