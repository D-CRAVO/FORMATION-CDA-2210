using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DefilementCouleurs
{
    public partial class Defilement : Form
    {

        private System.Drawing.Color maCouleur; 

        private int rouge;
        private int vert;
        private int bleu;
        public Defilement()
        {
            InitializeComponent();
            initialisationTextBoxCouleur();
            textBoxRouge.BackColor = Color.FromArgb(255, 0, 0);
            textBoxVert.BackColor = Color.FromArgb(0, 255, 0);
            textBoxBleu.BackColor = Color.FromArgb(0, 0, 255);

            //mettre un macouleutParDefault
            //MettreAJourIHM();
        }

        public Defilement(Color couleurAModifier)
        {
            InitializeComponent();
            maCouleur = couleurAModifier;
            //MettreAJourIHM();
        }

        private void initialisationTextBoxCouleur()
        {
            rouge = int.Parse(numericUpDownRouge.Text);
            vert = int.Parse(numericUpDownVert.Text);
            bleu = int.Parse(numericUpDownBleu.Text);
            textBoxCouleur.BackColor = Color.FromArgb(rouge, vert, bleu);
        }

        private void numericUpDownRouge_ValueChanged(object sender, EventArgs e)
        {
            hScrollBarRouge.Value = int.Parse(numericUpDownRouge.Text);
            initialisationTextBoxCouleur();

            //macouleur= Color.FromRGB(hScrollBarRouge.Value,macouleur.G,macouleur.B);
            //MettreAJourIHM();
        }

        private void numericUpDownVert_ValueChanged(object sender, EventArgs e)
        {
            hScrollBarVert.Value = int.Parse(numericUpDownVert.Text);
            initialisationTextBoxCouleur();
        }

        private void numericUpDownBleu_ValueChanged(object sender, EventArgs e)
        {
            hScrollBarBleu.Value = int.Parse(numericUpDownBleu.Text);
            initialisationTextBoxCouleur();
        }

        private void hScrollBarRouge_Scroll(object sender, ScrollEventArgs e)
        {
            numericUpDownRouge.Text = hScrollBarRouge.Value.ToString();
            initialisationTextBoxCouleur();
        }

        private void hScrollBarVert_Scroll(object sender, ScrollEventArgs e)
        {
            numericUpDownVert.Text = hScrollBarVert.Value.ToString();
            initialisationTextBoxCouleur();
        }

        private void hScrollBarBleu_Scroll(object sender, ScrollEventArgs e)
        {
            numericUpDownBleu.Text = hScrollBarBleu.Value.ToString();
            initialisationTextBoxCouleur();
        }
    }
}
