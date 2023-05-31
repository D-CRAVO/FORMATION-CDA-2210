using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using CLControles;
using CLValidationSaisie;

namespace WFValidationSaisie
{
    public partial class ValidationSaisie : Form
    {
        DateOnly date;
        public ValidationSaisie()
        {
            InitializeComponent();
        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            if (Controle.Nom(textBoxNom.Text) || textBoxNom.Text == string.Empty)
            {
                errorProviderNom.SetError(textBoxNom, string.Empty);
            }
            else
            {
                errorProviderNom.SetError(textBoxNom, "N'accepte que des caractères alphanumériques");
            }
        }

        private void textBoxDate_TextChanged(object sender, EventArgs e)
        {
            if (Controle.Date(textBoxDate.Text) || textBoxDate.Text == string.Empty)
            {
                errorProviderDate.SetError(textBoxDate, string.Empty);
            }
            else
            {
                errorProviderDate.SetError(textBoxDate, "La date n'est pas au bon format");
            }
        }

        private void textBoxMontant_TextChanged(object sender, EventArgs e)
        {
            if (Controle.Montant(textBoxMontant.Text) || textBoxMontant.Text == string.Empty)
            {
                errorProviderMontant.SetError(textBoxMontant, string.Empty);
            }
            else
            {
                errorProviderMontant.SetError(textBoxMontant, "Nombre décimal positif");
            }
        }

        private void textBoxCp_TextChanged(object sender, EventArgs e)
        {
            if (Controle.Cp(textBoxCp.Text) || textBoxCp.Text == string.Empty)
            {
                errorProviderCp.SetError(textBoxCp, string.Empty);
            }
            else
            {
                errorProviderCp.SetError(textBoxCp, "5 caractères numériques");
            }
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (
                Controle.Nom(textBoxNom.Text)
                && Controle.Date(textBoxDate.Text)
                && Controle.Montant(textBoxMontant.Text)
                && Controle.Cp(textBoxCp.Text)
                )
            {
                CLValidationSaisie.Transaction maTransaction = new CLValidationSaisie.Transaction
                    (
                    textBoxNom.Text,
                    DateOnly.Parse(textBoxDate.Text),
                    float.Parse(textBoxMontant.Text),
                    textBoxCp.Text
                    );
                Validation maValidation = new Validation(maTransaction);
                maValidation.ShowDialog();
            }
        }

        private void ValidationSaisie_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResultYesNo = MessageBox.Show("Voulez-vous quitter ?", "FIN", MessageBoxButtons.YesNo);
            if (dialogResultYesNo == DialogResult.Yes) 
            { 
                e.Cancel = true;
            }
        }


    }
}
