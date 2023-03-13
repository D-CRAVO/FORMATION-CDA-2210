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
        private Transaction transaction;
        public FormRecapTransaction()
        {
            InitializeComponent();
            
        }

        public FormRecapTransaction(Transaction t)
        {
            InitializeComponent();
            transaction = t;
            Affichage(t);
        }

        public void Affichage(Transaction _transaction)
        {
            labelNom.Text = $"{labelNom.Text} {_transaction.Nom}{Environment.NewLine}";
            labelDate.Text = $"{labelDate.Text} {_transaction.Date}{Environment.NewLine}";
            labelMontant.Text = $"{labelMontant.Text} {_transaction.Montant}{Environment.NewLine}";
            labelCP.Text = $"{labelCP.Text} {_transaction.CodePostal}{Environment.NewLine}";
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
