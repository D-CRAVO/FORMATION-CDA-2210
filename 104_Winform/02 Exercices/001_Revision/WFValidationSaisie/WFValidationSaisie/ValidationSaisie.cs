using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLControles;

namespace WFValidationSaisie
{
    public partial class ValidationSaisie : Form
    {
        public ValidationSaisie()
        {
            InitializeComponent();
        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            if (!Controle.Nom(textBoxNom.ToString()))
            {
                errorProviderNom.SetError(textBoxNom, "N'accepte que des caractères alphanumériques")
            }
            else
            {
                errorProviderNom.SetError(textBoxNom, string.Empty);
            }
        }
    }
}
