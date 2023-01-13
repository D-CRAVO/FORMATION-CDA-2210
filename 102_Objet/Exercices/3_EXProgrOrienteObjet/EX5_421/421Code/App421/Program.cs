
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

            TriDe1(de1, de2, de3);
            De[] mesDes = new De[]{ de1, de2, de3 };
            Manche.TrierDesManche(mesDes);
            Manche maManche = new Library421.Manche();
        }
    }
}