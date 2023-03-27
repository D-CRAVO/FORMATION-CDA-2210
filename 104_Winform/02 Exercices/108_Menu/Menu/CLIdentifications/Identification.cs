using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIdentifications
{
    public class Identification
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
                //Phase1.Enabled = true;
                //Phase2.Enabled = true;
                //Phase3.Enabled = true;
                //Fenetres.Enabled = true;
            }
            else
            {

            }
        }
    }
}
