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

namespace WFMenu
{
    public partial class FormMenu : Form
    {
        //private int compteurAdditionneur;
        private int compteur;
        private string texte;

        //public ToolStripMenuItem Phase1ToolStripMenuItem { get {  return phase1ToolStripMenuItem; } set { phase1ToolStripMenuItem.Enabled = value; }

        public FormMenu()
        {
            InitializeComponent();
            compteur = 0;
            FigerVolets();
            Authentification();
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
            form.Text += $"N°{compteur}";
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
            FormIdentification formIdentification = sender as FormIdentification;
            bool verif = formIdentification.CheckLoginPassword();
            if (verif)
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
            FormIdentification formIdentification = new FormIdentification();
            formIdentification.FormClosing += F_FormClosing;
            OuvrirFormulaire(formIdentification);
        }
    }
}
