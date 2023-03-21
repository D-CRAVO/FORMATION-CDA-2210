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
    public partial class FormMince : Form
    {
        Random random = new Random();
        int temps;
        public FormMince()
        {
            temps = 15;
            InitializeComponent();
            timerMince.Start();
        }

        private void timerMince_Tick(object sender, EventArgs e)
        {
            temps--;
            if (temps <= 0)
            {
                timerMince.Stop();
                Close();
            }

        }

        private void FormMince_Load(object sender, EventArgs e)
        {
            var image = imageListMince.Images;
            foreach(var img in image)
            {
                random = new Random();
                pictureBoxMince.Image = imageListMince.Images[random.Next(0, 1)];
            }
        }
    }
}
