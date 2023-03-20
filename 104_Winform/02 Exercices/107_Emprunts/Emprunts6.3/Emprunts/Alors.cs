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
    public partial class Alors : Form
    {
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Alors()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Bouton qui permet au formateur d'indiquer que l'exercice est presque juste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOui_Click(object sender, EventArgs e)
        {
            Hourra monHourra = new Hourra();
            monHourra.ShowDialog();
        }

        /// <summary>
        /// Bouton qui permet au formateur d'indiquer qu'il reste encore du travail
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNon_Click(object sender, EventArgs e)
        {
            Mince monMince = new Mince();
            monMince.ShowDialog();
        }
    }
}
