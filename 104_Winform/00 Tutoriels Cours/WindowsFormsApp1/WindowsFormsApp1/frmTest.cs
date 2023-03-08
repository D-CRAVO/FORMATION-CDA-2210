using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void btnCopier_Click(object sender, EventArgs e)
        {
            // recopie de la valeur saisie de la source vers la cible
            txtCible.Text = txtCible.Text + " " + txtSource.Text;
            // efface la source : on utilise la méthode Clear
            txtSource.Clear();
            // positionne le focus : on utilise la méthode Focus
            txtSource.Focus();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
