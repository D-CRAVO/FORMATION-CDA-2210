using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMessage
{
    public partial class frmMessage : Form
    {
        public frmMessage()
        {
            InitializeComponent();
        }

        private void frmMessage_Load(object sender, EventArgs e)
        {
            TextBox newt = new TextBox();
            newt.Name = "txtPrenom";
            newt.Location = new Point(txtNom.Location.X,
            txtNom.Location.Y + 50);
            this.Controls.Add(newt);
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string personne = "";
            // parcourir tous les contrôles de la feuille
            foreach (Control ctrl in this.Controls)
            {
                if ((ctrl.Name == "txtNom") || (ctrl.Name == "txtPrenom"))
                {
                    personne += ctrl.Text + " ";
                }
            }
            MessageBox.Show("saisie : " + personne, "",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
