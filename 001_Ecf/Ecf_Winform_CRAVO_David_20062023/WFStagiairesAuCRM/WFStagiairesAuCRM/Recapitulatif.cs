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

namespace WFStagiairesAuCRM
{
    public partial class Recapitulatif : Form
    {
        private string annee;

        public Recapitulatif()
        {
            InitializeComponent();
        }

        public Recapitulatif(Stagiaire stagiaire)
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.Green;
            labelSection.Text += calculNomSection(stagiaire);
        }

        private string calculNomSection(Stagiaire stagiaire)
        {
            annee = stagiaire.DateDebut.Year.ToString();

            return stagiaire.Section + annee;
        }
    }
}
