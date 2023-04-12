using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAdditionneur;
using WFCheckBoxRadioButton;
using WFSaisieTexte;
using WFIdentification;
using WFValidationSaisie;
using WFListBox;
using WFDefilementCouleurs;
using WinFormsEmprunts;

namespace WFMenu
{
    public partial class FormMenu : Form
    {
        private int compteur;
        FormIdentification formIdentification;

        public FormMenu()
        {
            InitializeComponent();
            compteur = 0;
            FigerVolets();
            Authentification();
            toolStripSplitButtonPhase3.DropDown = phase3ToolStripMenuItem.DropDown;
            toolStripStatusLabelDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }



        public void FigerVolets()
        {
            phase1ToolStripMenuItem.Enabled = false;
            phase2ToolStripMenuItem.Enabled = false;
            phase3ToolStripMenuItem.Enabled = false;
            fenêtresToolStripMenuItem.Enabled = false;
        }

        public void LiberationVolets()
        {
            phase1ToolStripMenuItem.Enabled = true;
            phase2ToolStripMenuItem.Enabled = true;
            phase3ToolStripMenuItem.Enabled = true;
            fenêtresToolStripMenuItem.Enabled = true;
        }

        private void additionneurToolStripMenuItem_Click(object sender, EventArgs e)
            => OuvrirFormulaire(new FormAdditionneur());
        //{
        //    compteur++;
        //    FormAdditionneur formAdditionneur = new FormAdditionneur();
        //    formAdditionneur.Text += $" N°{compteur}";
        //    formAdditionneur.MdiParent = this;
        //    formAdditionneur.Show();
        //}

        private void OuvrirFormulaire(Form form)
        {
            compteur++;
            form.Text += $" N°{compteur}";
            form.MdiParent = this;
            form.Show();
        }

        private void checkBoxRadioButtonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new FormSaisieTexte());
        }

        private void sidentifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Authentification();
        }

        private void F_FormClosing(object sender, FormClosingEventArgs e)
        {
            formIdentification = sender as FormIdentification;
            if (formIdentification.CheckLoginPassword() == true)
            {
                LiberationVolets();
            }
        }

        private void toolStripLabelIdentification_Click(object sender, EventArgs e)
        {
            Authentification();
        }

        private void Authentification()
        {
            formIdentification = new FormIdentification();
            formIdentification.FormClosing += F_FormClosing;
            formIdentification.ShowDialog();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
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

        private void validationSaisieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new FormValidationSaisie());
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new FormListBox());
        }

        private void defilementCouleursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new FormDefilementCouleurs());
        }

        private void empruntsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new FormEmprunts());
        }
    }
}
