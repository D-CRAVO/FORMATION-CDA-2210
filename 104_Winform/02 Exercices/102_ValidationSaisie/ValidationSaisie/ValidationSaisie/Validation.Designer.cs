namespace ValidationSaisie
{
    partial class Validation
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
            this.labelValidationNom = new System.Windows.Forms.Label();
            this.labelValidationDate = new System.Windows.Forms.Label();
            this.labelValidationMontant = new System.Windows.Forms.Label();
            this.labelValidationCP = new System.Windows.Forms.Label();
            this.buttonValidationOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelValidationNom
            // 
            this.labelValidationNom.AutoSize = true;
            this.labelValidationNom.Location = new System.Drawing.Point(12, 24);
            this.labelValidationNom.Name = "labelValidationNom";
            this.labelValidationNom.Size = new System.Drawing.Size(35, 13);
            this.labelValidationNom.TabIndex = 0;
            this.labelValidationNom.Text = "label1";
            // 
            // labelValidationDate
            // 
            this.labelValidationDate.AutoSize = true;
            this.labelValidationDate.Location = new System.Drawing.Point(12, 37);
            this.labelValidationDate.Name = "labelValidationDate";
            this.labelValidationDate.Size = new System.Drawing.Size(35, 13);
            this.labelValidationDate.TabIndex = 1;
            this.labelValidationDate.Text = "label2";
            // 
            // labelValidationMontant
            // 
            this.labelValidationMontant.AutoSize = true;
            this.labelValidationMontant.Location = new System.Drawing.Point(12, 50);
            this.labelValidationMontant.Name = "labelValidationMontant";
            this.labelValidationMontant.Size = new System.Drawing.Size(35, 13);
            this.labelValidationMontant.TabIndex = 2;
            this.labelValidationMontant.Text = "label3";
            // 
            // labelValidationCP
            // 
            this.labelValidationCP.AutoSize = true;
            this.labelValidationCP.Location = new System.Drawing.Point(12, 63);
            this.labelValidationCP.Name = "labelValidationCP";
            this.labelValidationCP.Size = new System.Drawing.Size(35, 13);
            this.labelValidationCP.TabIndex = 3;
            this.labelValidationCP.Text = "label4";
            // 
            // buttonValidationOk
            // 
            this.buttonValidationOk.Location = new System.Drawing.Point(58, 105);
            this.buttonValidationOk.Name = "buttonValidationOk";
            this.buttonValidationOk.Size = new System.Drawing.Size(75, 23);
            this.buttonValidationOk.TabIndex = 4;
            this.buttonValidationOk.Text = "OK";
            this.buttonValidationOk.UseVisualStyleBackColor = true;
            // 
            // Validation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(184, 161);
            this.Controls.Add(this.buttonValidationOk);
            this.Controls.Add(this.labelValidationCP);
            this.Controls.Add(this.labelValidationMontant);
            this.Controls.Add(this.labelValidationDate);
            this.Controls.Add(this.labelValidationNom);
            this.Name = "Validation";
            this.Text = "Validation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelValidationNom;
        private System.Windows.Forms.Label labelValidationDate;
        private System.Windows.Forms.Label labelValidationMontant;
        private System.Windows.Forms.Label labelValidationCP;
        private System.Windows.Forms.Button buttonValidationOk;
    }
}