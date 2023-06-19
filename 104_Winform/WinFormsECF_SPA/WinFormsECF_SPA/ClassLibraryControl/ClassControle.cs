using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace ClassLibraryControl
{
    public class Controls
    {
        public static bool VerifIdentifiantPuce(string numberOK)
        {
            return Regex.Match(numberOK, @"^25026[0-9]{10}$").Success;
        }
        public static bool CheckName(string value)
        {
            return Regex.Match(value, "^[a-zA-Z- ]{1,25}$").Success;           
        }      
    }

}