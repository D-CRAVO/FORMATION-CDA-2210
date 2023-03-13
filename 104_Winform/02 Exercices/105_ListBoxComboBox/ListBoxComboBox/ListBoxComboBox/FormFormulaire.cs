using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxComboBox
{
    public partial class FormFormulaire : Form
    {
        private string[] pays;

        public FormFormulaire()
        {
            InitializeComponent();

            comboBoxSource.Items.Add("Pays");

            desactivationButtonUpDown();



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSource.Text == "Pays")
            {
                pays = new string[] { "France", "Belgique", "Allemagne", "Japon", "Portugal", "Grèce" };
                listBoxSource.Items.AddRange(pays);
            }
        }

        private void listBoxSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            listBoxCible.Items.Add(listBoxSource.SelectedItem);
        }

        private void buttonAjouterTout_Click(object sender, EventArgs e)
        {
            listBoxCible.Items.AddRange(listBoxSource.Items);
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            listBoxCible.Items.Remove(listBoxCible.SelectedItem);
            desactivationButtonUpDown();
        }

        private void buttonSupprimerTout_Click(object sender, EventArgs e)
        {
            listBoxCible.Items.Clear();
            desactivationButtonUpDown();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            listBoxCible.SelectedIndex = listBoxCible.SelectedIndex++;
        }

        private void listBoxCible_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCible.SelectedItem != null)
            {
                buttonUp.Enabled = true;
                buttonDown.Enabled = true;
            }
        }

        private void desactivationButtonUpDown()
        {
            if (listBoxCible.Items.Count == 0)
            {
                buttonUp.Enabled = false;
                buttonDown.Enabled = false;
            }
        }

    }
}
