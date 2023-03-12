namespace ValidationSaisieR01
{
    partial class RecapTransaction
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
            labelCP = new Label();
            SuspendLayout();
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(46, 60);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(40, 15);
            labelNom.TabIndex = 0;
            labelNom.Text = "Nom :";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(46, 87);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(37, 15);
            labelDate.TabIndex = 1;
            labelDate.Text = "Date :";
            // 
            // labelMontant
            // 
            labelMontant.AutoSize = true;
            labelMontant.Location = new Point(46, 115);
            labelMontant.Name = "labelMontant";
            labelMontant.Size = new Size(59, 15);
            labelMontant.TabIndex = 2;
            labelMontant.Text = "Montant :";
            // 
            // labelCP
            // 
            labelCP.AutoSize = true;
            labelCP.Location = new Point(46, 145);
            labelCP.Name = "labelCP";
            labelCP.Size = new Size(76, 15);
            labelCP.TabIndex = 3;
            labelCP.Text = "Code Postal :";
            // 
            // RecapTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 261);
            Controls.Add(labelCP);
            Controls.Add(labelMontant);
            Controls.Add(labelDate);
            Controls.Add(labelNom);
            Name = "RecapTransaction";
            Text = "RecapTransaction";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNom;
        private Label labelDate;
        private Label labelMontant;
        private Label labelCP;
    }
}