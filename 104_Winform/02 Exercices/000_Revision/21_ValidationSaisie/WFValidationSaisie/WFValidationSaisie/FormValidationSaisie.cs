using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLControles;
using CLTransactions;

namespace WFValidationSaisie
{
    public partial class FormValidationSaisie : Form
    {
        Transaction maTransaction;

        public FormValidationSaisie()
        {
            InitializeComponent();
            textBoxNom.Text = "Duranton";
            textBoxDate.Text = "24/02/2024";
            textBoxMontant.Text = "3567.68";
            textBoxCp.Text = "13013";
        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            if (Controle.ControleNom(textBoxNom.Text))
            {
                errorProviderCp.SetError(textBoxNom, string.Empty);
            }
            else
            {
                errorProviderCp.SetError(textBoxNom, "Le champs ne peut contenir que 30 caractères alphabétiques");
            }
        }

        private void textBoxDate_TextChanged(object sender, EventArgs e)
        {

            if (Controle.ControleDate(textBoxDate.Text) && (DateTime.Parse(textBoxDate.Text) > DateTime.Now))
            {
                errorProviderDate.SetError(textBoxDate, string.Empty);
            }
            else
            {
                errorProviderDate.SetError(textBoxDate, "La date doit être au format indiqué et supérieure à la date du jour");
            }
        }

        private void textBoxMontant_TextChanged(object sender, EventArgs e)
        {
            if (Controle.ControleMontant(textBoxMontant.Text))
            {
                errorProviderMontant.SetError(textBoxMontant, string.Empty);
            }
            else
            {
                errorProviderMontant.SetError(textBoxMontant, "Le champs n'accepte que des chiffres décimaux positifs");
            }
        }

        private void textBoxCp_TextChanged(object sender, EventArgs e)
        {
            if (Controle.ControleCp(textBoxCp.Text))
            {
                errorProviderCp.SetError(textBoxCp, string.Empty);
            }
            else
            {
                errorProviderCp.SetError(textBoxCp, "Veuillez renseigner un Code Postal correcte");
            }
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if  (
                    Controle.ControleNom(textBoxNom.Text)
                    && Controle.ControleDate(textBoxDate.Text)
                    && DateTime.Parse(textBoxDate.Text) > DateTime.Now
                    && Controle.ControleMontant(textBoxMontant.Text)
                    && Controle.ControleCp(textBoxCp.Text)
                )
            {
                maTransaction = new Transaction
                    (
                        textBoxNom.Text
                        , DateOnly.Parse(textBoxDate.Text)
                        , float.Parse(textBoxMontant.Text.Replace(".", ","))
                        , textBoxCp.Text
                    );
                FormRecapTransaction formRecapTransaction = new FormRecapTransaction(maTransaction);
                ShowDialog( formRecapTransaction );
            }
            else
            {
                SystemSounds.Exclamation.Play(); 
                if (!Controle.ControleNom(textBoxNom.Text) )
                {
                    textBoxNom.Focus();
                }
                else if (!Controle.ControleDate(textBoxDate.Text) || !(DateTime.Parse(textBoxDate.Text) > DateTime.Now))
                {
                    textBoxDate.Focus();
                }
                else if (!Controle.ControleMontant(textBoxMontant.Text))
                {
                    textBoxMontant.Focus();
                }
                else if (!Controle.ControleCp(textBoxCp.Text))
                {
                    textBoxCp.Focus();
                }
            }
        }
    }
}
