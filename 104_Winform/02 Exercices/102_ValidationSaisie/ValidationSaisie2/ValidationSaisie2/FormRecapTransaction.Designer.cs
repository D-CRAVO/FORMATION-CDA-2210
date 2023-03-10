namespace ValidationSaisie2
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
            this.labelNom = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelMontant = new System.Windows.Forms.Label();
            this.labelCP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(82, 64);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(40, 15);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom :";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(82, 94);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(37, 15);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Date :";
            // 
            // labelMontant
            // 
            this.labelMontant.AutoSize = true;
            this.labelMontant.Location = new System.Drawing.Point(82, 124);
            this.labelMontant.Name = "labelMontant";
            this.labelMontant.Size = new System.Drawing.Size(62, 15);
            this.labelMontant.TabIndex = 2;
            this.labelMontant.Text = "Montant : ";
            // 
            // labelCP
            // 
            this.labelCP.AutoSize = true;
            this.labelCP.Location = new System.Drawing.Point(82, 159);
            this.labelCP.Name = "labelCP";
            this.labelCP.Size = new System.Drawing.Size(76, 15);
            this.labelCP.TabIndex = 3;
            this.labelCP.Text = "Code Postal :";
            // 
            // FormRecapTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 227);
            this.Controls.Add(this.labelCP);
            this.Controls.Add(this.labelMontant);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelNom);
            this.Name = "FormRecapTransaction";
            this.Text = "FormRecapTransaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNom;
        private Label labelDate;
        private Label labelMontant;
        private Label labelCP;
    }
}