using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsEmprunts
{
    public partial class FormAlors : Form
    {
        public FormAlors()
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
            FormHourra monHourra = new FormHourra();
            monHourra.ShowDialog();
        }

        /// <summary>
        /// Bouton qui permet au formateur d'indiquer qu'il reste encore du travail
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNon_Click(object sender, EventArgs e)
        {
            FormMince monMince = new FormMince();
            monMince.ShowDialog();
        }
    }
}
