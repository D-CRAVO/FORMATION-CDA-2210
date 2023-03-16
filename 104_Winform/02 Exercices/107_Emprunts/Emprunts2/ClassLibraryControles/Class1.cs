using System.Text.RegularExpressions;

namespace ClassLibraryControles
{
    public class Class1
    {
        public static bool controleCapitalEmprunte(string _montant)
        {
            Regex maRegex = new Regex(@"^[0-9]{1,11}?$");
            return maRegex.IsMatch(_montant);
        }
    }
}