using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
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

            activationButtonUpDown();



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
                listBoxSource.SetSelected(0, true);
            }
        }

        private void listBoxSource_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            int nb = listBoxSource.SelectedIndex;
            listBoxCible.Items.Add(listBoxSource.SelectedItem);
            listBoxSource.Items.Remove(listBoxSource.SelectedItem);
            activationButtonAdd();
            if (nb > 0 && nb < listBoxSource.Items.Count)
            {
                listBoxCible.SetSelected(nb - 1, true);
            }
            else if (nb == 0 && nb < listBoxSource.Items.Count)
            {
                listBoxSource.SetSelected(nb, true);
            }
            else
            {
                
                listBoxCible.SetSelected(0, true);
                return;
            }
        }

        private void buttonAjouterTout_Click(object sender, EventArgs e)
        {
            listBoxCible.Items.AddRange(listBoxSource.Items);
        }

        private void activationButtonAdd()
        {
            if (listBoxSource.Items.Count == 0)
            {
                buttonAjouter.Enabled = false;
                buttonAjouterTout.Enabled = false;
            }
            else
            {
                buttonAjouter.Enabled = true;
                buttonAjouterTout.Enabled = true;
            }
           
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            int nb = listBoxCible.SelectedIndex;
            if (nb != null)
            {
                listBoxSource.Items.Add(listBoxCible.SelectedItem);
                listBoxCible.Items.Remove(listBoxCible.SelectedItem);
                activationButtonAdd();
            }
            
            if (nb > 0 && nb < listBoxCible.Items.Count)
            {
                listBoxCible.SetSelected(nb - 1, true);
            }
            else if (nb == 0 && nb < listBoxCible.Items.Count)
            {
                listBoxCible.SetSelected(nb, true);
            }
            else
            {
                activationButtonUpDown();
                listBoxSource.SetSelected(0, true);
                return;
            }
        }

        private void buttonSupprimerTout_Click(object sender, EventArgs e)
        {
            listBoxCible.Items.Clear();
            activationButtonUpDown();
        }

        private void listBoxCible_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCible.SelectedItem != null)
            {
                buttonUp.Enabled = true;
                buttonDown.Enabled = true;
            }
        }

        private void activationButtonUpDown()
        {
            if (listBoxCible.Items.Count == 0)
            {
                buttonUp.Enabled = false;
                buttonDown.Enabled = false;
            }
            else
            {
                buttonUp.Enabled = true;
                buttonDown.Enabled = true;
            }
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            int nb = listBoxCible.SelectedIndex;
            if (nb != 0)
            {
                string tempItem = listBoxCible.Items[nb - 1].ToString();
                listBoxCible.Items[nb - 1] = listBoxCible.Items[nb].ToString();
                listBoxCible.Items[nb] = tempItem;
                listBoxCible.SelectedIndex = nb - 1;
            }
            else
            {
                return;
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            int nb = listBoxCible.SelectedIndex;
            if (nb != listBoxCible.Items.Count - 1)
            {
                string tempItem = listBoxCible.Items[nb + 1].ToString();
                listBoxCible.Items[nb + 1] = listBoxCible.Items[nb].ToString();
                listBoxCible.Items[nb] = tempItem;
                listBoxCible.SelectedIndex = nb + 1;
            }
            else
            {
                return;
            }

        }
    }
}
