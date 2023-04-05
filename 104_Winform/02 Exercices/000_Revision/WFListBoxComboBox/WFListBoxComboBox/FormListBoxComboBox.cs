using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFListBoxComboBox
{
    public partial class FormListBoxComboBox : Form
    {
        private List<string> list;

        public FormListBoxComboBox()
        {
            InitializeComponent();
            InitializeButtons();
        }

        public FormListBoxComboBox(List<string> list)
        {
            InitializeComponent();
            InitializeComponent2(list);
            InitializeButtons();
        }

        private void InitializeComponent2(List<string> list)
        {
            foreach (var item in list)
            {
                comboBoxSource.Items.Add(item);
            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (comboBoxSource.Items.Count > 0 && comboBoxSource.SelectedItem != null)
            {
                listBoxCible.Items.Add(comboBoxSource.SelectedItem);
                comboBoxSource.Items.Remove(comboBoxSource.SelectedItem);
                listBoxCible.SetSelected(listBoxCible.Items.Count - 1, true);
            }
        }

        private void buttonAjouterTout_Click(object sender, EventArgs e)
        {
            do
            {
                foreach (object item in comboBoxSource.Items)
                {
                    listBoxCible.Items.Add(item);
                    comboBoxSource.Items.Remove(item);
                }
            } while (comboBoxSource.Items.Count > 0);
            listBoxCible.SetSelected(0, true);
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (listBoxCible.Items.Count > 0
                && listBoxCible.SelectedItems != null
                && listBoxCible.SelectedIndex != -1)
            {
                comboBoxSource.Items.Add(listBoxCible.SelectedItem);
                listBoxCible.Items.Remove(listBoxCible.SelectedItem);
                if (listBoxCible.Items.Count > 0)
                {
                    listBoxCible.SetSelected(listBoxCible.SelectedIndex + 1, true);
                }
            }
        }

        private void buttonToutSupprimer_Click(object sender, EventArgs e)
        {
            while (listBoxCible.Items.Count > 0)
            {
                listBoxCible.SetSelected(0, true);
                comboBoxSource.Items.Add(listBoxCible.SelectedItem);
                listBoxCible.Items.Remove(listBoxCible.SelectedItem);
            }
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            if (listBoxCible.Items.Count > 0
                && listBoxCible.SelectedIndex != -1)
            {
                int nb = listBoxCible.SelectedIndex;
                object itemTemp = listBoxCible.Items[nb - 1];
                listBoxCible.Items[nb - 1] = listBoxCible.Items[nb];
                listBoxCible.Items[nb] = itemTemp;
                listBoxCible.SetSelected(nb - 1, true);
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            if (listBoxCible.Items.Count > 0
                && listBoxCible.SelectedIndex != -1)
            {
                int nb = listBoxCible.SelectedIndex;
                object itemTemp = listBoxCible.Items[nb + 1];
                listBoxCible.Items[nb + 1] = listBoxCible.Items[nb];
                listBoxCible.Items[nb] = itemTemp;
                listBoxCible.SetSelected(nb + 1, true);
            }
        }

        /// <summary>
        /// Permet l'initialisation de tous les boutons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxCible_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeButtons();
        }

        /// <summary>
        /// Active ou désactive les boutons d'ajout
        /// </summary>
        private void ButtonsAjouter_Enable()
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

        /// <summary>
        /// Active ou désactive les boutons de suppression
        /// </summary>
        private void ButtonsSupprimer_Enable()
        {
            if (listBoxCible.Items.Count == 0)
            {
                buttonSupprimer.Enabled = false;
                buttonToutSupprimer.Enabled = false;
            }
            else
            {
                buttonSupprimer.Enabled = true;
                buttonToutSupprimer.Enabled = true;
            }
        }

        /// <summary>
        /// Active ou désactive le buttonDown
        /// </summary>
        private void ButtonDown_Enable()
        {
            if (listBoxCible.Items.Count == 0
                || listBoxCible.SelectedIndex == -1
                || listBoxCible.SelectedIndex == listBoxCible.Items.Count - 1)
            {
                buttonDown.Enabled = false;
            }
            else
            {
                buttonDown.Enabled = true;
            }
        }

        /// <summary>
        /// Active ou désactive le buttonUp
        /// </summary>
        private void ButtonUp_Enable()
        {
            if (listBoxCible.Items.Count == 0
                || listBoxCible.SelectedIndex == -1
                || listBoxCible.SelectedIndex == 0)
            {
                buttonUp.Enabled = false;
            }
            else
            {
                buttonUp.Enabled = true;
            }
        }

        /// <summary>
        /// Vérifie si les boutons doivent être activés ou désactivés
        /// </summary>
        private void InitializeButtons()
        {
            ButtonUp_Enable();
            ButtonDown_Enable();
            ButtonsAjouter_Enable();
            ButtonsSupprimer_Enable();
        }

        /// <summary>
        /// Ajoute le texte saisi dans l'en-tête de la comboBoxSource
        /// dans la liste d'items de cette dernière.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxSource_AjouterElement(object sender, EventArgs e)
        {
            if (!PresenceDoublonsComboBoxSource()
                && !PresenceBoublonsListBoxCible()
                && comboBoxSource.Text != string.Empty)
            {
                comboBoxSource.Items.Add(comboBoxSource.Text);
            }
        }

        /// <summary>
        /// Vérifie si le texte saisi dans l'en-tête de la comboBoxSource
        /// n'existe pas déjà dans les items de cette dernière.
        /// </summary>
        /// <returns></returns>
        private bool PresenceDoublonsComboBoxSource()
        {
            foreach (var item in comboBoxSource.Items)
            {
                if (comboBoxSource.Text == item.ToString())
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Vérifie si le texte saisi dans la comboBoxSource
        /// n'existe pas déjà dans les items de la listBoxCible.
        /// </summary>
        /// <returns>
        /// true si c'est le cas
        /// false dans le cas contraire
        /// </returns>
        private bool PresenceBoublonsListBoxCible()
        {
            foreach (var item in listBoxCible.Items)
            {
                if (comboBoxSource.Text == item.ToString())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
