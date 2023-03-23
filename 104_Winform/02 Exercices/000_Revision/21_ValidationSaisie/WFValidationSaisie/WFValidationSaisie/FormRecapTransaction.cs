using CLTransactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace WFValidationSaisie
{
    public partial class FormRecapTransaction : Form
    {
        public FormRecapTransaction()
        {
            InitializeComponent();
        }

        public FormRecapTransaction(CLTransactions.Transaction _transaction)
        {
            InitializeComponent();
            Ihm(_transaction);
        }

        public void Ihm(CLTransactions.Transaction _transaction)
        {
            labelNom.Text = $"{labelNom.Text}{_transaction.Nom}{Environment.NewLine}";
            labelDate.Text = $"{labelDate.Text}{_transaction.Date}{Environment.NewLine}";
            labelMontant.Text = $"{labelMontant.Text}{_transaction.Montant}{Environment.NewLine}";
            labelCp.Text = $"{labelCp.Text}{_transaction.Cp}{Environment.NewLine}";
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
