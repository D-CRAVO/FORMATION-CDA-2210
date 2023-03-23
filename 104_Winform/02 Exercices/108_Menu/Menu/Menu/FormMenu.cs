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
using WFSaisie;
using WFIdentification;

namespace Menu
{
    public partial class FormMenu : Form
    {
        private int compteur;

        public ToolStripMenuItem Phase1 { get { return phase1; } set { phase1 = value; } }
        public ToolStripMenuItem Phase2 { get { return phase2; } set { phase2 = value; } }
        public ToolStripMenuItem Phase3 { get { return Phase3; } set { Phase3 = value; } }
        public ToolStripMenuItem Fenetres { get { return fenetres; } set { fenetres = value; } } 

        public FormMenu()
        {
            InitializeComponent();
            compteur = 1;
            toolStripStatusLabelDate.Text = DateTime.Now.ToString();
        }

        private void additionneurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelIdentification.Text = additionneurToolStripMenuItem.Text;
            compteur++;

            FormAdditionneur formAdditionneur = new FormAdditionneur();
            formAdditionneur.Text += $" N°{compteur}";
            formAdditionneur.MdiParent = this;
            formAdditionneur.Show();
        }

        private void validationSaisieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelIdentification.Text = validationSaisieToolStripMenuItem.Text;

            //FormulaireSaisie formulaireSaisie = new FormulaireSaisie();
            //formulaireSaisie.MdiParent = this;
            //formulaireSaisie.Show();
        }

        private void checkBoxRadioButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelIdentification.Text = checkBoxRadioButtonToolStripMenuItem.Text;

            //FormCheckBoxRadioButton radioButton = new FormCheckBoxRadioButton();
            //radioButton.MdiParent = this;
            //radioButton.Show();

            FormSaisie formSaisie = new FormSaisie();
            formSaisie.MdiParent = this;
            formSaisie.Show();
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelIdentification.Text = toolStripStatusLabelIdentification.Text;

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
            //toolStripStatusLabelIdentification.Text = FormMenu.GetForegroundWindow();
            //toolStripStatusLabelIdentification.Text = this.MainMenuStrip.Text;
            //toolStripStatusLabelIdentification.Text = this.MainMenuStrip.AccessibleDefaultActionDescription;

            FormSaisie saisie = new FormSaisie();
            saisie.MdiParent = this;
            saisie.Show();

            //MessageBox.Show("Bienvenue !");
            phase1.Enabled = true;
            phase2.Enabled = true;
            phase3.Enabled = true;
            fenetres.Enabled = true;
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

        private void toolStripStatusLabelIdentification_Click(object sender, EventArgs e)
        {

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            //toolStripStatusLabelIdentification.Text = FormMenu.ActiveForm.Name;
            //toolStripStatusLabelIdentification.Text = ActiveForm.Name;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
