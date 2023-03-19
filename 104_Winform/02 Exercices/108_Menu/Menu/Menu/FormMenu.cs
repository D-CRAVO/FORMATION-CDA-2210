using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAdditionneur;
using ValidationSaisie2;
using CheckBoxBoutonsRadio;
using ListBox2;
using ListBoxComboBox;
using DefilementCouleurs;

namespace Menu
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();

            toolStripStatusLabelDate.Text = DateTime.Now.ToString();
        }

        private void additionneurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdditionneur formAdditionneur = new FormAdditionneur();
            formAdditionneur.MdiParent = this;
            formAdditionneur.Show();
        }

        private void validationSaisieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormulaireSaisie formulaireSaisie = new FormulaireSaisie();
            //formulaireSaisie.MdiParent = this;
            //formulaireSaisie.Show();
        }

        private void checkBoxRadioButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCheckBoxRadioButton radioButton = new FormCheckBoxRadioButton();
            radioButton.MdiParent = this;
            radioButton.Show();
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBox2.ListBox listBox = new ListBox2.ListBox();
            listBox.MdiParent = this;
            listBox.Show();
        }

        private void listBoxComboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFormulaire formulaire = new FormFormulaire();
            formulaire.MdiParent = this;
            formulaire.Show();
        }

        private void defilementCouleursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Defilement defilement = new Defilement();
            defilement.MdiParent = this;
            defilement.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment quitter", "Quitter", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
            }

        }

        private void sidentifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenue !");
            phase1.Enabled = true;
            phase2.Enabled = true;
            phase3.Enabled = true;
            fenêtres.Enabled = true;
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            sidentifierToolStripMenuItem_Click(sender, e);
        }
    }
}
