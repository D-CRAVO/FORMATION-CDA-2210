using ClassLibraryTransaction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidationSaisie2
{
    public partial class FormRecapTransaction : Form
    {
        public FormRecapTransaction()
        {
            InitializeComponent();
            
        }

        public FormRecapTransaction(Transaction t)
        {
            InitializeComponent();
            Enregistrement(t);
            Affichage();
        }

        public void Enregistrement(Transaction _transaction)
        {
            labelNom.Text += _transaction.Nom;
            labelDate.Text += _transaction.Date;
            labelMontant.Text += _transaction.Montant;
            labelCP.Text += _transaction.CodePostal;
        }

        public void Affichage()
        {
            MessageBox.Show
                (
                    $"{ labelNom.Text}\n{labelDate.Text}\n{labelMontant.Text}\n{labelCP.Text}"
                    , "Validation effectuée"
                );
        }
     

    }
}
