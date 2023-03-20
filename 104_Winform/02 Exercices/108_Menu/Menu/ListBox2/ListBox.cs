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

namespace ListBox2
{
    public partial class ListBox : Form
    {
        private bool verifNouvelElement;
        private bool verifDoublons;
        private bool verifIndex;

        private string[] test;

        public ListBox()
        {
            InitializeComponent();

            test = new string[] { "Denis", "Jean-Pierre", "Jean-Paul", "Arnaud"};
            listBoxListe.Items.AddRange(test);

            initialisationItemsCount();
        }

        private void textBoxNouvelElement_TextChanged(object sender, EventArgs e)
        {
            
            string elementSaisi = (string)textBoxNouvelElement.Text.Trim();
            verifNouvelElement = true;
            verifDoublons = true;

            if (elementSaisi == "")
            {
                errorProviderTexteInvalide.SetError(textBoxNouvelElement, "");
                errorProviderDoublons.SetError(textBoxNouvelElement, "");
            }
            else if (Controles.controleNouvelElement(elementSaisi))
            {
                errorProviderTexteInvalide.SetError(textBoxNouvelElement, "");
                foreach (var item in listBoxListe.Items)
                {
                    
                    if ((string)item == elementSaisi)
                    {
                        verifDoublons = false;
                        errorProviderDoublons.SetError(textBoxNouvelElement, "Texte déjà enregistré");
                    }
                }
            }
            else
            {
                errorProviderTexteInvalide.SetError(textBoxNouvelElement, "Texte Invalide");
                verifNouvelElement = false;
            }

        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            string elementSaisi = (string)textBoxNouvelElement.Text.Trim();
            if (verifNouvelElement && verifDoublons && elementSaisi != "")
            {
                listBoxListe.Items.Add(elementSaisi);
                textBoxNouvelElement.Clear();
                textBoxNouvelElement.Focus();
                initialisationItemsCount();
            }
        }

        private void textBoxIndex_TextChanged(object sender, EventArgs e)
        {
            verifIndex = true;
            if (textBoxIndex.Text == "")
            {
                errorProviderIndex.SetError(textBoxIndex, "");
            }
            else if (Controles.controleIndex(textBoxIndex.Text))
            {

                errorProviderIndex.SetError(textBoxIndex, "");
            }
            else
            {
                errorProviderIndex.SetError(textBoxIndex, "Valeur invalide");
                verifIndex = false;
            }
        }

        private void buttonSelectionner_Click(object sender, EventArgs e)
        {
            if (verifIndex)
            {
                listBoxListe.SetSelected(int.Parse((string)textBoxIndex.Text), true);
            }
        }

        private void listBoxListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            initialisationItemsCount();
            textBoxSelectedIndex.Text = listBoxListe.SelectedIndex.ToString();
            textBoxText.Text = listBoxListe.SelectedItem.ToString();
        }

        private void initialisationItemsCount()
        {
            textBoxItemsCount.Text = listBoxListe.Items.Count.ToString();
        }

        private void buttonVider_Click(object sender, EventArgs e)
        {
            listBoxListe.Items.Clear();
            textBoxSelectedIndex.Clear();
            textBoxText.Clear();
            initialisationItemsCount();
        }
    }
}
