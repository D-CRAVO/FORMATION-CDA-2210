using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFDefilementCouleurs
{
    public partial class FormDefilementCouleurs : Form
    {
        Color myColor;

        public FormDefilementCouleurs()
        {
            InitializeComponent();
            Affichage(myColor.R, myColor.G, myColor.B);
        }

        public FormDefilementCouleurs(Color color)
        {
            InitializeComponent();
            InitializeComponent2(color);
        }

        private void InitializeComponent2(Color color)
        {
            numericUpDownRouge.Value = color.R;
            numericUpDownVert.Value = color.G;
            numericUpDownBleu.Value = color.B;
            hScrollBarRouge.Value = color.R;
            hScrollBarVert.Value = color.G;
            hScrollBarBleu.Value = color.B;
            Affichage(color.R, color.G, color.B);
        }

        private void Affichage(int colorRed, int colorGreen, int colorBlue)
        {
            textBoxCouleurs.BackColor = Color.FromArgb(colorRed, colorGreen, colorBlue);
        }

        private void hScrollBarRouge_Scroll(object sender, ScrollEventArgs e)
        {
            numericUpDownRouge.Value = (int)hScrollBarRouge.Value;
            Affichage(hScrollBarRouge.Value, myColor.G, myColor.B);
        }

        private void hScrollBarVert_Scroll(object sender, ScrollEventArgs e)
        {
            numericUpDownVert.Value = (int)hScrollBarVert.Value;
            Affichage(myColor.R, hScrollBarVert.Value, myColor.B);
        }

        private void hScrollBarBleu_Scroll(object sender, ScrollEventArgs e)
        {
            numericUpDownBleu.Value = (int)hScrollBarBleu.Value;
            Affichage(myColor.R, myColor.G, hScrollBarBleu.Value);
        }
    }
}
