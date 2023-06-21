﻿using System;
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
    public partial class Recapitulatif : Form
    {
        public Recapitulatif()
        {
            InitializeComponent();
        }

        public Recapitulatif(CLTransactions.Transaction transaction)
        {
            InitializeComponent();
            labelNom.Text += transaction.Nom;
            labelDate.Text += transaction.Date;
            labelMontant.Text += transaction.Montant;
            labelCp.Text += transaction.CodePostal;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}