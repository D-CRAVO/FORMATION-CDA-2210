using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryControles;

namespace ListBox
{
    public partial class FormListBox : Form
    {
        List<string> list = new List<string>();

        public FormListBox()
        {
            InitializeComponent();
        }

        private void buttonAjout_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < listBoxListe.Items.Count; j++)
            {
                list.Add(listBoxListe.Items[j].ToString());
            }
            if (Controles.ControleDoublons(textBoxNouvelElement.Text, list))
            {
                listBoxListe.Items.Add(textBoxNouvelElement.Text);
                textBoxNouvelElement.Clear();
                textBoxNouvelElement.Focus();
                textBoxItemsCount.Text = $"{listBoxListe.Items.Count}";
            }
            else
            {
                MessageBox.Show("Déjà enregistré!");
                textBoxNouvelElement.Clear();
                textBoxNouvelElement.Focus();
            }
        }

        private void buttonSelectionner_Click(object sender, EventArgs e)
        {
            if (Controles.ControleValeurIndex(textBoxIndex.Text))
            {
                if (int.Parse(textBoxIndex.Text) < listBoxListe.Items.Count)
                {
                    listBoxListe.SetSelected(int.Parse(textBoxIndex.Text), true);
                    textBoxIndex.Clear();
                }
                else
                {
                    MessageBox.Show("Cet index n'existe pas!");
                    textBoxIndex.Clear();
                    textBoxIndex.Focus();
                }
            }
            else
            {
                MessageBox.Show("Veuillez saisir une valeur correcte!");
                textBoxIndex.Clear();
                textBoxIndex.Focus();
            }
        }

        private void buttonVider_Click(object sender, EventArgs e)
        {
            listBoxListe.Items.Clear();
        }

        private void textBoxItemsCount_TextChanged(object sender, EventArgs e)
        {
            textBoxItemsCount.Text = $"{listBoxListe.Items.Count}";
        }

        private void listBoxListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxText.Text = $"{listBoxListe.SelectedItem}";
            textBoxSelectedIndex.Text = $"{listBoxListe.SelectedIndex}";
        }
    }
}
