using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emprunts
{
    public partial class Traitement : Form
    {
        /// <summary>
        /// Variable qui va servir à faire progresser la progressBar
        /// </summary>
        int temps;

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Traitement()
        {
            InitializeComponent();
            timerTraitement.Start();
        }

        /// <summary>
        /// Timer qui va gérer la progression de la barre 
        /// et rendre le bouton de fermeture de la fenêtre visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            temps++;
            progressBarTraitement.Value = temps;
            if (temps == 100)
            {
                timerTraitement.Stop();
                buttonFermer.Visible = true;
            }
        }

        /// <summary>
        /// Bouton initialement caché qui ferme la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Renvoie vers la fenêtre "Alors" 
        /// quand on veut utiliser la croix de fermeture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Traitement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Alors monAlors = new Alors();
            monAlors.ShowDialog();
        }
    }
}
