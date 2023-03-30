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
        public FormMenu()
        {
            InitializeComponent();
            compteur = 0;
            phase1ToolStripMenuItem.Enabled = false;
            phase2ToolStripMenuItem.Enabled = false;
            phase3ToolStripMenuItem.Enabled = false;
            fenêtresToolStripMenuItem.Enabled = false;  
            OuvrirFormulaire(new FormIdentification());
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
            OuvrirFormulaire(new FormIdentification());
        }

        private void toolStripLabelIdentification_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new FormIdentification());
        }
    }
}
