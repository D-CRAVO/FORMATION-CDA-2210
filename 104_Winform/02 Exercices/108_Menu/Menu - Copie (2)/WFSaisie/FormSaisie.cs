using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheckBoxBoutonsRadio;

namespace WFSaisie
{
    public partial class FormSaisie : Form
    {
        public FormSaisie()
        {
            InitializeComponent();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            string texte = textBoxTexte.Text;
            FormCheckBoxRadioButton formArrivee = new FormCheckBoxRadioButton(texte);
            formArrivee.Show();
        }
    }
}
