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

        public Defilement()
        {
            InitializeComponent();
            remplissageTextBoxReference();
            maCouleur = Color.Brown;
            mettreAJourIHM(maCouleur);
        }

        public Defilement(Color couleurAModifier)
        {
            InitializeComponent();
            remplissageTextBoxReference();
            maCouleur = couleurAModifier;
            mettreAJourIHM(maCouleur);
        }

        private void remplissageTextBoxReference()
        {
            textBoxRouge.BackColor = Color.Red;
            textBoxVert.BackColor = Color.Green;
            textBoxBleu.BackColor = Color.Blue;
        }

        private void numericUpDownRouge_ValueChanged(object sender, EventArgs e)
        {
            maCouleur = Color.FromArgb(int.Parse(numericUpDownRouge.Text), maCouleur.G,maCouleur.B);
            mettreAJourIHM(maCouleur);
        }

        private void numericUpDownVert_ValueChanged(object sender, EventArgs e)
        {
            maCouleur = Color.FromArgb(maCouleur.R, int.Parse(numericUpDownVert.Text), maCouleur.B);
            mettreAJourIHM(maCouleur);
        }

        private void numericUpDownBleu_ValueChanged(object sender, EventArgs e)
        {
            maCouleur = Color.FromArgb(maCouleur.R, maCouleur.G, int.Parse(numericUpDownBleu.Text));
            mettreAJourIHM(maCouleur);
        }

        private void hScrollBarRouge_Scroll(object sender, ScrollEventArgs e)
        {
            maCouleur = Color.FromArgb(hScrollBarRouge.Value, maCouleur.G, maCouleur.B);
            mettreAJourIHM(maCouleur);
        }

        private void hScrollBarVert_Scroll(object sender, ScrollEventArgs e)
        {
            maCouleur = Color.FromArgb(maCouleur.R, hScrollBarVert.Value, maCouleur.B);
            mettreAJourIHM(maCouleur);
        }

        private void hScrollBarBleu_Scroll(object sender, ScrollEventArgs e)
        {
            maCouleur = Color.FromArgb(maCouleur.R, maCouleur.G, hScrollBarBleu.Value);
            mettreAJourIHM(maCouleur);
        }

        private void mettreAJourIHM(Color _couleur)
        {
            hScrollBarRouge.Value = int.Parse(_couleur.R.ToString());
            hScrollBarVert.Value = int.Parse(_couleur.G.ToString());
            hScrollBarBleu.Value = int.Parse(_couleur.B.ToString());
            numericUpDownRouge.Text = _couleur.R.ToString();
            numericUpDownVert.Text = _couleur.G.ToString();
            numericUpDownBleu.Text = _couleur.B.ToString();
            textBoxCouleur.BackColor = Color.FromArgb((int)_couleur.R, (int)_couleur.G, (int)_couleur.B);
        }
    }
}
