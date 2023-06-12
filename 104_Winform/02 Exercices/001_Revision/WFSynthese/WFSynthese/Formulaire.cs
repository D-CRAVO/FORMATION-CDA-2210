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
        Emprunt empruntDepart;
        public Formulaire()
        {
            InitializeComponent();
            empruntDepart = new Emprunt();
            Affichage(empruntDepart);
        }

        public Formulaire(Emprunt _emprunt)
        {
            InitializeComponent();
            empruntDepart = _emprunt;
            empruntEtude = new Emprunt(empruntDepart);
            Affichage(empruntEtude);
        }

        private void Affichage(Emprunt _emprunt)
        {
            textBoxNom.Text = _emprunt.Nom;
            textBoxCapital.Text = _emprunt.Capital.ToString();
            hScrollBarDuree.Value = (int)_emprunt.Duree;
            textBoxDuree.Text = hScrollBarDuree.Value.ToString();
            listBoxPeriodicite.SelectedItem = _emprunt.Periodicite;
            CheckTaux(_emprunt);
            CheckPeriodicite(_emprunt);
            textBoxNbRemboursements.Text = Emprunt.CalculNbRemboursements(_emprunt).ToString();
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

        private void CheckPeriodicite(Emprunt _emprunt)
        {
            //if (listBoxPeriodicite.SelectedIndex)
            //{

            //}

            switch (_emprunt.Periodicite)
            {
                case Emprunt.EnumPeriodicite.Mensuelle:
                    listBoxPeriodicite.SelectedIndex = 0;
                    break;
                case Emprunt.EnumPeriodicite.Bimestrielle:
                    listBoxPeriodicite.SelectedIndex = 1;
                    break;
                case Emprunt.EnumPeriodicite.Trimestrielle:
                    listBoxPeriodicite.SelectedIndex = 2;
                    break;
                case Emprunt.EnumPeriodicite.Semestrielle:
                    listBoxPeriodicite.SelectedIndex = 3;
                    break;
                default:
                    listBoxPeriodicite.SelectedIndex = 4;
                    break;
            }
        }


        private void listBoxPeriodicite_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(listBoxPeriodicite.SelectedIndex == 0)
            //{
            //    empruntEtude.Periodicite = Emprunt.EnumPeriodicite.Mensuelle;
            //}
            switch (listBoxPeriodicite.SelectedIndex)
            {
                case 0:
                    empruntEtude.Periodicite = Emprunt.EnumPeriodicite.Mensuelle;
                    hScrollBarDuree.SmallChange = (int)Emprunt.EnumPeriodicite.Mensuelle;
                    InitialisationDuree();
                    break;
                case 1:
                    empruntEtude.Periodicite = Emprunt.EnumPeriodicite.Bimestrielle;
                    hScrollBarDuree.SmallChange = (int)Emprunt.EnumPeriodicite.Bimestrielle;
                    InitialisationDuree();
                    break;
                case 2:
                    empruntEtude.Periodicite = Emprunt.EnumPeriodicite.Trimestrielle;
                    hScrollBarDuree.SmallChange = (int)Emprunt.EnumPeriodicite.Trimestrielle;
                    InitialisationDuree();
                    break;
                case 3:
                    empruntEtude.Periodicite = Emprunt.EnumPeriodicite.Semestrielle;
                    hScrollBarDuree.SmallChange = (int)Emprunt.EnumPeriodicite.Semestrielle;
                    InitialisationDuree();
                    break;
                default:
                    empruntEtude.Periodicite = Emprunt.EnumPeriodicite.Annuelle;
                    hScrollBarDuree.SmallChange = (int)Emprunt.EnumPeriodicite.Annuelle;
                    InitialisationDuree();
                    break;
            }
            Affichage(empruntEtude);
        }

        private void InitialisationDuree()
        {
            empruntEtude.Duree = empruntDepart.Duree;
            Affichage(empruntEtude);
        }

        private void Formulaire_Load(object sender, EventArgs e)
        {

        }

        private void hScrollBarDuree_Scroll(object sender, ScrollEventArgs e)
        {
            empruntEtude.Duree = uint.Parse(hScrollBarDuree.Value.ToString());
            Affichage(empruntEtude);
        }
    }
}
