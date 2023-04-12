using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFDelegate
{
    public partial class FormDelegate : Form
    {
        public FormDelegate()
        {
            InitializeComponent();
        }

        private void FormDelegate_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void buttonChatouiller_Click(object sender, EventArgs e)
        {
            // Modal
            FormPewPew formPewPew = new FormPewPew();
            DialogResult dialogResult = formPewPew.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                MessageBox.Show($"Bonjour {formPewPew.NomPewPew}");
            }
        }

        private void buttonChatouiller2_Click(object sender, EventArgs e)
        {
            // Non Modal
            FormPewPew p = new FormPewPew();
            p.Show();
            p.FormClosed += P_FormClosed;
            MessageBox.Show($"Bonjour {p.NomPewPew}");
        }

        private void P_FormClosed(object? sender, FormClosedEventArgs e)
        {
            FormPewPew? p = sender as FormPewPew;
            if (p != null)
            {
                MessageBox.Show($"Bonjour {p.NomPewPew}");
            }
        }
    }
}
