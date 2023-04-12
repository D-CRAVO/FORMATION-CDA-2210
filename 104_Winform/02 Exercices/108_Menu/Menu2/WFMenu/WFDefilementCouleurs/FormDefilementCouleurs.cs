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
        private Color myColor;

        public FormDefilementCouleurs()
        {
            InitializeComponent();
            remplissageTextBoxReference();
            myColor = Color.Chartreuse;
            Affichage(myColor);
        }

        public FormDefilementCouleurs(Color color)
        {
            InitializeComponent();
            remplissageTextBoxReference();
            myColor = color;
            Affichage(myColor);
        }

        private void remplissageTextBoxReference()
        {
            textBoxRouge.BackColor = Color.Red;
            textBoxVert.BackColor = Color.Green;
            textBoxBleu.BackColor = Color.Blue;
        }

        private void Affichage(int colorRed, int colorGreen, int colorBlue)
        {
            textBoxCouleurs.BackColor = Color.FromArgb(colorRed, colorGreen, colorBlue);
        }

        private void Affichage(Color _color)
        {
            numericUpDownRouge.Value = _color.R;
            numericUpDownVert.Value = _color.G;
            numericUpDownBleu.Value = _color.B;
            hScrollBarRouge.Value = _color.R;
            hScrollBarVert.Value = _color.G;
            hScrollBarBleu.Value = _color.B;
            textBoxCouleurs.BackColor = Color.FromArgb(_color.R, _color.G, _color.B);
        }

        private void hScrollBarRouge_Scroll(object sender, ScrollEventArgs e)
        {
            myColor = Color.FromArgb((int)hScrollBarRouge.Value, myColor.G, myColor.B);
            Affichage(myColor);
        }

        private void hScrollBarVert_Scroll(object sender, ScrollEventArgs e)
        {
            myColor = Color.FromArgb(myColor.R, (int)hScrollBarVert.Value, myColor.B);
            Affichage(myColor);
        }

        private void hScrollBarBleu_Scroll(object sender, ScrollEventArgs e)
        {
            myColor = Color.FromArgb(myColor.R, myColor.G, hScrollBarBleu.Value);
            Affichage(myColor);
        }

        private void numericUpDownRouge_ValueChanged(object sender, EventArgs e)
        {
            myColor = Color.FromArgb((int)numericUpDownRouge.Value, myColor.G, myColor.B);
            Affichage(myColor);
        }

        private void numericUpDownVert_ValueChanged(object sender, EventArgs e)
        {
            myColor = Color.FromArgb(myColor.R, (int)numericUpDownVert.Value, myColor.B);
            Affichage(myColor);
        }

        private void numericUpDownBleu_ValueChanged(object sender, EventArgs e)
        {
            myColor = Color.FromArgb(myColor.R, myColor.G, (int)numericUpDownBleu.Value);
            Affichage(myColor);
        }
    }
}
