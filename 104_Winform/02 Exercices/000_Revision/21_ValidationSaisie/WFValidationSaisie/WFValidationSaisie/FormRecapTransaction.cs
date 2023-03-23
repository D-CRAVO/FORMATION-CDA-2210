using CLTransactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFValidationSaisie
{
    public partial class FormRecapTransaction : Form
    {
        public FormRecapTransaction()
        {
            InitializeComponent();
        }

        public FormRecapTransaction(Transaction _transaction)
        {
            labelNom.Text = $"{labelNom}{_transaction.Nom}{Environment.NewLine}";
            labelDate.Text = $"{labelDate}{_transaction.Date}{Environment.NewLine}";
            labelMontant.Text = $"{labelMontant}{_transaction.Montant}{Environment.NewLine}";
            labelCp.Text = $"{labelCp}{_transaction.Cp}{Environment.NewLine}";
        }
    }
}
