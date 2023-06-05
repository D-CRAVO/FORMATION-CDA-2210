using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLEmprunts;

namespace WFSynthese
{
    public partial class Formulaire : Form
    {
        Emprunt empruntEtude;
        public Formulaire()
        {
            InitializeComponent();
            Emprunt empruntDepart = new Emprunt();
            Affichage(empruntDepart);
        }

        public Formulaire(Emprunt _emprunt)
        {
            InitializeComponent();
            empruntEtude = new Emprunt(_emprunt);
            Affichage(empruntEtude);
        }

        private void Affichage(Emprunt _emprunt)
        {
            textBoxNom.Text = _emprunt.Nom;
            textBoxCapital.Text = _emprunt.Capital.ToString();
            hScrollBarDuree.Value = (int)_emprunt.Duree;
            listBoxPeriodicite.SelectedItem = _emprunt.Periodicite;
            CheckTaux(_emprunt);
            //textBoxNbRemboursements.Text = CalculNbRemboursements(_emprunt);
            //textBoxMontantRemboursements.Text = CalculMontantRemboursements(_emprunt);
        }

        private void CheckTaux(Emprunt _emprunt)
        {
            if (_emprunt.TauxAnnuel == 0.07f)
            {
                radioButton7.Checked = true;
            }
            else if (_emprunt.TauxAnnuel == 0.08f)
            {
                radioButton8.Checked = true;
            }
            else if (_emprunt.TauxAnnuel == 0.09f)
            {
                radioButton9.Checked = true;
            }
        }

        private void ChoosePeriodicite()
        {
            if (listBoxPeriodicite.SelectedIndex == 0)
            {
                
            }
        }


        private void listBoxPeriodicite_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Formulaire_Load(object sender, EventArgs e)
        {

        }
    }
}
