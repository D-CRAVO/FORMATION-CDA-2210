using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsEmprunts
{
    public partial class FormHourra : Form
    {
        int temps;
        public FormHourra()
        {
            InitializeComponent();
            timerHourra.Start();
            temps = 15;
        }

        private void FormHourra_Load(object sender, EventArgs e)
        {
            
        }

        private void timerHourra_Tick(object sender, EventArgs e)
        {
            temps--;
            if (temps <= 0)
            {
                timerHourra.Stop();
                Close();
            }
        }
    }
}
