using System.Text.RegularExpressions;

namespace CLControles
{
    public class Controle
    {
        public static bool controleNom(string nom)
        {
            Regex maRegex = new Regex(@"^[a-zA-Z]{1,25}$");
            return maRegex.IsMatch(nom);
        }

        public static bool controleDate(string date)
        {
            Regex maRegex = new Regex(@"^[0-9]{2}/[0-9]{2}/[0-9]{4}$");
            if (DateTime.TryParse(date, out DateTime temp) && maRegex.IsMatch(date)) 
            {
                DateOnly dateCourante = DateOnly.FromDateTime(DateTime.Now);
                if (DateOnly.Parse(date) >= dateCourante)
                {
                    return true;
                }
                
            }
            return false;
        }

        public static bool controleMontant(string montant)
        {
            Regex maRegex = new Regex(@"^[0-9]{1,10}(?:(?:[.]|,)[0-9]{2})?$");
            return maRegex.IsMatch(montant);
        }

        public static bool controleCp(string codePostal)
        {
            Regex maRegex = new Regex(@"^[0-9]{5}$");
            return maRegex.IsMatch(codePostal);
        }
    }
}