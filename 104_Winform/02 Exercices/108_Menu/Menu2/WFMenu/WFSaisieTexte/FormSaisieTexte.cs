using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFCheckBoxRadioButton;

namespace WFSaisieTexte
{
    public partial class FormSaisieTexte : Form
    {
        public FormSaisieTexte()
        {
            InitializeComponent();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            FormCheckBoxRadioButton formCheckBoxRadioButton = new FormCheckBoxRadioButton(textBoxTexte.Text);
            formCheckBoxRadioButton.Show();
            
        }
    }
}
