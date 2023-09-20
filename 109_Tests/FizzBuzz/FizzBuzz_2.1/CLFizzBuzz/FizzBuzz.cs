using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLFizzBuzz
{
    public class FizzBuzz
    {
        private const int PremiereValeur = 3;
        private const int DeuxiemeValeur = 5;
        private const string PremierMessage = "Fizz";
        private const string DeuxiemeMessage = "Buzz";

        private string resultat;
        private Calcul calcul;

        public FizzBuzz()
        {
            calcul = new Calcul();
        }
        
        public string FizzBuzzPourUnNombre(int nombre)
        {
            if (calcul.DivisibleParPremiereValeur(nombre, PremiereValeur) && calcul.DivisibleParDeuxiemeValeur(nombre, DeuxiemeValeur))
                return PremierMessage + DeuxiemeMessage;
            else if (calcul.DivisibleParPremiereValeur(nombre, PremiereValeur))
                return PremierMessage;
            else if (calcul.DivisibleParDeuxiemeValeur(nombre, DeuxiemeValeur))
                return DeuxiemeMessage;
            return nombre.ToString();
        }

        public string FizzBuzzPourUneSerieDeNombres(int debut, int fin)
        {
            for (int i = debut; i <= fin; i++) 
            {
                resultat += FizzBuzzPourUnNombre(i) + Environment.NewLine;
            }
            return resultat;
        }
    }
}
