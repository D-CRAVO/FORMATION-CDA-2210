using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFDelegate
{
    public partial class FormPewPew : Form
    {

        public event EventHandler NamePewPewValidated;
        public string NomPewPew { get => this.textBoxNom.Text; }

        public FormPewPew()
        {
            InitializeComponent();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
