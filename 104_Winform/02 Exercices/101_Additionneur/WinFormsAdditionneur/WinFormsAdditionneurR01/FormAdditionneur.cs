using ClassLibraryAddition;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAdditionneurR01
{
    public partial class FormAdditionneur : Form
    {
        /// <summary>
        /// Stocke les valeurs saisies
        /// </summary>
        Addition addition = new Addition();

        /// <summary>
        /// Constructeur de la forme
        /// </summary>
        public FormAdditionneur()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Affiche le tag du bouton et enregistre sa valeur dans addition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBoxAffichage.Text += $"{button.Tag} + ";
            addition.enregistrer(int.Parse((string)button.Tag));
        }

        /// <summary>
        /// Vide l'affichage de la textBox et réinitialise addition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVider_Click(object sender, EventArgs e)
        {
            addition = new Addition();
            textBoxAffichage.Clear();
        }

        /// <summary>
        /// Demande le calcul de la somme des valeurs contenues dans addition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalculer_Click(object sender, EventArgs e)
        {
            textBoxAffichage.Text += $" = {addition.getResultat()} + ";
        }
    }
}
