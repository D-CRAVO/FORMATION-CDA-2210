﻿using System;
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
        }

        public FormListBoxComboBox(List<string> list)
        {
            InitializeComponent();
            InitializeComponent2(list);
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
            foreach (object item in comboBoxSource.Items)
            {
                listBoxCible.Items.Add(item);
                comboBoxSource.Items.Remove(item);
                listBoxCible.SetSelected(0, true);
            }

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
            for(int i = listBoxCible.Items.Count; i > 0; i--)
            {
                comboBoxSource.Items.Add(listBoxCible.SelectedItems[i]);
            }
            listBoxCible.Items.Clear();
        }
    }
}
