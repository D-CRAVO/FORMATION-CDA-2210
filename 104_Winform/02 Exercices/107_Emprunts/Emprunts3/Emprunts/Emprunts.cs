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

            checkTauxSaisi();
            IHM();
        }

        public Emprunts(double _capitalEmprunte, double _tauxAnnuel, int _nbMois, string _periodicite)
        {
            InitializeComponent();

            capitalEmprunte = _capitalEmprunte;
            tauxAnnuel = _tauxAnnuel;
            nbMois = _nbMois;
            periodicite = _periodicite;

            checkTauxSaisi();
            IHM();
        }

        private void determinationMontant()
        {

        }

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

        public void determinationTauxSaisi()
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

        private void hScrollBarDuree_Scroll(object sender, ScrollEventArgs e)
        {
            IHM();
        }

        private void IHM()
        {
            hScrollBarDuree.Value = nbMois;
            textBoxDuree.Text = hScrollBarDuree.Value.ToString();
            listBoxPeriodicite.SelectedItem = periodicite;
            nbRemboursements = Calculs.calculNbRemboursements(periodicite, hScrollBarDuree.Value);
            textBoxNbRemboursements.Text = nbRemboursements.ToString();
            determinationTauxSaisi();
            tauxRemboursements = Calculs.calculTauxRemboursements(tauxSaisi, periodicite);
            textBoxRemboursements.Text = Math.Round(Calculs.calculRemboursements(capitalEmprunte, tauxRemboursements, nbRemboursements),2).ToString();
        }
    }
}
