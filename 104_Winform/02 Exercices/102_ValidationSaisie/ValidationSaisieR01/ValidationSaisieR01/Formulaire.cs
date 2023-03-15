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
using ClassLibraryControles;
using ClassLibraryTransactions;

namespace ValidationSaisieR01
{
    public partial class Formulaire : Form
    {
        Transactions maTransaction;
        RecapTransaction maRecapTransaction;

        public Formulaire()
        {
            InitializeComponent();
        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            if (!Controles.ControleNom(textBoxNom.Text))
            {
                errorProviderNom.SetError(textBoxNom, "Le nom ne doit contenir que des lettres");
                MessageBox.Show(textBoxNom.Text, "essai");
            }
            else
            {
                errorProviderNom.SetError(textBoxNom, "");
            }
        }

        private void textBoxDate_TextChanged(object sender, EventArgs e)
        {
            if (!Controles.ControleDate(textBoxDate.Text))
            {
                errorProviderDate.SetError(textBoxDate, "Date invalide");
            }
            else
            {
                errorProviderDate.SetError(textBoxDate, "");
            }
        }

        private void textBoxMontant_TextChanged(object sender, EventArgs e)
        {
            if (!Controles.ControleMontant(textBoxMontant.Text))
            {
                errorProviderMontant.SetError(textBoxMontant, "Le montant ne doit contenir que des chiffres et deux chiffres après la virgule");
            }
            else
            {
                errorProviderMontant.SetError(textBoxMontant, "");
            }
        }

        private void textBoxCP_TextChanged(object sender, EventArgs e)
        {
            if (!Controles.ControleCP(textBoxCP.Text))
            {
                errorProviderCP.SetError(textBoxCP, "Le code postal doit contenir 5 chiffres");
            }
            else
            {
                errorProviderCP.SetError(textBoxCP, "");
            }
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (
                Controles.ControleNom(textBoxNom.Text)
                && Controles.ControleDate(textBoxDate.Text)
                && Controles.ControleMontant(textBoxMontant.Text)
                && Controles.ControleCP(textBoxCP.Text)
               )
            {
                maTransaction = new Transactions
                (
                    textBoxNom.Text,
                    DateOnly.Parse(textBoxDate.Text),
                    float.Parse(textBoxMontant.Text.Replace(".", ",")),
                    int.Parse(textBoxCP.Text)
                );
                maRecapTransaction = new RecapTransaction(maTransaction);

                
            }
        }

        

        private void buttonEffacer_Click(object sender, EventArgs e)
        {
            textBoxNom.Clear();
            textBoxDate.Clear();
            textBoxMontant.Clear();
            textBoxCP.Clear();
        }

        private void Formulaire_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResultYesNo = MessageBox.Show("Fin de l'application", "FIN", MessageBoxButtons.YesNo);
            if (dialogResultYesNo == DialogResult.No)
                e.Cancel = true;
        }
    }
}
