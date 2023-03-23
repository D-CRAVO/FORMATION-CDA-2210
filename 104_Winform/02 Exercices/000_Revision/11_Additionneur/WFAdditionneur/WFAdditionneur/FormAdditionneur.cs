using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using CLCalcul;
using System.Net.NetworkInformation;

namespace WFAdditionneur
{
    public partial class FormAdditionneur : Form
    {
        Calcul? monAddition;
        int nb;
        string str;

        public FormAdditionneur()
        {
            InitializeComponent();
            monAddition = new Calcul(); 
            affichage(string.Empty);
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            nb = int.Parse((string)button.Tag);
            monAddition.enregistrerValeur(nb);
            affichage($"{nb}+");
        }

        private void buttonVider_Click(object sender, EventArgs e)
        {
            monAddition.initialiserValeurs();
            textBoxAffichage.Clear();
        }

        private void buttonCalculer_Click(object sender, EventArgs e)
        {
            affichage($" = {monAddition.addition()}+");
        }

        private void affichage(string _str)
        {
            textBoxAffichage.Text += _str;
        }
    }
}
