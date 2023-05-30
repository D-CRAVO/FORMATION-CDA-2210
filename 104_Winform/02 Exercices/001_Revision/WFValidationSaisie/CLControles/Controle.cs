using System.Text.RegularExpressions;

namespace CLControles
{
    public class Controle
    {
        public static bool Nom(string _nom)
        {
            Regex maRegex = new Regex(@"^[a-zA-Z]{0-30}$");
            return maRegex.IsMatch(_nom);
        }
    }
}