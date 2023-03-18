using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emprunts
{
    public partial class Traitement : Form
    {
        int temps;
        public Traitement()
        {
            InitializeComponent();
            timerTraitement.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            temps++;
            progressBarTraitement.Value = temps;
            if (temps == 100)
            {
                timerTraitement.Stop();
                buttonFermer.Visible = true;
            }
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
