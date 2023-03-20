using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emprunts
{
    public partial class Mince : Form
    {
        /// <summary>
        /// Variable qui va permettre l'affichage aléatoire de l'image
        /// </summary>
        Random monRandom;
        /// <summary>
        /// Variable qui va servir pour le compte à rebours
        /// </summary>
        int temps;

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Mince()
        {
            temps = 15;
            InitializeComponent();
            timerMince.Start();
        }

        /// <summary>
        /// Affiche uen image aléatoire le l'imageList à l'ouverture de la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mince_Load(object sender, EventArgs e)
        {
            var image = imageListMince.Images;
            foreach (var imageItem in image)
            {
                monRandom = new Random();
                pictureBoxMince.Image = imageListMince.Images[monRandom.Next(0, 4)];
            }
        }

        /// <summary>
        /// Effectue un compte à rebours afin de fermer automatiquement la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerMince_Tick(object sender, EventArgs e)
        {
            temps--;
            if (temps < 0)
            {
                timerMince.Stop();
                Close();
            }
        }
    }
}
