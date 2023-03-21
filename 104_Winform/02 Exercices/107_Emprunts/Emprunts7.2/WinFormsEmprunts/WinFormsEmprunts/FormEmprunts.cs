using ClassLibraryEmpruntsControles;
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
    public partial class FormEmprunts : Form
    {
        private Emprunts empruntTest;
        private Emprunts empruntEtude;

        public FormEmprunts()
        {
            InitializeComponent();
            empruntTest = new Emprunts("John Doe", 150000, 120, 3, 0.08);
            empruntEtude = new Emprunts(empruntTest);
            ihm(empruntTest);
        }

        #region Taux d'intérêt

        /// <summary>
        /// Activation des checkBox des taux en fonction du constructeur;
        /// </summary>
        private void checkTauxInteret(Emprunts _emprunt)
        {
            if (_emprunt.TauxAnnuel == 0.07)
            {
                radioButton7.Checked = true;
            }
            else if (_emprunt.TauxAnnuel == 0.08)
            {
                radioButton8.Checked = true;
            }
            else
            {
                radioButton9.Checked = true;
            }
        }

        /// <summary>
        /// Détermine le taux d'intérêt annuel en fonction de la checkBox activée
        /// </summary>
        private double determinationTauxInteret()
        {
            if (radioButton7.Checked == true)
            {
                return 0.07;
            }
            else if (radioButton8.Checked == true)
            {
                return 0.08;
            }
            else
            {
                return 0.09;
            }
        }
        #endregion

        #region Periodicite de remboursement

        /// <summary>
        /// Détermine la périodicité de remboursement
        /// </summary>
        private void determinationHScrollBarDureeSmallChange(Emprunts _emprunt)
        {
            if (_emprunt.Periodicite == (int)Emprunts.enumPeriodicite.mensuelle)
            {
                hScrollBarDuree.SmallChange = (int)Emprunts.enumPeriodicite.mensuelle;
            }
            else if (_emprunt.Periodicite == (int)Emprunts.enumPeriodicite.bimestrielle)
            {
                hScrollBarDuree.SmallChange = (int)Emprunts.enumPeriodicite.bimestrielle;
            }
            else if (_emprunt.Periodicite == (int)Emprunts.enumPeriodicite.trimestrielle)
            {
                hScrollBarDuree.SmallChange = (int)Emprunts.enumPeriodicite.trimestrielle;
            }
            else if (_emprunt.Periodicite == (int)Emprunts.enumPeriodicite.semestrielle)
            {
                hScrollBarDuree.SmallChange = (int)Emprunts.enumPeriodicite.semestrielle;
            }
            else
            {
                hScrollBarDuree.SmallChange = (int)Emprunts.enumPeriodicite.annuelle;
            }
        }

        /// <summary>
        /// Met la sélection sur la périodicité récupérée du constructeur
        /// </summary>
        /// <param name="_periodicite">Périodicité du constructeur</param>
        private void selectListBoxPeriodicite(Emprunts _emprunt)
        {
            if (_emprunt.Periodicite == (int)Emprunts.enumPeriodicite.mensuelle)
            {
                listBoxPeriodicite.SelectedItem = Emprunts.enumPeriodicite.mensuelle.ToString();
                //listBoxPeriodicite.SetSelected(0, true);
            }
            else if (_emprunt.Periodicite == (int)Emprunts.enumPeriodicite.bimestrielle)
            {
                listBoxPeriodicite.SelectedItem = Emprunts.enumPeriodicite.bimestrielle.ToString();
            }
            else if (_emprunt.Periodicite == (int)Emprunts.enumPeriodicite.trimestrielle)
            {
                listBoxPeriodicite.SelectedItem = Emprunts.enumPeriodicite.trimestrielle.ToString();
            }
            else if (_emprunt.Periodicite == (int)Emprunts.enumPeriodicite.semestrielle)
            {
                listBoxPeriodicite.SelectedItem = Emprunts.enumPeriodicite.semestrielle.ToString();
            }
            else
            {
                listBoxPeriodicite.SelectedItem = Emprunts.enumPeriodicite.annuelle.ToString();
            }
        }
        #endregion

        


        /// <summary>
        /// Effectue l'actualisation des valeurs des différents champs
        /// ainsi que les calcul nécessaires.
        /// </summary>
        /// <param name="_nom">Nom du client</param>
        /// <param name="_capitalEmprunte">Capital emprunté récupérer du formulaire</param>
        /// <param name="_tauxAnnuel">Taux annuel récupéré du formulaire</param>
        /// <param name="_nbMois">Durée en mois du remboursement fourni par le formulaire</param>
        /// <param name="_periodicite">Périodicité de remboursement fourni par le formulaire</param>
        private void ihm(Emprunts _emprunt)
        {
            checkTauxInteret(_emprunt);
            determinationHScrollBarDureeSmallChange(_emprunt);
            selectListBoxPeriodicite(_emprunt);
            
            textBoxNom.Text = _emprunt.NomClient;
            textBoxCapitalEmprunte.Text = _emprunt.CapitalEmprunte.ToString();
            textBoxDuree.Text = _emprunt.NbMois.ToString();
            hScrollBarDuree.Value = _emprunt.NbMois;
            listBoxPeriodicite.SelectedItem = _emprunt.Periodicite.ToString();
            textBoxNbRemboursements.Text = _emprunt.calculNbRemboursements().ToString();
            textBoxRemboursements.Text = Math.Round(_emprunt.calculRemboursements(), 2).ToString();
        }

        /// <summary>
        /// Controle la saisie du Nom en fonction des caractères saisis 
        /// lors des changements effectués dans le champs "Nom".
        /// Fait appel à un errorProviderNom pour informer l'utilisateur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            if (Controles.controleNom(textBoxNom.Text))
            {
                errorProviderNom.SetError(textBoxNom, string.Empty);
                ihm(empruntEtude);
            }
            else
            {
                errorProviderNom.SetError(textBoxNom, "Veuillez saisir un nom composé uniquement de caracrtères alphabétiques");
            }
        }

        /// <summary>
        /// Controle la validité du Capital Emprunté saisi
        /// lors des changements effectués dans le champs "Capital Emprunté"
        /// et met à jour les différents paramètres du formulaire.
        /// Fait appel à un errorProviderCapilEmprunte pour informer l'utilisateur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxCapitalEmprunte_TextChanged(object sender, EventArgs e)
        {
            if (Controles.controleCapitalEmprunte(textBoxCapitalEmprunte.Text))
            {
                empruntEtude.CapitalEmprunte = uint.Parse(textBoxCapitalEmprunte.Text);
                errorProviderCapitalEmprunte.SetError(textBoxCapitalEmprunte, string.Empty);
                ihm(empruntEtude);
            }
            else
            {
                errorProviderCapitalEmprunte.SetError(textBoxCapitalEmprunte, "Le capital ne peut comporter que 10 chiffres");
            }
        }

        /// <summary>
        /// Récupère la valeur de la durée de remboursement 
        /// via le scroll de la scrollBar
        /// et met à jour les différents paramètres du formulaire.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            empruntEtude.NbMois = hScrollBarDuree.Value;
            textBoxDuree.Text = empruntEtude.NbMois.ToString();//voir si necessaire
            ihm(empruntEtude);
        }

        /// <summary>
        /// Récupère la périodicité sélectionnée dans la listBoxPeriodicite
        /// et met à jour les différents paramètres du formulaire.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxPeriodicite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPeriodicite.SelectedIndex == 0)
            {
                empruntEtude.Periodicite = (int)Emprunts.enumPeriodicite.mensuelle;
            }
            else if (listBoxPeriodicite.SelectedIndex == 1)
            {
                empruntEtude.Periodicite = (int)Emprunts.enumPeriodicite.bimestrielle;
            }
            else if (listBoxPeriodicite.SelectedIndex == 2)
            {
                empruntEtude.Periodicite = (int)Emprunts.enumPeriodicite.trimestrielle;
            }
            else if (listBoxPeriodicite.SelectedIndex == 3)
            {
                empruntEtude.Periodicite = (int)Emprunts.enumPeriodicite.semestrielle;
            }
            else
            {
                empruntEtude.Periodicite = (int)Emprunts.enumPeriodicite.annuelle;
            }
            ihm(empruntEtude);
        }

        /// <summary>
        /// Récupère la valeur du taux d'intérêt 
        /// via la checkBox7 correxpondant au taux 7%
        /// et met à jour les différents paramètres du formulaire.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            empruntEtude.TauxAnnuel = determinationTauxInteret();
            ihm(empruntEtude);
        }

        /// <summary>
        /// Récupère la valeur du taux d'intérêt 
        /// via la checkBox8 correxpondant au taux 8%
        /// et met à jour les différents paramètres du formulaire.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            empruntEtude.TauxAnnuel = determinationTauxInteret();
            ihm(empruntEtude);
        }

        /// <summary>
        /// Récupère la valeur du taux d'intérêt 
        /// via la checkBox9 correxpondant au taux 9%
        /// et met à jour les différents paramètres du formulaire.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            empruntEtude.TauxAnnuel = determinationTauxInteret();
            ihm(empruntEtude);
        }

        /// <summary>
        /// Valide les informations fournies dans les différents champs
        /// et renvoie vers un formulaire récapitulatif de l'emprunt.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            FormRecapitulatif monRecapitulatif = new FormRecapitulatif(empruntEtude);
            monRecapitulatif.ShowDialog();
        }

        /// <summary>
        /// Remet tous les champs à l'etat initial avec les paramètres
        /// fournis par le constructeur de départ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            ihm(empruntTest);
        }

        /// <summary>
        /// Demande une confirmation avant fermeture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEmprunts_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResultYesNo = MessageBox.Show("Voulez-vous vraiment quitter ?", "Aurevoir !", MessageBoxButtons.YesNo);
            if (dialogResultYesNo == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


    }
}
