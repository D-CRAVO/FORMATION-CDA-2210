using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace WinFormsEmprunts
{
    public partial class FormTraitement : Form
    {
        /// <summary>
        /// Variable qui va servir à faire progresser la progressBar
        /// </summary>
        int temps;

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public FormTraitement()
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
        private void timerTraitement_Tick(object sender, EventArgs e)
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
            FormAlors monAlors = new FormAlors();
            monAlors.ShowDialog();
            //Close();
        }

        /// <summary>
        /// Renvoie vers la fenêtre "Alors" 
        /// quand on veut utiliser la croix de fermeture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void FormTraitement_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    FormAlors monAlors = new FormAlors();
        //    monAlors.ShowDialog();
        //}
    }
}
