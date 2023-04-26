using CLSpa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECF_SPA.Models;
using ECF_SPA.Data;
using Microsoft.EntityFrameworkCore;

namespace ECF_SPA
{
    public partial class FormChat : Form
    {
        SpaContext dbContext;
        public FormChat()
        {
            InitializeComponent();
        }

        public FormChat(ECF_SPA.Models.Chat _chat, SpaContext _dbContext)
        {

            InitializeComponent();
            InitializeForm(_chat);

            dbContext = _dbContext;
            dbContext.Chats.Load();
            dataGridViewChats.DataSource = dbContext.Chats.Local.ToBindingList();
            //comboBoxPuce.DataSource = dbContext.Chats.Local.ToBindingList();

        }

        private void InitializeForm(ECF_SPA.Models.Chat _chat)
        {
            comboBoxPuce.Text = _chat.NumeroPuce.ToString();
            textBoxNom.Text = _chat.Nom.ToString();
            numericUpDownAge.Text = _chat.Age.ToString();
            comboBoxRace.Text = conversionValeurRace(_chat.Race); ;
        }


        private string conversionValeurRace(int _codeRace)
        {
            string race = string.Empty;
            switch (_codeRace)
            {
                case 1:
                    race = $"{EnumRace.Abyssin}";
                    break;
                case 2:
                    race = $"{EnumRace.Europeen}";
                    break;
                case 3:
                    race = $"{EnumRace.MaineCoon}";
                    break;
                case 4:
                    race = $"{EnumRace.Sphynx}";
                    break;
            }
            return race;
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
           
        }
    }
}
