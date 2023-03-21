namespace WinFormsEmprunts
{
    partial class FormRecapitulatif
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
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonValidation = new System.Windows.Forms.Button();
            this.textBoxTauxAnnuel = new System.Windows.Forms.TextBox();
            this.labelTauxAnnuel = new System.Windows.Forms.Label();
            this.textBoxMontantRemboursements = new System.Windows.Forms.TextBox();
            this.textBoxNombreRemboursements = new System.Windows.Forms.TextBox();
            this.textBoxPeriodiciteRemboursement = new System.Windows.Forms.TextBox();
            this.textBoxCapitalEmprunte = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelMontantRemboursements = new System.Windows.Forms.Label();
            this.labelNombreRemboursements = new System.Windows.Forms.Label();
            this.labelPeriodiciteRemboursement = new System.Windows.Forms.Label();
            this.labelCapitalEmprunte = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(12, 386);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 27;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonValidation
            // 
            this.buttonValidation.BackColor = System.Drawing.Color.Red;
            this.buttonValidation.ForeColor = System.Drawing.Color.White;
            this.buttonValidation.Location = new System.Drawing.Point(137, 386);
            this.buttonValidation.Name = "buttonValidation";
            this.buttonValidation.Size = new System.Drawing.Size(75, 23);
            this.buttonValidation.TabIndex = 26;
            this.buttonValidation.Text = "Validation";
            this.buttonValidation.UseVisualStyleBackColor = false;
            this.buttonValidation.Click += new System.EventHandler(this.buttonValidation_Click);
            // 
            // textBoxTauxAnnuel
            // 
            this.textBoxTauxAnnuel.Location = new System.Drawing.Point(12, 146);
            this.textBoxTauxAnnuel.Name = "textBoxTauxAnnuel";
            this.textBoxTauxAnnuel.ReadOnly = true;
            this.textBoxTauxAnnuel.Size = new System.Drawing.Size(200, 23);
            this.textBoxTauxAnnuel.TabIndex = 25;
            // 
            // labelTauxAnnuel
            // 
            this.labelTauxAnnuel.AutoSize = true;
            this.labelTauxAnnuel.Location = new System.Drawing.Point(12, 128);
            this.labelTauxAnnuel.Name = "labelTauxAnnuel";
            this.labelTauxAnnuel.Size = new System.Drawing.Size(72, 15);
            this.labelTauxAnnuel.TabIndex = 24;
            this.labelTauxAnnuel.Text = "Taux Annuel";
            // 
            // textBoxMontantRemboursements
            // 
            this.textBoxMontantRemboursements.Location = new System.Drawing.Point(12, 335);
            this.textBoxMontantRemboursements.Name = "textBoxMontantRemboursements";
            this.textBoxMontantRemboursements.ReadOnly = true;
            this.textBoxMontantRemboursements.Size = new System.Drawing.Size(200, 23);
            this.textBoxMontantRemboursements.TabIndex = 23;
            this.textBoxMontantRemboursements.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxNombreRemboursements
            // 
            this.textBoxNombreRemboursements.Location = new System.Drawing.Point(12, 274);
            this.textBoxNombreRemboursements.Name = "textBoxNombreRemboursements";
            this.textBoxNombreRemboursements.ReadOnly = true;
            this.textBoxNombreRemboursements.Size = new System.Drawing.Size(200, 23);
            this.textBoxNombreRemboursements.TabIndex = 22;
            this.textBoxNombreRemboursements.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPeriodiciteRemboursement
            // 
            this.textBoxPeriodiciteRemboursement.Location = new System.Drawing.Point(12, 211);
            this.textBoxPeriodiciteRemboursement.Name = "textBoxPeriodiciteRemboursement";
            this.textBoxPeriodiciteRemboursement.ReadOnly = true;
            this.textBoxPeriodiciteRemboursement.Size = new System.Drawing.Size(200, 23);
            this.textBoxPeriodiciteRemboursement.TabIndex = 21;
            // 
            // textBoxCapitalEmprunte
            // 
            this.textBoxCapitalEmprunte.Location = new System.Drawing.Point(12, 89);
            this.textBoxCapitalEmprunte.Name = "textBoxCapitalEmprunte";
            this.textBoxCapitalEmprunte.ReadOnly = true;
            this.textBoxCapitalEmprunte.Size = new System.Drawing.Size(200, 23);
            this.textBoxCapitalEmprunte.TabIndex = 20;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(12, 27);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.ReadOnly = true;
            this.textBoxNom.Size = new System.Drawing.Size(200, 23);
            this.textBoxNom.TabIndex = 19;
            // 
            // labelMontantRemboursements
            // 
            this.labelMontantRemboursements.AutoSize = true;
            this.labelMontantRemboursements.Location = new System.Drawing.Point(12, 317);
            this.labelMontantRemboursements.Name = "labelMontantRemboursements";
            this.labelMontantRemboursements.Size = new System.Drawing.Size(173, 15);
            this.labelMontantRemboursements.TabIndex = 18;
            this.labelMontantRemboursements.Text = "Montant des remboursements :";
            // 
            // labelNombreRemboursements
            // 
            this.labelNombreRemboursements.AutoSize = true;
            this.labelNombreRemboursements.Location = new System.Drawing.Point(12, 256);
            this.labelNombreRemboursements.Name = "labelNombreRemboursements";
            this.labelNombreRemboursements.Size = new System.Drawing.Size(166, 15);
            this.labelNombreRemboursements.TabIndex = 17;
            this.labelNombreRemboursements.Text = "Nombre de remboursements :";
            // 
            // labelPeriodiciteRemboursement
            // 
            this.labelPeriodiciteRemboursement.AutoSize = true;
            this.labelPeriodiciteRemboursement.Location = new System.Drawing.Point(12, 193);
            this.labelPeriodiciteRemboursement.Name = "labelPeriodiciteRemboursement";
            this.labelPeriodiciteRemboursement.Size = new System.Drawing.Size(173, 15);
            this.labelPeriodiciteRemboursement.TabIndex = 16;
            this.labelPeriodiciteRemboursement.Text = "Périodicité de remboursement :";
            // 
            // labelCapitalEmprunte
            // 
            this.labelCapitalEmprunte.AutoSize = true;
            this.labelCapitalEmprunte.Location = new System.Drawing.Point(12, 71);
            this.labelCapitalEmprunte.Name = "labelCapitalEmprunte";
            this.labelCapitalEmprunte.Size = new System.Drawing.Size(108, 15);
            this.labelCapitalEmprunte.TabIndex = 15;
            this.labelCapitalEmprunte.Text = "Capital Emprunté : ";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(12, 9);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(40, 15);
            this.labelNom.TabIndex = 14;
            this.labelNom.Text = "Nom :";
            // 
            // FormRecapitulatif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 422);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonValidation);
            this.Controls.Add(this.textBoxTauxAnnuel);
            this.Controls.Add(this.labelTauxAnnuel);
            this.Controls.Add(this.textBoxMontantRemboursements);
            this.Controls.Add(this.textBoxNombreRemboursements);
            this.Controls.Add(this.textBoxPeriodiciteRemboursement);
            this.Controls.Add(this.textBoxCapitalEmprunte);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelMontantRemboursements);
            this.Controls.Add(this.labelNombreRemboursements);
            this.Controls.Add(this.labelPeriodiciteRemboursement);
            this.Controls.Add(this.labelCapitalEmprunte);
            this.Controls.Add(this.labelNom);
            this.Name = "FormRecapitulatif";
            this.Text = "FormRecapitulatif";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAnnuler;
        private Button buttonValidation;
        private TextBox textBoxTauxAnnuel;
        private Label labelTauxAnnuel;
        private TextBox textBoxMontantRemboursements;
        private TextBox textBoxNombreRemboursements;
        private TextBox textBoxPeriodiciteRemboursement;
        private TextBox textBoxCapitalEmprunte;
        private TextBox textBoxNom;
        private Label labelMontantRemboursements;
        private Label labelNombreRemboursements;
        private Label labelPeriodiciteRemboursement;
        private Label labelCapitalEmprunte;
        private Label labelNom;
    }
}