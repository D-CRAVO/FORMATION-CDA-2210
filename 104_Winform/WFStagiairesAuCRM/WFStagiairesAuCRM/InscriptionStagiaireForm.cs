using CLStagiaires;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CLStagiaires.Stagiaire;

namespace WFStagiairesAuCRM
{
    public partial class InscriptionStagiaireForm : Form
    {
        private Stagiaire stagiaire;
        public InscriptionStagiaireForm()
        {
            InitializeComponent();
            listBoxFormation.SetSelected(0, true);
        }

        public InscriptionStagiaireForm(Stagiaire _stagiaire)
        {
            InitializeComponent();
            Affichage(_stagiaire);
        }

        public void Affichage(Stagiaire _stagiaire)
        {
            textBoxNom.Text = _stagiaire.Nom;
            textBoxPrenom.Text = _stagiaire.Prenom;
            textBoxDateDebut.Text = _stagiaire.DateDebut.ToString();
            textBoxDateFin.Text = _stagiaire.DateFin.ToString();
            listBoxFormation.SetSelected((int)(_stagiaire.Section), true);
        }

        public EnumSection CheckSection()
        {
            if (listBoxFormation.SelectedIndex == 0)
            {
                return EnumSection.ABC;
            }
            else if (listBoxFormation.SelectedIndex == 1)
            {
                return EnumSection.DWWM;
            }
            else
            {
                return EnumSection.CDA;
            }
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {

            if (
                CLControles.Controle.ControleNom(textBoxNom.Text)
                && CLControles.Controle.ControleNom(textBoxPrenom.Text)
                && CLControles.Controle.ControleDate(textBoxDateDebut.Text)
                && CLControles.Controle.ControleDate(textBoxDateFin.Text)
                )
            {
                errorProviderNom.SetError(textBoxNom, string.Empty);
                errorProviderPrenom.SetError(textBoxPrenom, string.Empty);
                errorProviderDateDebut.SetError(textBoxDateDebut, string.Empty);
                DateOnly dateDebut = DateOnly.Parse(textBoxDateDebut.Text);
                DateOnly dateFin = DateOnly.Parse(textBoxDateFin.Text);
                if (dateFin > dateDebut)
                {
                    stagiaire = new Stagiaire(
                        textBoxNom.Text,
                        textBoxPrenom.Text,
                        dateDebut,
                        dateFin,
                        CheckSection()
                        );

                    errorProviderDateFin.SetError(textBoxDateFin, string.Empty);

                    Recapitulatif recapitulatif = new Recapitulatif(stagiaire);
                    recapitulatif.ShowDialog();

                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Saisie incorrecte", "Erreur", MessageBoxButtons.OK);
                    // errorProviderDateFin.SetError(textBoxDateFin, "La date de fin de formation doit être supérieure à la date de début de formation.");
                }
            }
            else
            {
                //if (!CLControles.Controle.ControleNom(textBoxNom.Text))
                //{
                //    errorProviderNom.SetError(textBoxNom, "Nom invalide !");
                //}
                //else if (!CLControles.Controle.ControleNom(textBoxPrenom.Text))
                //{
                //    errorProviderPrenom.SetError(textBoxPrenom, "Prénom invalide !");
                //}
                //else if (!CLControles.Controle.ControleDate(textBoxDateDebut.Text))
                //{
                //    errorProviderDateDebut.SetError(textBoxDateDebut, "Date invalide !");

                //}
                //else if (!CLControles.Controle.ControleDate(textBoxDateFin.Text))
                //{
                //    errorProviderDateDebut.SetError(textBoxDateFin, "Date invalide !");
                //}
                DialogResult dialogResult  = MessageBox.Show("Saisie incorrecte", "Erreur", MessageBoxButtons.OK);
            }
        }

        private void buttonEffacer_Click(object sender, EventArgs e)
        {
            textBoxNom.Clear();
            textBoxPrenom.Clear();
            textBoxDateFin.Clear();
            textBoxDateDebut.Clear();
            listBoxFormation.SetSelected(0, true);
        }
    }
}
