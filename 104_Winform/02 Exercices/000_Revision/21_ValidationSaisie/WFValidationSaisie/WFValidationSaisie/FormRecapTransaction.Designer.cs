namespace WFValidationSaisie
{
    partial class FormRecapTransaction
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
            labelDate = new Label();
            labelMontant = new Label();
            labelCp = new Label();
            SuspendLayout();
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(12, 33);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(43, 15);
            labelNom.TabIndex = 0;
            labelNom.Text = "Nom : ";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(12, 64);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(40, 15);
            labelDate.TabIndex = 1;
            labelDate.Text = "Date : ";
            // 
            // labelMontant
            // 
            labelMontant.AutoSize = true;
            labelMontant.Location = new Point(12, 94);
            labelMontant.Name = "labelMontant";
            labelMontant.Size = new Size(62, 15);
            labelMontant.TabIndex = 2;
            labelMontant.Text = "Montant : ";
            // 
            // labelCp
            // 
            labelCp.AutoSize = true;
            labelCp.Location = new Point(12, 126);
            labelCp.Name = "labelCp";
            labelCp.Size = new Size(79, 15);
            labelCp.TabIndex = 3;
            labelCp.Text = "Code Postal : ";
            // 
            // FormRecapTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(221, 212);
            Controls.Add(labelCp);
            Controls.Add(labelMontant);
            Controls.Add(labelDate);
            Controls.Add(labelNom);
            Name = "FormRecapTransaction";
            Text = "FormRecapTransaction";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNom;
        private Label labelDate;
        private Label labelMontant;
        private Label labelCp;
    }
}