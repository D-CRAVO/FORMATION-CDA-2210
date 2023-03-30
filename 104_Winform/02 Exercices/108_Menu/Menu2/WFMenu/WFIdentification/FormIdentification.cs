using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFMenu;

namespace WFIdentification
{
    public partial class FormIdentification : Form
    {
        private string login;
        private string password;

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
            if (login == password) 
            {
                FormMenu.LiberationVolets();
            }

        }
    }
}
