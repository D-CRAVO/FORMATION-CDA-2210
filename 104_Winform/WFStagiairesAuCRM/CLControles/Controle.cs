using System.Text.RegularExpressions;

namespace CLControles
{
    public class Controle
    {
        public static bool ControleNom(string _nom)
        {
            Regex maRegex = new Regex(@"^(([a-zA-Z])(?:-[a-zA-Z])?){0,25}$");
            return maRegex.IsMatch(_nom);
        }

        public static bool ControleDate(string _date)
        {
            
            if (DateTime.TryParse(_date, out DateTime temp) && ControleFormatDate(_date))
            {
                DateOnly.Parse(_date);
                return true;
            }
            return false;
        }

        private static bool ControleFormatDate(string _date)
        {
            Regex myRegex = new Regex(@"^[0-9]{2}/[0-9]{2}/[0-9]{4}$");
            return myRegex.IsMatch(_date);
        }

    }
}