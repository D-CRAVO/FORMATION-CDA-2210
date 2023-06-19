using ClassLibraryChat;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsECF_SPA.Models;

namespace WinFormsECF_SPA
{
    public partial class FormChat2 : Form
    {
        private Chat chatBDD;
        private ClassChat chat;
        private SpaContext dbContext;

        public FormChat2(ClassChat petitNouveau)
        {
            InitializeComponent();
            dbContext = new SpaContext();
            dbContext.Chats.Load();
            dbContext.Races.Load();

            comboBoxRace.DataSource = dbContext.Races.Local.ToBindingList();
            comboBoxRace.ValueMember = "Race1";


            // chat issue de l'entity 
            chat = petitNouveau;

            // chat chargé depuis la Bdd par son numero puce (id)
            chatBDD = findFromId(chat.PuceNumber);

            textBoxPuceNumber.Text = chat.PuceNumber.ToString();
            textBoxName.Text = chat.Name;
            numericUpDownAge.Value = (int)chat.Age;

        }
        //verification de l'existance du chat du model
        private Chat? findFromId(Int64 _puceNumber)
        {
            return dbContext.Chats.Find(_puceNumber);
        }
        private void textBoxPuceNumber_TextChanged(object sender, EventArgs e)
        {
            if (!ClassLibraryControl.Controls.VerifIdentifiantPuce(textBoxPuceNumber.Text))
            {
                errorProviderPuceNumber.SetError(textBoxPuceNumber, "veuillez saisir un identifiant à 15 chiffres commencant par 25026");
            }

            else
            {
                errorProviderPuceNumber.Clear();
            }
        }
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (!ClassLibraryControl.Controls.CheckName(textBoxName.Text))
            {
                errorProviderNom.SetError(textBoxName, "veuillez saisir des lettres");
            }
            else
            {
                errorProviderNom.Clear();
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nUpDo = sender as NumericUpDown;
            chat.CheckAge((int)nUpDo.Value);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //modifier l'object modifier

            if (textBoxName != null)
            {
                chat.Name = textBoxName.Text;
            }
            if (numericUpDownAge.Value != null)
            {
                chat.Age = (int)numericUpDownAge.Value;
            }
            if (comboBoxRace.SelectedItem != null)
            {
                chat.Race = (int)comboBoxRace.SelectedIndex + 1;
            }

            chatBDD.Nom = chat.Name;
            chatBDD.Age = chat.Age;
            chatBDD.Race = (int)chat.Race;
            dbContext.SaveChanges();
        }
    }
}
