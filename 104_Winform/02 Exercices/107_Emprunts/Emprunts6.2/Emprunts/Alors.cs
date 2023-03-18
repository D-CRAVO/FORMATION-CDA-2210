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
    public partial class Alors : Form
    {
        public Alors()
        {
            InitializeComponent();
        }

        private void buttonOui_Click(object sender, EventArgs e)
        {
            Hourra monHourra = new Hourra();
            monHourra.ShowDialog();
        }

        private void buttonNon_Click(object sender, EventArgs e)
        {
            Mince monMince = new Mince();
            monMince.ShowDialog();
        }

        //private void Alors_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    e.Cancel = true;
        //}

    }
}
