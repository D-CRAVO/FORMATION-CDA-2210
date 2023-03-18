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
    public partial class Hourra : Form
    {
        /// <summary>
        /// Variable qui va servir pour le compte à rebours
        /// </summary>
        int temps;

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Hourra()
        {
            temps = 15;
            InitializeComponent();
            timerHourra.Start();
        }

        /// <summary>
        /// Méthode qui va effectuer le compte à rebours 
        /// et fermer automatiquement la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerHourra_Tick(object sender, EventArgs e)
        {
            temps--;
            if (temps < 0)
            {
                timerHourra.Stop();
                Close();
            }
        }
    }
}
