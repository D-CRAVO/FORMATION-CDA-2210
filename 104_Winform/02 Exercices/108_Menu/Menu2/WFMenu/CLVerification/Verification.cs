using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CLVerification
{
    public class Verification
    {
        private string login;
        private string password;
        
        public Verification(string _login, string _password) 
        { 
            login = _login;
            password = _password;
        }

        public bool CheckLoginPassword()
        {
            if (login == password)
            {
                return true;
            }
            return false;
        }
    }
}
