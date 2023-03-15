using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibraryControles
{
    public class Controles
    {
        public static bool ControleDoublons(string _str, List<string> _strList)
        {

            int i = 0;
            while (i < _strList.Count)
            {
                if (_strList[i] == _str)
                {
                    return false;
                }
                else
                {
                    i++;
                }
            };
            return true;
        }

        public static bool ControleValeurIndex(string _index)
        {
            Regex maRegex = new Regex(@"^[0-9]{1,50}");
            return maRegex.IsMatch(_index);
        }

        public static bool ControleTexteSaisi(string _texte)
        {
            if (!string.IsNullOrEmpty(_texte))
            {
                //Regex maRegex = new Regex(@"^[^\s]([a-zA-Z]{0,50})(?:(?:([-]){0,1}[a-zA-Z]{0,50}))$");
                Regex maRegex = new Regex(@"^[a-zA-Z]{1,50}(?:-[a-zA-Z]+)?$");
                maRegex.IsMatch(_texte);
                return true;
            }
            return false;
        }

    }
}
 