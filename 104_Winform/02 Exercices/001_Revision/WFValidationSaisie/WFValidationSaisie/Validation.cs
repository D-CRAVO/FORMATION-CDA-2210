using CLValidationSaisie;
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
    public partial class Validation : Form
    {
        public Validation()
        {
            InitializeComponent();
        }

        public Validation(Transaction maTransaction)
        {
            InitializeComponent();
            Affichage(maTransaction);
        }

        public void Affichage(Transaction maTransaction)
        {

            labelNom.Text = $"{labelNom.Text} {maTransaction.Nom}{Environment.NewLine}";
            labelDate.Text = $"{labelDate.Text} {maTransaction.Date}{Environment.NewLine}";
            labelMontant.Text = $"{labelMontant.Text} {maTransaction.Montant}{Environment.NewLine}";
            labelCp.Text = $"{labelCp.Text} {maTransaction.Cp}{Environment.NewLine}";
        }

        private void Validation_Load(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
