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
            Affichage(t);
        }

        public void Affichage(Transaction _transaction)
        {
            MessageBox.Show
                (
                    $"{labelNom.Text} {_transaction.Nom}{Environment.NewLine}" +
                    $"{labelDate.Text} {_transaction.Date}{Environment.NewLine}" +
                    $"{labelMontant.Text} {_transaction.Montant}{Environment.NewLine}" +
                    $"{labelCP.Text} {_transaction.CodePostal}{Environment.NewLine}"
                    , "Validation effectuée"
                );
        }
     

    }
}
