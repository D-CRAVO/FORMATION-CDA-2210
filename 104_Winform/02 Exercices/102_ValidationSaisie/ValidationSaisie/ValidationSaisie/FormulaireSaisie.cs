using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            if (NomValide())
            {
                nom = textBoxNom.Text;
            }
        }

        private bool NomValide()
        {
            if (textBoxNom.Text.ToString().Length <= 30)
            {
                return true;
            }
            return false;
        }
    }
}
