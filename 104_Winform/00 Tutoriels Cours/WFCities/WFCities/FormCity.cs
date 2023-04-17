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
using WFCities.Data;
using WFCities.Models;


namespace WFCities
{
    public partial class FormCity : Form
    {
        private Db301CitiesContext dbContext;
        public FormCity()
        {
            InitializeComponent();
            //Créer le context vers la source
            dbContext = new Db301CitiesContext();
            //Chargement de la table Cities
            dbContext.Cities.Load();

            //Realisation d'un binding entre la source de donnée Cities et le datagridview
            dataGridViewCities.DataSource = dbContext.Cities.Local.ToBindingList();
        }

        private void Trace(string message)
        {
            textBoxConsole.Text += $"----------------------- {message} ------------------------ {Environment.NewLine}";
            dbContext.ChangeTracker.DetectChanges();
            textBoxConsole.Text += dbContext.ChangeTracker.DebugView.LongView;
        }

        private void buttonAddCity_Click(object sender, EventArgs e)
        {
            City c = new City();
            c.CityName = "PewGraveCity";
            c.CountryCode = "US";

            Trace("Avant de l'avoir Add");
            dbContext.Cities.Add(c);
            Trace("Apres de l'avoir Add");

            dbContext.SaveChanges();
        }

        private void buttonDeleteCity1_Click(object sender, EventArgs e)
        {
            int id;
            bool idOk = int.TryParse(textBoxId.Text, out id);
            if (idOk)
            {
                City? cASupprimer = dbContext.Cities.Find(id);
                if (cASupprimer != null)
                {
                    dbContext.Cities.Remove(cASupprimer);
                    Trace("Apres l'avoir Remove");

                    dbContext.SaveChanges();
                    Trace("Apres avoir sauvegardé les changements: un DELETE à été réalisé sur la BD");
                }
            }
        }

        private void buttonModifyCity_Click(object sender, EventArgs e)
        {
            int id;
            bool idOk = int.TryParse(this.textBoxId.Text, out id);
            //string nouveauNom = this.textBoxNom.Text;
            if (idOk)
            {
                City? cAModifier = dbContext.Cities.Find(id);
                if (cAModifier != null)
                {
                    cAModifier.CityName = this.textBoxNom.Text;

                    dbContext.Cities.Update(cAModifier);
                    Trace("Apres l'avoir Modifier");

                    dbContext.SaveChanges();
                    Trace("Apres avoir sauvegardé les changements: un UPDATE à été réalisé sur la BD");
                }
            }
        }
    }
}
