using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryEmprunts;

namespace WinFormsEmprunts
{
    public partial class FormRecapitulatif : Form
    {
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public FormRecapitulatif()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructeur classique
        /// </summary>
        /// <param name="validation"></param>
        public FormRecapitulatif(Emprunts _emprunt)
        {
            InitializeComponent();
            textBoxNom.Text = _emprunt.NomClient.ToString();
            textBoxCapitalEmprunte.Text = _emprunt.CapitalEmprunte.ToString();
            textBoxTauxAnnuel.Text = _emprunt.TauxAnnuel.ToString();
            textBoxPeriodiciteRemboursement.Text = _emprunt.Periodicite.ToString();
            textBoxNombreRemboursements.Text = _emprunt.calculNbRemboursements().ToString();
            textBoxMontantRemboursements.Text = Math.Round(_emprunt.calculRemboursements(), 2).ToString();
        }

        /// <summary>
        /// Bouton qui valide l'emprunt 
        /// et renvoie vers la page de traitement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonValidation_Click(object sender, EventArgs e)
        {
            FormTraitement monTraitement = new FormTraitement();
            monTraitement.ShowDialog();
            Close();
        }

        /// <summary>
        /// Bouton qui annule la validation de l'emprunt 
        /// et reviens à la fenêtre précédente 
        /// sans effacer les paramètres déjà enregistrés sur cette dernière
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
