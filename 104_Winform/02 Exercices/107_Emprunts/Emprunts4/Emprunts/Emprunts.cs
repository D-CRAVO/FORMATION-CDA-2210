using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryCalculs;
using ClassLibraryControles;

namespace Emprunts
{
    public partial class Emprunts : Form
    {
        private double capitalEmprunte;
        private double tauxAnnuel;
        private int nbMois;
        private string periodicite;
        private int nbRemboursements;
        private double tauxSaisi;
        private double tauxRemboursements;

        public Emprunts()
        {
            InitializeComponent();

            capitalEmprunte = 1;
            tauxAnnuel = 0.07;
            nbMois = 1;
            periodicite = "Mensuelle";

            hScrollBarDuree.Value = nbMois;
            listBoxPeriodicite.SelectedItem = periodicite;
            checkTauxSaisi();
            //ihm();
        }

        public Emprunts(double _capitalEmprunte, double _tauxAnnuel, int _nbMois, string _periodicite)
        {
            InitializeComponent();

            capitalEmprunte = _capitalEmprunte;
            tauxAnnuel = _tauxAnnuel;
            nbMois = _nbMois;
            periodicite = _periodicite;

            hScrollBarDuree.Value = nbMois;
            listBoxPeriodicite.SelectedItem = periodicite;
            checkTauxSaisi();
            ihm();
        }

        private void determinationCapitalEmprunte()
        {

        }

        #region Taux d'intérêt

        /// <summary>
        /// Activation des checkBox des taux en fonction du constructeur;
        /// </summary>
        private void checkTauxSaisi()
        {
            if (tauxAnnuel == 0.07)
            {
                radioButton7.Checked = true;
            }
            else if (tauxAnnuel == 0.08)
            {
                radioButton8.Checked = true;
            }
            else
            {
                radioButton9.Checked = true;
            }
        }

        /// <summary>
        /// Détermine le taux d'intérêt annuel en fonction de la checkBox activée
        /// </summary>
        private void determinationTauxSaisi()
        {
            if (radioButton7.Checked == true)
            {
                tauxSaisi = 0.07;
            }
            else if (radioButton8.Checked == true)
            {
                tauxSaisi = 0.08;
            }
            else
            {
                tauxSaisi = 0.09;
            }
        }
        #endregion

        #region Periodicite de remboursement

        /// <summary>
        /// Détermine la périodicité de remboursement
        /// </summary>
        private void determinationHScrollBarDureeSmallChange()
        {
            if (listBoxPeriodicite.SelectedItem.ToString() == "Mensuelle")
            {
                hScrollBarDuree.SmallChange = 1;
                periodicite = "Mensuelle";
            }
            else if (listBoxPeriodicite.SelectedItem.ToString() == "Bimestrielle")
            {
                hScrollBarDuree.SmallChange = 2;
                periodicite = "Bimestrielle";
            }
            else if (listBoxPeriodicite.SelectedItem.ToString() == "Trimestrielle")
            {
                hScrollBarDuree.SmallChange = 3;
                periodicite = "Trimestrielle";
            }
            else if (listBoxPeriodicite.SelectedItem.ToString() == "Semestrielle")
            {
                hScrollBarDuree.SmallChange = 6;
                periodicite = "Semestrielle";
            }
            else
            {
                hScrollBarDuree.SmallChange = 12;
                periodicite = "Annuelle";
            }
        }
        #endregion

        private void ihm()
        {
            textBoxCapitalEmprunte.Text = capitalEmprunte.ToString();
            
            determinationTauxSaisi();
            determinationHScrollBarDureeSmallChange();
            textBoxDuree.Text = hScrollBarDuree.Value.ToString();
            nbRemboursements = Calculs.calculNbRemboursements(periodicite, hScrollBarDuree.Value);
            textBoxNbRemboursements.Text = nbRemboursements.ToString();
            tauxRemboursements = Calculs.calculTauxRemboursements(tauxSaisi, periodicite);
            textBoxRemboursements.Text = Math.Round(Calculs.calculRemboursements(capitalEmprunte, tauxRemboursements, nbRemboursements), 2).ToString();
        }

        private void hScrollBarDuree_Scroll(object sender, ScrollEventArgs e)
        {
            //ihm();
        }

        private void listBoxPeriodicite_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ihm();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            ihm();
        }
    }
}
