using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryFraction;

namespace AppFraction
{
    internal class program
    {
        static void Main(string[] args)
        {
            try
            {
                // Fraction fraction = new Fraction(2, 0);
                Fraction fraction01 = new Fraction(-12, -7);
                Fraction fraction02 = new Fraction(9);
                Fraction fraction03 = new Fraction();
                Fraction fraction04 = new Fraction(fraction01);

                // Console.WriteLine(fraction01);
                // Console.WriteLine(fraction02);
                // Console.WriteLine(fraction03);

                Fraction fraction05 = new Fraction(4, 7);

                Fraction fraction06 = new Fraction(11, 7);
                Fraction fraction07 = new Fraction(5, 4);

                bool estSuperieur = fraction06.SuperieurA(fraction07); // true

                Fraction fraction08 = new Fraction(11, 7);
                Fraction fraction09 = new Fraction(22, 14);

                bool estEgal = fraction08.EgalA(fraction09); // true

                Fraction fraction10 = new Fraction(120, -150);

                // Console.WriteLine(fraction08.Reduire()); // Affiche -4/5

                Fraction fraction11 = new Fraction(2, 4);
                Fraction fraction12 = new Fraction(-2, 4);

                Fraction estAdditionne1 = fraction11.Plus(fraction11); // 1
                Fraction estAdditionne2 = fraction11.Plus(fraction12); // 0
                Fraction estSoustrait = fraction11.Moins(fraction11); // 0

                Fraction estMultiplie = fraction11.Multiplie(fraction12); // -1/4
                Fraction estDivise = fraction11.Divise(fraction12); // -1

                Fraction estAdditionne3 = fraction11 + fraction12; // 0
                Fraction estSoustrait3 = fraction11 - fraction12; // 5/2
                Fraction estMultiplie3 = fraction11 * fraction12; // -1
                Fraction estDivise3 = fraction11 / fraction12; // -1/4

                Fraction fraction13 = new Fraction(0, 1);
            }
            catch (Exception e)
            {
                string result = e.Message;
            }
        }
    }
}
