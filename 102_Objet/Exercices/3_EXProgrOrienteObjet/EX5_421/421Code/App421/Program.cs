
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
            manche1.PremierLancer();
            bool estGagne1 = manche1.EstGagne();
            manche1.Relance();
            bool estGagne2 = manche1.EstGagne();
            if (manche1.MesDes[0].Valeur != 4)
            {
                manche1.Relance(manche1.MesDes[0]);
            }
        }
    }
}