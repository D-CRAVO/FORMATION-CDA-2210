using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryValidation;

namespace Emprunts
{
    public partial class Recapitulatif : Form
    {
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Recapitulatif()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructeur classique
        /// </summary>
        /// <param name="validation"></param>
        public Recapitulatif(Validation validation)
        {
            InitializeComponent();
            textBoxNom.Text = validation.NomClient.ToString();
            textBoxCapitalEmprunte.Text = validation.CapitalEmprunte.ToString();
            textBoxTauxAnnuel.Text = validation.TauxAnnuel.ToString();
            textBoxNombreRemboursements.Text = validation.NombreRemboursements.ToString();
            textBoxMontantRemboursements.Text = validation.MontantRemboursements.ToString();
        }

        /// <summary>
        /// Bouton qui valide l'emprunt 
        /// et renvoie vers la page de traitement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonValidation_Click(object sender, EventArgs e)
        {
            Traitement monTraitement = new Traitement();
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
