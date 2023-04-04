using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCoursUsersControles
{
    public partial class FormProgressBar : Form
    {
        public FormProgressBar()
        {
            InitializeComponent();
        }

        private void ucProgressBar1_MaximumProgressReached(object sender, EventArgs e)
        {
            MessageBox.Show("C'est la fin de la barre");
        }
    }
}
