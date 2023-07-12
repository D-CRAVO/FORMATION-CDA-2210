using Exo_Calculs;

namespace Calcul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exo_Calculs.Expression ex1 = new Addition(new Nombre(3), new Nombre(2));
            double resultat1 = ex1.Evalue();
            Console.WriteLine("resultat 1 = "+resultat1);

            Exo_Calculs.Expression ex2 = new Addition(new Nombre(2), new Addition(new Nombre(3), new Nombre(89)));
            double resultat2 = ex2.Evalue();
            Console.WriteLine("resultat 2 = " + resultat2);


        }
    }
}