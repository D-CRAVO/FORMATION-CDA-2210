using System.Text.RegularExpressions;

namespace CLControles
{
    public class Controle
    {
        public static bool Nom(string _nom)
        {
            Regex maRegex = new Regex(@"^[a-zA-Z]{0,30}$");
            return maRegex.IsMatch(_nom);
        }

        public static bool Date(string _date)
        {
            Regex maRegex = new Regex(@"^[0-9]{2}/[0-9]{2}/[0-9]{4}$");
            DateOnly dateCourante =DateOnly.FromDateTime(DateTime.Now);
            if (maRegex.IsMatch(_date) && DateOnly.Parse(_date)>dateCourante)
            {
                return true;
            }
            return false;
        }

        public static bool Montant(string _montant)
        {
            Regex maRegex = new Regex(@"^[0-9]{0,10}([.][0-9]{1,2})?$");
            return maRegex.IsMatch(_montant);
        }

        public static bool Cp(string _cp)
        {
            Regex maRegex = new Regex(@"^[0-9]{5}$");
            return maRegex.IsMatch(_cp);
        }
    }
}