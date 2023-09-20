using CLFizzBuzz;

namespace FizzBuzz_2
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            Console.WriteLine(fizzBuzz.FizzBuzzPourUneSerieDeNombres(1, 100));
        }
    }
}