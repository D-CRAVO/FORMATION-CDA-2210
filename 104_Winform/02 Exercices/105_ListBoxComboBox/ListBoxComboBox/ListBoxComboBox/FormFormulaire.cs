﻿using System;
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
            activationButtonAdd();
            activationButtonDelete();
        }

        

        private void comboBoxSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            pays = new string[] { "France", "Belgique", "Allemagne", "Japon", "Portugal", "Grèce" };
            if (comboBoxSource.Text == "Pays")
            {
                bool ok = false;
                
                listBoxSource.Items.AddRange(pays);
                for (int i = 0; i < pays.Length; i++)
                {
                    foreach (var item in listBoxSource.Items)
                    {
                        
                    }
                }  
                listBoxSource.SetSelected(0, true);
                activationButtonAdd();
            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            int nb = listBoxSource.SelectedIndex;
            if (nb != null)
            {
                listBoxCible.Items.Add(listBoxSource.SelectedItem);
                listBoxSource.Items.Remove(listBoxSource.SelectedItem);
                activationButtonAdd();
                activationButtonDelete();
                activationButtonUpDown();
            }
            else
            {
                listBoxSource.SetSelected(0, true);
            }
           
            
            if (nb > 0 && nb < listBoxSource.Items.Count)
            {

                listBoxSource.SetSelected(nb - 1, true);
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
            //int nbItems = listBoxSource.Items.Count;
            //for (int i = nbItems-1; i >= 0 ; i--)
            //{
            //    listBoxSource.Items.Remove(listBoxSource.Items[i]);
            //}
            listBoxCible.SetSelected(0, true);
            listBoxSource.Items.Clear();
            activationButtonAdd();
            activationButtonDelete();
            activationButtonUpDown();
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            int nb = listBoxCible.SelectedIndex;
            if (nb != null)
            {
                listBoxSource.Items.Add(listBoxCible.SelectedItem);
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
                listBoxSource.SetSelected(0, true);
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
            listBoxSource.SetSelected(0, true);
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
                for (int i = 0; i < listBoxSource.Items.Count; i++)
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
                for(int i = 0; i < listBoxSource.Items.Count; i++)
                {
                    listBoxSource.SetSelected(i, false);
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
    }
}
