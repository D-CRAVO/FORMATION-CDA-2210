
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
                //bool estGagne0 = manche1.EstGagne();
                manche1.PremierLance();

                bool estGagne1 = manche1.EstGagne();
                if (!manche1.EstGagne())
                {
                    manche1.Relance();
                }

                bool estGagne2 = manche1.EstGagne();
                if (!manche1.EstGagne())
                {
                    manche1.Relance();
                }
                bool estGagne3 = manche1.EstGagne();
            }
            catch (Exception e)
            {
                string result = e.Message;
            }
            
        }
    }
}