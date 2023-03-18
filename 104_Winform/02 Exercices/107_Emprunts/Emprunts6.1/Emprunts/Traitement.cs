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
    public partial class Traitement : Form
    {
        public Traitement()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 101; i++) 
            { 
                progressBarTraitement.Value = i;
            }
        }
    }
}
