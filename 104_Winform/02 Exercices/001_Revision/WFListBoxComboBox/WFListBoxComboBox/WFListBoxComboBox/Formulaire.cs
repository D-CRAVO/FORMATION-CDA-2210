using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFListBoxComboBox
{
    public partial class Formulaire : Form
    {
        public Formulaire()
        {
            InitializeComponent();
        }

        public Formulaire(List<string> data)
        {
            InitializeComponent();
            FillComboBoxSource(data);
            CheckButtons();
        }

        public void FillComboBoxSource(List<string> data)
        {
            foreach (string item in data)
            {
                comboBoxSource.Items.Add(item);
            }
        }

        public void CheckButtons()
        {
            CheckButtonsAdd();
            CheckButtonsRemove();
        }

        public void CheckButtonsAdd()
        {
            if(comboBoxSource.Items.Count == 0)
            {
                buttonAdd.Enabled = false;
                buttonAddAll.Enabled = false;
            }
            else
            {
                buttonAdd.Enabled = true;
                buttonAddAll.Enabled = true;
            }
        }

        public void CheckButtonsRemove()
        {
            if(listBoxDestination.Items.Count == 0)
            {
                buttonRemove.Enabled = false;
                buttonRemoveAll.Enabled = false;
            }
            else
            {
                buttonRemove.Enabled = true;
                buttonRemoveAll.Enabled = true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            listBoxDestination.Items.Add(comboBoxSource.SelectedItem);
            comboBoxSource.Items.Remove(comboBoxSource.SelectedItem);
            listBoxDestination.SetSelected(listBoxDestination.Items.Count - 1, true);
            CheckButtons();
        }

        private void buttonAddAll_Click(object sender, EventArgs e)
        {
            do
            {
                foreach (string item in comboBoxSource.Items)
                {
                    listBoxDestination.Items.Add((string)item);
                    comboBoxSource.Items.Remove((string)item);
                }
            } while (comboBoxSource.Items.Count > 0);
            listBoxDestination.SetSelected(listBoxDestination.Items.Count - 1, true);
            CheckButtons();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            comboBoxSource.Items.Add(listBoxDestination.SelectedItem);
            listBoxDestination.Items.Remove(listBoxDestination.SelectedItem);
            if (listBoxDestination.Items.Count > 0)
            {
                listBoxDestination.SetSelected(listBoxDestination.Items.Count - 1, true);
            }
            CheckButtons();
        }

        private void buttonRemoveAll_Click(object sender, EventArgs e)
        {
            while (listBoxDestination.Items.Count > 0)
            {
                listBoxDestination.SetSelected(0, true);
                comboBoxSource.Items.Add(listBoxDestination.SelectedItem);
                listBoxDestination.Items.Remove(listBoxDestination.SelectedItem);
            }
            CheckButtons();
        }
    }
}
