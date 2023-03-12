using ClassLibraryTransactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidationSaisieR01
{
    public partial class RecapTransaction : Form
    {
        public RecapTransaction()
        {
            InitializeComponent();
        }

        public RecapTransaction(Transactions _transaction)
        {
            InitializeComponent();
            Affichage(_transaction);
        }

        public void Affichage(Transactions _transaction)
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
