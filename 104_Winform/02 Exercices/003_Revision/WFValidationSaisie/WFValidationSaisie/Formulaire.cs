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
using CLTransactions;
using CLControles;

namespace WFValidationSaisie
{
    public partial class Formulaire : Form
    {
        private CLTransactions.Transaction maTransaction;
        public Formulaire()
        {
            InitializeComponent();
        }

        public Formulaire(CLTransactions.Transaction transaction)
        {
            InitializeComponent();
            Affichage(transaction);
        }

        private void Affichage(CLTransactions.Transaction transaction)
        {
            if (transaction != null)
            {
                textBoxNom.Text = transaction.Nom;
                textBoxDate.Text = transaction.Date.ToString();
                textBoxMontant.Text = transaction.Montant.ToString();
                textBoxCp.Text = transaction.CodePostal.ToString();
            }
        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            if (Controle.controleNom(textBoxNom.Text) || textBoxNom.Text.Length == 0)
            {
                errorProviderNom.SetError(textBoxNom, string.Empty);
            }
            else
            {
                errorProviderNom.SetError(textBoxNom, "Nom invalide !");
            }
        }

        private void textBoxDate_TextChanged(object sender, EventArgs e)
        {
            if (Controle.controleDate(textBoxDate.Text) || textBoxDate.Text.Length == 0)
            {
                errorProviderDate.SetError(textBoxDate, string.Empty);
            }
            else
            {
                errorProviderDate.SetError(textBoxDate, "Date invalide !");
            }
        }

        private void textBoxMontant_TextChanged(object sender, EventArgs e)
        {
            if (Controle.controleMontant(textBoxMontant.Text) || textBoxMontant.Text.Length == 0)
            {
                errorProviderMontant.SetError(textBoxMontant, string.Empty);
            }
            else
            {
                errorProviderMontant.SetError(textBoxMontant, "Montant invalide !");
            }
        }

        private void textBoxCp_TextChanged(object sender, EventArgs e)
        {
            if (Controle.controleCp(textBoxCp.Text) || textBoxCp.Text.Length == 0)
            {
                errorProviderCp.SetError(textBoxCp, string.Empty);
            }
            else
            {
                errorProviderCp.SetError(textBoxCp, "Code Postal invalide !");
            }
        }

        private void buttonEffacer_Click(object sender, EventArgs e)
        {
            textBoxNom.Clear();
            textBoxDate.Clear();
            textBoxMontant.Clear();
            textBoxCp.Clear();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (
                Controle.controleNom(textBoxNom.Text)
                && Controle.controleDate(textBoxDate.Text)
                && Controle.controleMontant(textBoxMontant.Text)
                && Controle.controleCp(textBoxCp.Text)
                )
            {
                maTransaction = new CLTransactions.Transaction(
                        textBoxNom.Text,
                        DateOnly.Parse(textBoxDate.Text),
                        float.Parse(textBoxMontant.Text),
                        textBoxCp.Text
                    );

                Recapitulatif monRecapitulatif = new Recapitulatif(maTransaction);
                monRecapitulatif.ShowDialog();
            }
        }

        private void Formulaire_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Fin de l'application", "FIN", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
