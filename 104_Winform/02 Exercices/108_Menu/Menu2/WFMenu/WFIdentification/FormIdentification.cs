using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLVerification;

namespace WFIdentification
{
    public partial class FormIdentification : Form
    {
        private string login;
        private string password;
        private Verification verification;

        //public string Login { get { return login; } }
        //public string Password { get { return password; } }

        public FormIdentification()
        {
            InitializeComponent();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            login = textBoxLogin.Text;  
            password = textBoxPassword.Text;
        }

        //public bool CheckLoginPassword(string _login, string _password)
        //{
        //    if (_login == _password)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        public bool CheckLoginPassword()
        {
            verification = new Verification(login, password);
            if (verification.CheckLoginPassword())
            {
                //Close();
                return true;
            }
            return false;
            
        }
    }
}
