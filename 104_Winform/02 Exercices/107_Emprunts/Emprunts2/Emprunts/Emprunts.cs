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
        private int nbRemboursements;
        private string periodicite;

        public Emprunts()
        {
            InitializeComponent();
            capitalEmprunte = 1;
            tauxAnnuel = 0.07;
            nbRemboursements = 1;
            periodicite = "Mensuelle";
            //textBoxDuree.Text = hScrollBarDuree.Value.ToString();
        }

        public Emprunts(double _capitalEmprunte, double _tauxAnnuel, int _nbRemboursements, string _periodicite)
        {
            InitializeComponent();
            capitalEmprunte = _capitalEmprunte;
            tauxAnnuel = _tauxAnnuel;
            nbRemboursements = _nbRemboursements;
            periodicite = _periodicite;
        }



        private void hScrollBarDuree_Scroll(object sender, ScrollEventArgs e)
        {
            textBoxDuree.Text = hScrollBarDuree.Value.ToString();
        }

        private void IHM()
        {
            textBoxNbMensualites.Text = Calculs.calculMensualites(periodicite, hScrollBarDuree.Value).ToString();
        }
    }
}
