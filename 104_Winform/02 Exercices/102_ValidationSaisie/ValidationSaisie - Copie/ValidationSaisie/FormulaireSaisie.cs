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
using System.Windows.Forms;

namespace ValidationSaisie
{
    public partial class FormulaireSaisie : Form
    {
        public string nom;

        public FormulaireSaisie()
        {
            InitializeComponent();
        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            ValideNom(textBoxNom.Text);
            if (!ValideNom(textBoxNom.Text))
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
            if (!ValideDate(textBoxDate.Text))
            {
                errorProviderDate.SetError(textBoxDate, "Date invalide");
            }
            else if (ValideDate(textBoxDate.Text))
            {
                DateTime.TryParse(textBoxDate.Text, out DateTime date);
                errorProviderDate.SetError(textBoxDate, "");
            }
           
        }

        private void textBoxMontant_TextChanged(object sender, EventArgs e)
        {
            if (!ValideMontant(textBoxMontant.Text))
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
            if (!ValideCP(textBoxCP.Text))
            {
                errorProviderCP.SetError(textBoxCP, "Code Postal invalide");
            }
            else
            {
                errorProviderCP.SetError(textBoxCP, "");
            }
        }

        private static bool ValideNom(string _nom)
        {
            Regex myRegex = new Regex(@"^[a-zA-Z]{1,25}$");
            return myRegex.IsMatch(_nom); // retourne true ou false selon la vérification
        }

        private static bool ValideDate(string _date)
        {
            Regex myRegex = new Regex(@"^[0-9]{2}/[0-9]{2}/[0-9]{4}");
            if (DateTime.TryParse(_date, out DateTime temp) && myRegex.IsMatch(_date))
            {
                DateTime.Parse(_date);
                return true;
            }
            return false;
        }

        private static bool ValideMontant(string _montant)
        {
            Regex myRegex = new Regex(@"^[0-9]{0,25}.[0-9]{0,2}$");
            return myRegex.IsMatch(_montant);
        }

        private static bool ValideCP(string _cp)
        {
            Regex myRegex = new Regex(@"^[0-9]{5,5}$");
            return myRegex.IsMatch(_cp);
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (ValideNom(textBoxNom.Text)
                && ValideDate(textBoxDate.Text)
                && ValideMontant(textBoxMontant.Text)
                && ValideCP(textBoxCP.Text))
            {
                DialogResult dialogResult = MessageBox.Show
                    (
                        $"Nom : {textBoxNom.Text}\n" +
                        $"Date : {textBoxDate.Text}\n" +
                        $"Montant : {textBoxMontant.Text}\n" +
                        $"Code Postal : {textBoxCP.Text}"
                        , "Validation effectuée"
                    );
                if (dialogResult == DialogResult.OK)
                {
                    DialogResult dialogResultYesNo = MessageBox.Show("Fin de l'application", "FIN", MessageBoxButtons.YesNo);
                    if (dialogResultYesNo == DialogResult.Yes)
                    {
                        Close();
                    }
                }
            }
            else
            {
                SystemSounds.Exclamation.Play();
                if(!ValideNom(textBoxNom.Text))
                {
                    textBoxNom.Focus();
                }
                else if (!ValideDate(textBoxDate.Text))
                {
                    textBoxDate.Focus();
                }
                else if (!ValideMontant(textBoxMontant.Text))
                {
                    textBoxMontant.Focus();
                }
                else if (!ValideCP(textBoxCP.Text))
                {
                    textBoxCP.Focus();
                }
            }
        }

        //private void textBoxFocus(object sender, EventArgs e)
        //{
        //    sender = (TextBox)sender;
        //    sender.Focus();
        //}


        private void buttonEffacer_Click(object sender, EventArgs e)
        {
            textBoxNom.Clear();
            textBoxDate.Clear();
            textBoxMontant.Clear(); 
            textBoxCP.Clear();  
        }
    }
}
