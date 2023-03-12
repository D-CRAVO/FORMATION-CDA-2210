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

        public static bool ControleValeurIndex(string _str)
        {
            Regex maRegex = new Regex(@"^[0-9]{1,50}");
            return maRegex.IsMatch(_str);
        }
    }
}
 