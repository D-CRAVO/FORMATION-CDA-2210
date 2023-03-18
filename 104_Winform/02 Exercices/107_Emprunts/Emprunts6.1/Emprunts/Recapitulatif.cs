using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryValidation;

namespace Emprunts
{
    public partial class Recapitulatif : Form
    {
        public Recapitulatif()
        {
            InitializeComponent();
        }

        public Recapitulatif(Validation validation)
        {
            InitializeComponent();
            textBoxNom.Text = validation.NomClient.ToString();
            textBoxCapitalEmprunte.Text = validation.CapitalEmprunte.ToString();
            textBoxTauxAnnuel.Text = validation.TauxAnnuel.ToString();
            textBoxNombreRemboursements.Text = validation.NombreRemboursements.ToString();
            textBoxMontantRemboursements.Text = validation.MontantRemboursements.ToString();
        }

        private void buttonValidation_Click(object sender, EventArgs e)
        {
            Traitement monTraitement = new Traitement();
            monTraitement.ShowDialog();
            Close();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
