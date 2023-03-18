namespace Emprunts
{
    partial class Recapitulatif
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelNom = new Label();
            labelCapitalEmprunte = new Label();
            labelPeriodiciteRemboursement = new Label();
            labelNombreRemboursements = new Label();
            labelMontantRemboursements = new Label();
            textBoxNom = new TextBox();
            textBoxCapitalEmprunte = new TextBox();
            textBoxPeriodiciteRemboursement = new TextBox();
            textBoxNombreRemboursements = new TextBox();
            textBoxMontantRemboursements = new TextBox();
            SuspendLayout();
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(26, 20);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(40, 15);
            labelNom.TabIndex = 0;
            labelNom.Text = "Nom :";
            // 
            // labelCapitalEmprunte
            // 
            labelCapitalEmprunte.AutoSize = true;
            labelCapitalEmprunte.Location = new Point(26, 82);
            labelCapitalEmprunte.Name = "labelCapitalEmprunte";
            labelCapitalEmprunte.Size = new Size(108, 15);
            labelCapitalEmprunte.TabIndex = 1;
            labelCapitalEmprunte.Text = "Capital Emprunté : ";
            // 
            // labelPeriodiciteRemboursement
            // 
            labelPeriodiciteRemboursement.AutoSize = true;
            labelPeriodiciteRemboursement.Location = new Point(26, 148);
            labelPeriodiciteRemboursement.Name = "labelPeriodiciteRemboursement";
            labelPeriodiciteRemboursement.Size = new Size(173, 15);
            labelPeriodiciteRemboursement.TabIndex = 2;
            labelPeriodiciteRemboursement.Text = "Périodicité de remboursement :";
            // 
            // labelNombreRemboursements
            // 
            labelNombreRemboursements.AutoSize = true;
            labelNombreRemboursements.Location = new Point(26, 211);
            labelNombreRemboursements.Name = "labelNombreRemboursements";
            labelNombreRemboursements.Size = new Size(166, 15);
            labelNombreRemboursements.TabIndex = 3;
            labelNombreRemboursements.Text = "Nombre de remboursements :";
            // 
            // labelMontantRemboursements
            // 
            labelMontantRemboursements.AutoSize = true;
            labelMontantRemboursements.Location = new Point(26, 272);
            labelMontantRemboursements.Name = "labelMontantRemboursements";
            labelMontantRemboursements.Size = new Size(173, 15);
            labelMontantRemboursements.TabIndex = 4;
            labelMontantRemboursements.Text = "Montant des remboursements :";
            // 
            // textBoxNom
            // 
            textBoxNom.Location = new Point(26, 38);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.ReadOnly = true;
            textBoxNom.Size = new Size(200, 23);
            textBoxNom.TabIndex = 5;
            // 
            // textBoxCapitalEmprunte
            // 
            textBoxCapitalEmprunte.Location = new Point(26, 100);
            textBoxCapitalEmprunte.Name = "textBoxCapitalEmprunte";
            textBoxCapitalEmprunte.ReadOnly = true;
            textBoxCapitalEmprunte.Size = new Size(200, 23);
            textBoxCapitalEmprunte.TabIndex = 6;
            // 
            // textBoxPeriodiciteRemboursement
            // 
            textBoxPeriodiciteRemboursement.Location = new Point(26, 166);
            textBoxPeriodiciteRemboursement.Name = "textBoxPeriodiciteRemboursement";
            textBoxPeriodiciteRemboursement.ReadOnly = true;
            textBoxPeriodiciteRemboursement.Size = new Size(200, 23);
            textBoxPeriodiciteRemboursement.TabIndex = 7;
            // 
            // textBoxNombreRemboursements
            // 
            textBoxNombreRemboursements.Location = new Point(26, 229);
            textBoxNombreRemboursements.Name = "textBoxNombreRemboursements";
            textBoxNombreRemboursements.ReadOnly = true;
            textBoxNombreRemboursements.Size = new Size(200, 23);
            textBoxNombreRemboursements.TabIndex = 8;
            textBoxNombreRemboursements.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxMontantRemboursements
            // 
            textBoxMontantRemboursements.Location = new Point(26, 290);
            textBoxMontantRemboursements.Name = "textBoxMontantRemboursements";
            textBoxMontantRemboursements.ReadOnly = true;
            textBoxMontantRemboursements.Size = new Size(200, 23);
            textBoxMontantRemboursements.TabIndex = 9;
            textBoxMontantRemboursements.TextAlign = HorizontalAlignment.Center;
            // 
            // Recapitulatif
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 361);
            Controls.Add(textBoxMontantRemboursements);
            Controls.Add(textBoxNombreRemboursements);
            Controls.Add(textBoxPeriodiciteRemboursement);
            Controls.Add(textBoxCapitalEmprunte);
            Controls.Add(textBoxNom);
            Controls.Add(labelMontantRemboursements);
            Controls.Add(labelNombreRemboursements);
            Controls.Add(labelPeriodiciteRemboursement);
            Controls.Add(labelCapitalEmprunte);
            Controls.Add(labelNom);
            Name = "Recapitulatif";
            Text = "Recapitulatif";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNom;
        private Label labelCapitalEmprunte;
        private Label labelPeriodiciteRemboursement;
        private Label labelNombreRemboursements;
        private Label labelMontantRemboursements;
        private TextBox textBoxNom;
        private TextBox textBoxCapitalEmprunte;
        private TextBox textBoxPeriodiciteRemboursement;
        private TextBox textBoxNombreRemboursements;
        private TextBox textBoxMontantRemboursements;
    }
}