using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFListBox
{
    public partial class FormListBox : Form
    {

        public string[] list;

        public FormListBox()
        {
            InitializeComponent();
        }

        public FormListBox(string[] list)
        {
            InitializeComponent();
            InitializeComponent2(list);
        }

        private void InitializeComponent2(string[] list)
        {
            listBoxLstListe.Items.AddRange(list);
            initializeTextBoxItemsCount();
        }

        private void initializeTextBoxItemsCount()
        {
            textBoxItemsCount.Text = listBoxLstListe.Items.Count.ToString();
        }

        private void buttonViderListe_Click(object sender, EventArgs e)
        {
            listBoxLstListe.Items.Clear();
            textBoxSelectedIndex.Clear();
            textBoxText.Clear();
            initializeTextBoxItemsCount();
        }

        private void listBoxLstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSelectedIndex.Text = listBoxLstListe.SelectedIndex.ToString();
            textBoxText.Text = listBoxLstListe.SelectedItem.ToString();
        }

        private void buttonAjoutListe_Click(object sender, EventArgs e)
        {
            listBoxLstListe.Items.Add(textBoxNouvelElement.Text);
            initializeTextBoxItemsCount();
        }

        private void buttonSelectionner_Click(object sender, EventArgs e)
        {
            if (ControleNouvelElement)
            listBoxLstListe.SetSelected(int.Parse(textBoxIndexElement.Text), true);
        }
    }
}
