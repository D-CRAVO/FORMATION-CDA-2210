using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLControles;

namespace WFListBox
{
    public partial class FormListBox : Form
    {

        public string[] list;
        private string nouvelElement;

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

        private void textBoxNouvelElement_TextChanged(object sender, EventArgs e)
        {
            nouvelElement = textBoxNouvelElement.Text.Trim();
            if (nouvelElement!= null)
            {
                if (Controle.ControleNouvelElement(nouvelElement)
                    && !ExistenceDoublons(nouvelElement))
                {
                    errorProviderNouvelElement.SetError(textBoxNouvelElement, string.Empty);
                    errorProviderAjoutListe.SetError(textBoxNouvelElement, string.Empty);
                }
                else
                {
                    errorProviderNouvelElement.SetError(textBoxNouvelElement, "Veuillez ne saisir que des prénoms valides");
                }
            }
           
        }

        private void buttonAjoutListe_Click(object sender, EventArgs e)
        {
            if (nouvelElement != null)
            {
                if (Controle.ControleNouvelElement(nouvelElement)
                    && !ExistenceDoublons(nouvelElement))
                {
                    listBoxLstListe.Items.Add(nouvelElement);
                    textBoxNouvelElement.Clear();
                    textBoxNouvelElement.Focus();
                    initializeTextBoxItemsCount();
                }
            }
        }

        private void buttonSelectionner_Click(object sender, EventArgs e)
        {
            if (Controle.ControleIndexSelection(textBoxIndexElement.Text))
            {
                int indexElement = int.Parse((string)textBoxIndexElement.Text);
                if (indexElement < listBoxLstListe.Items.Count && indexElement >= 0)
                {
                    listBoxLstListe.SetSelected(indexElement, true);
                }
            }
        }

        private void textBoxIndexElement_TextChanged(object sender, EventArgs e)
        {
            if (textBoxIndexElement.Text == string.Empty)
            {
                errorProviderIndexInvalide.SetError(textBoxIndexElement, string.Empty);
                errorProviderHorsLimite.SetError(textBoxIndexElement, string.Empty);
            }
            else if (Controle.ControleIndexSelection(textBoxIndexElement.Text))
            {
                errorProviderIndexInvalide.SetError(textBoxIndexElement, string.Empty);
                int indexElement = int.Parse((string)textBoxIndexElement.Text);
                if (indexElement < listBoxLstListe.Items.Count && indexElement >= 0)
                {
                    errorProviderHorsLimite.SetError(textBoxIndexElement, string.Empty);
                }
                else
                {
                    errorProviderHorsLimite.SetError(textBoxIndexElement, "Index hors-limites");
                }
            }
            else
            {
                errorProviderIndexInvalide.SetError(textBoxIndexElement, "Index invalide");
            }
        }

        private bool ExistenceDoublons(string _str)
        {
            bool result = false;
            foreach (string item in listBoxLstListe.Items)
            {
                if (item == _str)
                {
                    result = true;
                }
            }
            if (result)
            {
                errorProviderAjoutListe.SetError(textBoxNouvelElement, "Existe déjà dans la liste");
            }
            return result;
        }
    }
}
