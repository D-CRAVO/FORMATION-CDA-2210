using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CLControls
{
    public class Control
    {
        public static bool ControlePuce(string _numeroPuce) 
        {
            Regex maRegex = new Regex(@"^[1-9]{15}$");
            return maRegex.IsMatch(_numeroPuce);
        }
    }
}
