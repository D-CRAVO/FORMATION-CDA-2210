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
using System.Windows.Forms.VisualStyles;
using ClassLibraryValidationSaisie2;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ValidationSaisie2
{
    public partial class FormulaireSaisie2 : Form
    {
        Controles2 monControle;

        public FormulaireSaisie2()
        {
            InitializeComponent();
            monControle = new Controles2();
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
        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (ValideNom(textBoxNom.Text))
            {
                DialogResult dialogResult = MessageBox.Show
                    (
                        $"Nom : {textBoxNom.Text}\n"
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
                if (!ValideNom(textBoxNom.Text))
                {
                    textBoxNom.Focus();
                }
            }
        }

        private void buttonEffacer_Click(object sender, EventArgs e)
        {
            textBoxNom.Clear();
        }

        //public static bool ValideNom(string _nom)
        //{
        //    Regex myRegex = new Regex(@"^[a-zA-Z]{1,25}$");
        //    return myRegex.IsMatch(_nom); // retourne true ou false selon la vérification
        //}
    }
}
