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
        public Formulaire()
        {
            InitializeComponent();
        }

        public Formulaire(Emprunt _emprunt)
        {
            InitializeComponent();
            InitialisationFormulaire(_emprunt);
        }

        private void InitialisationFormulaire(Emprunt _emprunt)
        {

        }

        private void Affichage()
        {

        }

        private void listBoxPeriodicite_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Formulaire_Load(object sender, EventArgs e)
        {

        }
    }
}
