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
        bool verifNouvelElement;
        bool verifDoublons;
        public ListBox()
        {
            InitializeComponent();
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
            }
        }

        private void textBoxIndex_TextChanged(object sender, EventArgs e)
        {
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
            }
        }
    }
}
