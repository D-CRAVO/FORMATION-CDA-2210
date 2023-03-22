using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFIdentification
{
    internal class Identification
    {
        private string login;
        private string password;

        public Identification(string _login, string _password) 
        {
            login = _login;
            password = _password;
        }

        public bool checkLoginPassword()
        {
            return login == password;
        }
    }
}
