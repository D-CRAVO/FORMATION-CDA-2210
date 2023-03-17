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

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Emprunts()
        {
            InitializeComponent();

            capitalEmprunte = 1;
            tauxAnnuel = 0.07;
            nbMois = 1;
            periodicite = "Mensuelle";

            //textBoxCapitalEmprunte.Text = capitalEmprunte.ToString();
            //hScrollBarDuree.Value = nbMois;
            listBoxPeriodicite.SelectedItem = periodicite;
            checkTauxSaisi();
            ihm(capitalEmprunte, tauxAnnuel, nbMois, periodicite);
        }

        /// <summary>
        /// Constructeur classique
        /// </summary>
        /// <param name="_capitalEmprunte">Capital emprunté</param>
        /// <param name="_tauxAnnuel">Taux d'intérêt annuel</param>
        /// <param name="_nbMois">Nombre de mois de remboursements</param>
        /// <param name="_periodicite">Périodicité de remboursement</param>
        public Emprunts(double _capitalEmprunte, double _tauxAnnuel, int _nbMois, string _periodicite)
        {
            InitializeComponent();

            capitalEmprunte = _capitalEmprunte;
            tauxAnnuel = _tauxAnnuel;
            nbMois = _nbMois;
            periodicite = _periodicite;

            
            hScrollBarDuree.Value = nbMois;
            listBoxPeriodicite.SelectedItem = periodicite;
            textBoxCapitalEmprunte.Text = capitalEmprunte.ToString();
            checkTauxSaisi();
            ihm(capitalEmprunte, tauxAnnuel, nbMois, periodicite);
        }
        #endregion

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

        private void checkTauxInteret()
        {

        }

        private void ihm(double _capitalEmprunte, double _tauxAnnuel, int _nbMois, string _periodicite)
        {
            determinationTauxSaisi();
            determinationHScrollBarDureeSmallChange();
            hScrollBarDuree.Value = nbMois;
            //textBoxCapitalEmprunte.Text = capitalEmprunte.ToString();
            textBoxDuree.Text = nbMois.ToString();
            nbRemboursements = Calculs.calculNbRemboursements(periodicite, hScrollBarDuree.Value);
            textBoxNbRemboursements.Text = nbRemboursements.ToString();
            tauxRemboursements = Calculs.calculTauxRemboursements(tauxSaisi, periodicite);
            textBoxRemboursements.Text = Math.Round(Calculs.calculRemboursements(capitalEmprunte, tauxRemboursements, nbRemboursements), 2).ToString();
        }

        private void hScrollBarDuree_Scroll(object sender, ScrollEventArgs e)
        {
            nbMois = hScrollBarDuree.Value;
            ihm();
        }

        private void listBoxPeriodicite_SelectedIndexChanged(object sender, EventArgs e)
        {
            ihm();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {

            ihm();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            ihm();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            ihm();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            ihm();
        }

        private void listBoxPeriodicite_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ihm();
        }

        private void textBoxCapitalEmprunte_TextChanged(object sender, EventArgs e)
        {
            capitalEmprunte = double.Parse(textBoxCapitalEmprunte.Text.ToString());
            ihm();
        }
    }
}
