using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAddition
{
    public partial class FormAddition : Form
    {
        public FormAddition()
        {
            InitializeComponent();
        }

        private void buttonDisBonjour_Click(object sender, EventArgs e)
        {
            this.textBoxAddittionner.Text += "Dis bonjour ! \r\n";
        }

        private void FormAddition_Load(object sender, EventArgs e)
        {

        }

        private void BoutonResizeDisBonjour_Click(object sender, EventArgs e)
        {
            this.buttonDisBonjour.Size = new System.Drawing.Size(100, 100);
        }
    }
}
