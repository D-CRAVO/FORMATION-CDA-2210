using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFSpa.Data;
using WFSpa.Models;
using CLSpa;

namespace WFSpa
{
    public partial class FormSpa : Form
    {
        SpaContext dbContext;
        Chat chat;
        public FormSpa()
        {
            InitializeComponent();
            dbContext = new SpaContext();
            dbContext.Chats.Load();
            comboBoxPuce.DataSource = dbContext.Chats.Local.ToBindingList();
            comboBoxPuce.ValueMember = "NumeroPuce";
            InitializeComboBoxRace();
            InitializeForm();

        }

        private void InitializeComboBoxRace()
        {
            foreach (EnumRace item in Enum.GetValues(typeof(EnumRace)))
            {
                comboBoxRace.Items.Add(item);
            }

        }

        private void InitializeForm()
        {
            chat = dbContext.Chats.Find(250260111111111);
            chat = dbContext.Chats.Find(comboBoxPuce.SelectedValue);
            textBoxName.Text = chat.Nom;
            numericUpDownAge.Text = chat.Age.ToString();
            comboBoxRace.Text = ConversionValeurRace(chat.Race);
        }

        private string ConversionValeurRace(int _race)
        {
            string result = String.Empty;
            switch (_race)
            {
                case (int)EnumRace.Abyssin:
                    result = EnumRace.Abyssin.ToString();
                    break;
                case (int)EnumRace.Europeen:
                    result = EnumRace.Europeen.ToString();
                    break;
                case (int)EnumRace.MaineCoon:
                    result = EnumRace.MaineCoon.ToString();
                    break;
                case (int)EnumRace.Sphynx:
                    result = EnumRace.Sphynx.ToString();
                    break;
            }
            return result;
        }

        private int ConversionRaceValeur(string _race)
        {
            int result = 1;
            string result2 = EnumRace.Abyssin.ToString();
            switch (_race)
            {
                case "Abyssin":
                    result = (int)EnumRace.Abyssin;
                    break;
                case "Europeen":
                    result = (int)EnumRace.Europeen;
                    break;
                case "MaineCoon":
                    result = (int)EnumRace.MaineCoon;
                    break;
                case "Sphynx":
                    result = (int)EnumRace.Sphynx;
                    break;
            }
            return result;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Cat cat = new Cat
                (
                    long.Parse(comboBoxPuce.Text),
                    textBoxName.Text,
                    int.Parse(numericUpDownAge.Value.ToString()),
                    ConversionRaceValeur(comboBoxRace.Text)
                );
            Chat chat = new Chat();
            chat = dbContext.Chats.Find(comboBoxPuce.SelectedValue);
            chat.Nom = cat.Name;
            chat.Age = cat.Age;
            chat.Race = cat.Race;
            dbContext.Chats.Update(chat);
            dbContext.SaveChanges();
        }

        private void comboBoxPuce_SelectedIndexChanged(object sender, EventArgs e)
        {
            //InitializeForm();
            var result = comboBoxPuce.SelectedIndex;
            var result2 = comboBoxPuce.SelectedText;
            var result3 = comboBoxPuce.SelectedValue;
        }
    }
}
