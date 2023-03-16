using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emprunts
{
    public partial class Emprunts : Form
    {
        private double k;
        private double t;
        private double n;
        private int periodicite;

        public Emprunts()
        {
            InitializeComponent();
        }

        public void initialisationValeurs()
        {
            textBoxCapitalEmprunte.Text = "150000";
            hScrollBarDuree.Value = 120;
            textBoxDuree.Text = hScrollBarDuree.Value.ToString();

        }

        private void calculMensualites()
        {

        }

        private void hScrollBarDuree_Scroll(object sender, ScrollEventArgs e)
        {
            textBoxDuree.Text = hScrollBarDuree.Value.ToString();
            calculMensualites();
        }
    }
}
