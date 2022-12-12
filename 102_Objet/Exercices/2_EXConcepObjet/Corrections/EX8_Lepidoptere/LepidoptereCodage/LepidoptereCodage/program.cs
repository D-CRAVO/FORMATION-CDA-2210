using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LepidoptereCodage
{
    internal class program
    {
        static void Main(string[] args)
        {
            Lepidoptere lepidoptere = new Lepidoptere();
            Console.WriteLine(lepidoptere.SeDeplacer());
            lepidoptere.SeMetamorphoser();

            Console.WriteLine(lepidoptere.SeDeplacer());
            lepidoptere.SeMetamorphoser();

            Console.WriteLine(lepidoptere.SeDeplacer());
            lepidoptere.SeMetamorphoser();

            Console.WriteLine(lepidoptere.SeDeplacer());
            lepidoptere.SeMetamorphoser();

            Console.WriteLine(lepidoptere.SeDeplacer());
            lepidoptere.SeMetamorphoser();

        }
    }
}
