﻿using System;
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
        private uint capitalEmprunte;
        private double tauxAnnuel;
        private int nbMois;
        private string periodicite;
        private int nbRemboursements;
        private double tauxSaisi;
        private double tauxRemboursements;

        private uint capitalEmprunteEtude;
        private double tauxAnnuelEtude;
        private int nbMoisEtude;
        private string periodiciteEtude;

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

            initialisationDepart(capitalEmprunte, tauxAnnuel, nbMois, periodicite);

            ihm(capitalEmprunte, tauxAnnuel, nbMois, periodicite);
        }

        /// <summary>
        /// Constructeur classique
        /// </summary>
        /// <param name="_capitalEmprunte">Capital emprunté</param>
        /// <param name="_tauxAnnuel">Taux d'intérêt annuel</param>
        /// <param name="_nbMois">Nombre de mois de remboursements</param>
        /// <param name="_periodicite">Périodicité de remboursement</param>
        public Emprunts(uint _capitalEmprunte, double _tauxAnnuel, int _nbMois, string _periodicite)
        {
            InitializeComponent();

            capitalEmprunte = _capitalEmprunte;
            tauxAnnuel = _tauxAnnuel;
            nbMois = _nbMois;
            periodicite = _periodicite;

            initialisationDepart(capitalEmprunte, tauxAnnuel, nbMois, periodicite);

            ihm(capitalEmprunte, tauxAnnuel, nbMois, periodicite);
        }
        #endregion

        #region Taux d'intérêt

        /// <summary>
        /// Activation des checkBox des taux en fonction du constructeur;
        /// </summary>
        private void checkTauxSaisi(double _tauxAnnuel)
        {
            if (_tauxAnnuel == 0.07)
            {
                radioButton7.Checked = true;
            }
            else if (_tauxAnnuel == 0.08)
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
        private double determinationTauxSaisi()
        {
            if (radioButton7.Checked == true)
            {
                return 0.07;
            }
            else if (radioButton8.Checked == true)
            {
                return 0.08;
            }
            else
            {
                return 0.09;
            }
        }
        #endregion

        #region Periodicite de remboursement

        /// <summary>
        /// Détermine la périodicité de remboursement
        /// </summary>
        private string determinationHScrollBarDureeSmallChange(string _periodicite)
        {
            if (_periodicite == "Mensuelle")
            {
                hScrollBarDuree.SmallChange = 1;
                return "Mensuelle";
            }
            else if (_periodicite == "Bimestrielle")
            {
                hScrollBarDuree.SmallChange = 2;
                return "Bimestrielle";
            }
            else if (_periodicite == "Trimestrielle")
            {
                hScrollBarDuree.SmallChange = 3;
                return "Trimestrielle";
            }
            else if (_periodicite == "Semestrielle")
            {
                hScrollBarDuree.SmallChange = 6;
                return "Semestrielle";
            }
            else
            {
                hScrollBarDuree.SmallChange = 12;
                return "Annuelle";
            }
        }

        private void selectListBoxPeriodicite(string _periodicite)
        {
            if (_periodicite == "Mensuelle")
            {
                listBoxPeriodicite.SelectedItem = "Mensuelle";
            }
            else if (_periodicite == "Bimestrielle")
            {
                listBoxPeriodicite.SelectedItem = "Bimestrielle";
            }
            else if (_periodicite == "Trimestrielle")
            {
                listBoxPeriodicite.SelectedItem = "Trimestrielle";
            }
            else if (_periodicite == "Semestrielle")
            {
                listBoxPeriodicite.SelectedItem = "Semestrielle";
            }
            else
            {
                listBoxPeriodicite.SelectedItem = "Annuelle";
            }
        }
        #endregion

        private void initialisationDepart(uint _capitalEmprunte, double _tauxAnnuel, int _nbMois, string _periodicite)
        {
            textBoxCapitalEmprunte.Text = _capitalEmprunte.ToString();
            hScrollBarDuree.Value = _nbMois;
            selectListBoxPeriodicite(_periodicite);
            checkTauxSaisi(_tauxAnnuel);
            textBoxDuree.Text = _nbMois.ToString();
            
        }

        private void ihm(uint _capitalEmprunte, double _tauxAnnuel, int _nbMois, string _periodicite)
        {
            
            determinationHScrollBarDureeSmallChange(_periodicite);
            nbRemboursements = Calculs.calculNbRemboursements(_periodicite, _nbMois);
            textBoxNbRemboursements.Text = nbRemboursements.ToString();
            tauxRemboursements = Calculs.calculTauxRemboursements(_tauxAnnuel, _periodicite);
            textBoxRemboursements.Text = Math.Round(Calculs.calculRemboursements(_capitalEmprunte, tauxRemboursements, nbRemboursements), 2).ToString();
            sauvegardeValeursEtude(_capitalEmprunte, _tauxAnnuel, _nbMois, _periodicite);
            //Emprunts etude = new Emprunts(_capitalEmprunte, _tauxAnnuel, _nbMois, _periodicite);
        }

        private void sauvegardeValeursEtude(uint _capitalEmprunte, double _tauxAnnuel, int _nbMois, string _periodicite)
        {
            capitalEmprunteEtude = _capitalEmprunte;
            tauxAnnuelEtude = _tauxAnnuel;
            nbMoisEtude = _nbMois;
            periodiciteEtude = _periodicite;
        }

        private void listBoxPeriodicite_SelectedIndexChanged(object sender, EventArgs e)
        {
            string _periodicite = listBoxPeriodicite.SelectedItem.ToString();
            ihm(capitalEmprunteEtude, tauxAnnuelEtude, nbMoisEtude, _periodicite);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {

            ihm(capitalEmprunteEtude, tauxAnnuelEtude, nbMoisEtude, periodiciteEtude);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            double _tauxAnnuel = determinationTauxSaisi();
            ihm(capitalEmprunteEtude, _tauxAnnuel, nbMoisEtude, periodiciteEtude);
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            double _tauxAnnuel = determinationTauxSaisi();
            ihm(capitalEmprunteEtude, _tauxAnnuel, nbMoisEtude, periodiciteEtude);
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            double _tauxAnnuel = determinationTauxSaisi();
            ihm(capitalEmprunteEtude, _tauxAnnuel, nbMoisEtude, periodiciteEtude);
        }

        private void textBoxCapitalEmprunte_TextChanged(object sender, EventArgs e)
        {
            uint _capitalEmprunte = uint.Parse(textBoxCapitalEmprunte.Text);
            ihm(_capitalEmprunte, tauxAnnuelEtude, nbMoisEtude, periodiciteEtude);
        }

        private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            int _nbMois = hScrollBarDuree.Value;
            textBoxDuree.Text = _nbMois.ToString();
            ihm(capitalEmprunteEtude, tauxAnnuelEtude, _nbMois, periodiciteEtude);
        }
    }
}