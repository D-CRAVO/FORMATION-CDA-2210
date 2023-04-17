using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAdditionneurR02
{
    public partial class FormAdditionneurR02 : Form
    {
        public FormAdditionneurR02()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            textBox1.Text += $"{b.Tag}+";
        }
    }
}
