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
    public partial class Hourra : Form
    {
        int temps;
        public Hourra()
        {
            temps = 15;
            InitializeComponent();
            timerHourra.Start();
        }

        private void timerHourra_Tick(object sender, EventArgs e)
        {
            temps--;
            if (temps < 0)
            {
                timerHourra.Stop();
                Close();
            }
        }
    }
}
