using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIdentification
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

        private bool checkLoginPassword()
        {
            return login == password;
        }

        public void enableMenuSrip()
        {
            if (checkLoginPassword())
            {
                FormMenu.Phase1.Enabled = true;
                phase2.Enabled = true;
                phase3.Enabled = true;
                fenetres.Enabled = true;
            }
        }
    }
}
