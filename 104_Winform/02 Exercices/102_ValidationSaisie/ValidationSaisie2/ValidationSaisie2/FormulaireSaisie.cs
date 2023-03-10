using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ClassLibraryValidationSaisie2;
using ClassLibraryTransaction;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ValidationSaisie2
{
    public partial class FormulaireSaisie2 : Form
    {
        private ClassLibraryTransaction.Transaction maTransaction;
        private FormRecapTransaction maRecapTransaction;

        public FormulaireSaisie2()
        {
            InitializeComponent();
        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            Controles.ValideNom(textBoxNom.Text);
            if (!Controles.ValideNom(textBoxNom.Text))
            {
                errorProviderNom.SetError(textBoxNom, "Nom invalide");
            }
            else
            {
                errorProviderNom.SetError(textBoxNom, "");
            }
        }

        private void textBoxDate_TextChanged(object sender, EventArgs e)
        {
            if (!Controles.ValideDate(textBoxDate.Text))
            {
                errorProviderDate.SetError(textBoxDate, "Date invalide");
            }
            else if (Controles.ValideDate(textBoxDate.Text))
            {

                errorProviderDate.SetError(textBoxDate, "");
            }

        }

        private void textBoxMontant_TextChanged(object sender, EventArgs e)
        {
            if (!Controles.ValideMontant(textBoxMontant.Text))
            {
                errorProviderMontant.SetError(textBoxMontant, "Montant invalide");
            }
            else
            {
                errorProviderMontant.SetError(textBoxMontant, "");
            }
        }

        private void textBoxCP_TextChanged(object sender, EventArgs e)
        {
            if (!Controles.ValideCP(textBoxCP.Text))
            {
                errorProviderCP.SetError(textBoxCP, "Code Postal invalide");
            }
            else
            {
                errorProviderCP.SetError(textBoxCP, "");
            }
        }

        

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (Controles.ValideNom(textBoxNom.Text)
                && Controles.ValideDate(textBoxDate.Text)
                && Controles.ValideMontant(textBoxMontant.Text)
                && Controles.ValideCP(textBoxCP.Text))
            {
                //DialogResult dialogResult = MessageBox.Show
                //    (
                //        $"Nom : {textBoxNom.Text}\n" +
                //        $"Date : {textBoxDate.Text}\n" +
                //        $"Montant : {textBoxMontant.Text}\n" +
                //        $"Code Postal : {textBoxCP.Text}"
                //        , "Validation effectuée"
                //    );

                
                maTransaction = new ClassLibraryTransaction.Transaction
                (
                    textBoxNom.Text,
                    DateOnly.Parse(textBoxDate.Text),
                    float.Parse(textBoxMontant.Text),
                    int.Parse(textBoxCP.Text)
                );

                maRecapTransaction = new FormRecapTransaction(maTransaction);
                maRecapTransaction.Enregistrement(maTransaction);
                
            }
            else
            {
                SystemSounds.Exclamation.Play();
                if (!Controles.ValideNom(textBoxNom.Text))
                {
                    textBoxNom.Focus();
                }
                else if (!Controles.ValideDate(textBoxDate.Text))
                {
                    textBoxDate.Focus();
                }
                else if (!Controles.ValideMontant(textBoxMontant.Text))
                {
                    textBoxMontant.Focus();
                }
                else if (!Controles.ValideCP(textBoxCP.Text))
                {
                    textBoxCP.Focus();
                }
            }
        }

        private void buttonEffacer_Click(object sender, EventArgs e)
        {
            textBoxNom.Clear();
            textBoxDate.Clear();
            textBoxMontant.Clear();
            textBoxCP.Clear();
        }

        private void FormulaireSaisie2_FormClosing(object sender, FormClosingEventArgs e)
        {

                DialogResult dialogResultYesNo = MessageBox.Show("Fin de l'application", "FIN", MessageBoxButtons.YesNo);
                if (dialogResultYesNo == DialogResult.No)
                {
                    e.Cancel = true;
                }               
            
        }
    }
}
