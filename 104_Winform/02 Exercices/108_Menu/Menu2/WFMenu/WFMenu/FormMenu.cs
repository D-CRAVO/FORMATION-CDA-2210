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
        private int compteur;
        private string texte;
        FormIdentification formIdentification;

        //public ToolStripMenuItem Phase1ToolStripMenuItem { get {  return phase1ToolStripMenuItem; } set { phase1ToolStripMenuItem.Enabled = value; }

        public FormMenu()
        {
            InitializeComponent();
            compteur = 0;
            FigerVolets();
            Authentification();
            CopieMenuPhase3();
            toolStripSplitButtonPhase3.DropDown = phase3ToolStripMenuItem.DropDown;
        }

        public void CopieMenuPhase3()
        {

            //foreach (object item in phase3ToolStripMenuItem.DropDownItems)
            //{
            //    toolStripSplitButtonPhase3.DropDownItems.Add(item);
            //}

            //toolStripSplitButtonPhase3.DropDownItems.Add(checkBoxRadioButtonsToolStripMenuItem);
            //toolStripSplitButtonPhase3.DropDownItems.Add(listBoxToolStripMenuItem);
            //toolStripSplitButtonPhase3.DropDownItems.Add(listBoxComboBoxToolStripMenuItem);
            //toolStripSplitButtonPhase3.DropDownItems.Add(defilementCouleursToolStripMenuItem);
            //toolStripSplitButtonPhase3.DropDownItems.Add(empruntsToolStripMenuItem);

            //wFCheckBoxRadioButtonsToolStripMenuItem = checkBoxRadioButtonsToolStripMenuItem;

            MenuStrip toolStripMenu1 = new MenuStrip();

            ToolStripMenuItem menuItem1 = new ToolStripMenuItem();
            ToolStripMenuItem menuItem2 = new ToolStripMenuItem();
            ToolStripMenuItem menuItem3 = new ToolStripMenuItem();
            ToolStripMenuItem menuItem4 = new ToolStripMenuItem();
            ToolStripMenuItem menuItem5 = new ToolStripMenuItem();

            menuItem1.Text = checkBoxRadioButtonsToolStripMenuItem.Text;
            menuItem2.Text = listBoxToolStripMenuItem.Text;
            menuItem3.Text = listBoxComboBoxToolStripMenuItem.Text;
            menuItem4.Text = defilementCouleursToolStripMenuItem.Text;
            menuItem5.Text = empruntsToolStripMenuItem.Text;


            //menuItem1 = checkBoxRadioButtonsToolStripMenuItem;
            //menuItem2 = listBoxToolStripMenuItem;
            //menuItem3 = listBoxComboBoxToolStripMenuItem;
            //menuItem4 = defilementCouleursToolStripMenuItem;
            //menuItem5 = empruntsToolStripMenuItem;

            //toolStripMenu1.Items.Add(menuItem1);
            //toolStripMenu1.Items.Add(menuItem2);
            //toolStripMenu1.Items.Add(menuItem3);
            //toolStripMenu1.Items.Add(menuItem4);
            //toolStripMenu1.Items.Add(menuItem5);

            //menuStrip1.Items.Add(menuItem1);
            //menuStrip1.Items.Add(menuItem2);
            //menuStrip1.Items.Add(menuItem3);
            //menuStrip1.Items.Add(menuItem4);
            //menuStrip1.Items.Add(menuItem5);

            toolStripSplitButtonPhase3.DropDownItems.Add(menuItem1);
            toolStripSplitButtonPhase3.DropDownItems.Add(menuItem2);
            toolStripSplitButtonPhase3.DropDownItems.Add(menuItem3);
            toolStripSplitButtonPhase3.DropDownItems.Add(menuItem4);
            toolStripSplitButtonPhase3.DropDownItems.Add(menuItem5);

            //toolStripSplitButtonPhase3.Text = checkBoxRadioButtonsToolStripMenuItem.Text;
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
    }
}
