
using Library421;
using System.Security.Cryptography;
using System;


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

            Manche manche1 = new Manche();
            try
            {
                
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



            }
            catch (Exception e)
            {
                string result = e.Message;
            }
            
        }
    }
}