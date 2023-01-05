using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCodage
{
    internal class program
    {
        static void Main(string[] args)
        {
            Fraction fraction01 = new Fraction(12, 7);
            Fraction fraction02 = new Fraction(9);
            Fraction fraction03 = new Fraction();
            Fraction fraction04 = new Fraction(fraction01);

            // Console.WriteLine(fraction01);
            // Console.WriteLine(fraction02);
            // Console.WriteLine(fraction03);

            Fraction fraction05 = new Fraction(4, 7);

            Fraction result01 = fraction05.Oppose(); // -4/7
            Fraction result02 = fraction05.Inverse(); // 7/4

            Fraction fraction06 = new Fraction(11, 7);
            Fraction fraction07 = new Fraction(5, 4);

            bool estSuperieur = fraction06.SuperieurA(fraction07); // true

            Fraction fraction08 = new Fraction(120, -150);

            // Console.WriteLine(fraction08.Reduire()); // Affiche -4/5
        }
    }
}
