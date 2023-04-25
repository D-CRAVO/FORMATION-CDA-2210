using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CLEmployees
{
    public class Control
    {
        public static bool Name(string _name)
        {
            Regex myRegex = new Regex(@"^[a-zA-Z]{1,50}$");
            return myRegex.IsMatch(_name);
        }

        public static bool Salary(string _salary) 
        {
            Regex myRegex = new Regex(@"^(([0-9]{1,25})(?:(?:[.])[0-9]{0,2})?)$");
            return myRegex.IsMatch(_salary);
        }

        //public static bool HireDate(string _hireDate)
        //{
        //    if (!DateOnly.TryParseExact(_hireDate, "dd/MM/yyyy", out DateOnly temp))
        //    {
        //        return false;
        //    }
        //    return true;
        //}

        public static bool HireDate(string _hireDate)
        {
            if (DateTime.TryParse(_hireDate, out DateTime result))
            {
                return true;
            }
            return false;
        }

        public static bool ManagerId(string _managerId)
        {
            Regex myRegex = new Regex(@"^[0-9]{0,10}$");
            return myRegex.IsMatch(_managerId);
        }
    }
}
