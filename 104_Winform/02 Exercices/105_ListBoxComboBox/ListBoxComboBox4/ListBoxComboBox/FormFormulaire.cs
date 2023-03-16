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

            //comboBoxSource.Items.Add("Pays");
            

            activationButtonUpDown();
            activationButtonAdd();
            activationButtonDelete();
        }

        private void comboBoxSource_Dropdown(object sender, EventArgs e)
        {
            if (testDoublonSource((string)comboBoxSource.Text)
                && testDoublonCible((string)comboBoxSource.Text)
                && comboBoxSource.Text != "")
            {
                comboBoxSource.Items.Add((string)comboBoxSource.Text);
            }
            
        }
        

        private void comboBoxSource_DropDown(object sender, EventArgs e)
        {

            //comboBoxSource.DropDown += new System.EventHandler(comboBoxSource_Dropdown);

            //if (comboBoxSource.Text == "Pays")
            //{

            //    pays = new string[] { "France", "Belgique", "Allemagne", "Japon", "Portugal", "Grèce", "France" };
            //    //listBoxSource.Items.AddRange(pays);

            //    for (int i = 0; i < pays.Length; i++)
            //    {

            //        if (testDoublonSource(pays[i])
            //            && testDoublonCible(pays[i]))
            //        {
            //            comboBoxSource.Items.Add((string)pays[i]);
            //        }
            //    }
            //}
            //comboBoxSource.Select(0, 0);
            //activationButtonAdd();

            if (testDoublonSource((string)comboBoxSource.Text)
               && testDoublonCible((string)comboBoxSource.Text)
               && comboBoxSource.Text != "")
            {
                comboBoxSource.Items.Add((string)comboBoxSource.Text);
            }
            comboBoxSource.Select(0, 0);
            activationButtonAdd();
        }

        
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            int nb = comboBoxSource.SelectedIndex;
            if (nb != null)
            {
                listBoxCible.Items.Add(comboBoxSource.SelectedItem);
                comboBoxSource.Items.Remove(comboBoxSource.SelectedItem);
                activationButtonAdd();
                activationButtonDelete();
                activationButtonUpDown();
            }
            else
            {
                comboBoxSource.Select(0, 0);
            }


            if (nb > 0 && nb < comboBoxSource.Items.Count)
            {

                comboBoxSource.Select(nb - 1, nb - 1);
            }
            else if (nb == 0 && nb < listBoxSource.Items.Count)
            {
                comboBoxSource.Select(nb,nb);
            }
            else
            {
                listBoxCible.SetSelected(0, true);
                return;
            }
        }

        private void buttonAjouterTout_Click(object sender, EventArgs e)
        {
            //listBoxCible.Items.AddRange(comboBoxSource.Items);
            int nbItems = comboBoxSource.Items.Count;
            for (int i = nbItems - 1; i >= 0; i--)
            {
                listBoxSource.Items.Remove(comboBoxSource.Items[i]);
            }
            listBoxCible.SetSelected(0, true);
            comboBoxSource.Items.Clear();
            activationButtonAdd();
            activationButtonDelete();
            activationButtonUpDown();
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            int nb = (int)listBoxCible.SelectedIndex;
            if (nb != -1)
            {
                comboBoxSource.Items.Add(listBoxCible.SelectedItem);
                listBoxCible.Items.Remove(listBoxCible.SelectedItem);
                activationButtonAdd();
                activationButtonUpDown();
            }
            else
            {
                listBoxCible.SetSelected(0, true);
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
                activationButtonDelete();
                comboBoxSource.Select(0,0);
                return;
            }
        }

        private void buttonSupprimerTout_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxCible.Items.Count; i++)
            {
                listBoxSource.Items.Add((string)listBoxCible.Items[i]);
            }
            listBoxCible.Items.Clear();
            comboBoxSource.Select(0,0);
            activationButtonUpDown();
            activationButtonAdd();
            activationButtonDelete();
        }

        private void listBoxCible_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCible.SelectedItem != null)
            {
                buttonUp.Enabled = true;
                buttonDown.Enabled = true;
            }
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            int nb = listBoxCible.SelectedIndex;
            if (nb == -1)
            {
                listBoxCible.SetSelected(0, true);
                for (int i = 0; i < comboBoxSource.Items.Count; i++)
                {
                    listBoxSource.SetSelected(i, false);
                }
                return;
            }
            else if (nb != 0)
            {
                string tempItem = (string)listBoxCible.Items[nb - 1];
                listBoxCible.Items[nb - 1] = (string)listBoxCible.Items[nb];
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
            if (nb == -1)
            {
                listBoxCible.SetSelected(0, true);
                for (int i = 0; i < comboBoxSource.Items.Count; i++)
                {
                    comboBoxSource.Select(i, i);
                }
            }
            else if (nb != listBoxCible.Items.Count - 1)
            {
                string tempItem = (string)listBoxCible.Items[nb + 1];
                listBoxCible.Items[nb + 1] = (string)listBoxCible.Items[nb];
                listBoxCible.Items[nb] = tempItem;
                listBoxCible.SelectedIndex = nb + 1;
            }
            else
            {
                return;
            }
        }

        private void activationButtonAdd()
        {
            if (comboBoxSource.Items.Count == 0)
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

        private void activationButtonDelete()
        {
            if (listBoxCible.Items.Count == 0)
            {
                buttonSupprimer.Enabled = false;
                buttonSupprimerTout.Enabled = false;
            }
            else
            {
                buttonSupprimer.Enabled = true;
                buttonSupprimerTout.Enabled = true;
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

        private bool testDoublonSource(string _string)
        {
            bool ok = true;
            for (var j = 0; j < comboBoxSource.Items.Count; j++)
            {
                if (_string == (string)comboBoxSource.Items[j])
                {
                    ok = false;
                }
            }
            return ok;
        }

        private bool testDoublonCible(string _string)
        {
            bool ok = true;
            for (var j = 0; j < listBoxCible.Items.Count; j++)
            {
                if (_string == (string)listBoxCible.Items[j])
                {
                    ok = false;
                }
            }
            return ok;
        }
    }
}
