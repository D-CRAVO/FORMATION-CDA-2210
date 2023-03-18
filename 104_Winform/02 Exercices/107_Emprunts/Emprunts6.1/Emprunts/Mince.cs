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
    public partial class Mince : Form
    {
        Random monRandom;

        public Mince()
        {
            InitializeComponent();
        }

        private void Mince_Load(object sender, EventArgs e)
        {
            var image = imageListMince.Images;
            foreach (var imageItem in image)
            {
            }
        }

        private void timerMince_Tick(object sender, EventArgs e)
        {
            monRandom = new Random();
            pictureBoxMince.Image = imageListMince.Images[monRandom.Next(0,2)];
        }
    }
}
