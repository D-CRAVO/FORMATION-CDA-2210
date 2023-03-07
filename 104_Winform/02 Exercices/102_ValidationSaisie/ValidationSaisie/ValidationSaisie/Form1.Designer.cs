namespace ValidationSaisie
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.Label();
            this.txtCP = new System.Windows.Forms.Label();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonEffacer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Montant";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Code Postal";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNom.Location = new System.Drawing.Point(90, 49);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(150, 25);
            this.txtNom.TabIndex = 4;
            this.txtNom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDate.Location = new System.Drawing.Point(90, 86);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 25);
            this.txtDate.TabIndex = 5;
            this.txtDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMontant
            // 
            this.txtMontant.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtMontant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontant.Location = new System.Drawing.Point(90, 122);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(100, 25);
            this.txtMontant.TabIndex = 6;
            this.txtMontant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCP
            // 
            this.txtCP.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCP.Location = new System.Drawing.Point(90, 157);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(75, 25);
            this.txtCP.TabIndex = 7;
            this.txtCP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(264, 183);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 8;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            // 
            // buttonEffacer
            // 
            this.buttonEffacer.Location = new System.Drawing.Point(264, 212);
            this.buttonEffacer.Name = "buttonEffacer";
            this.buttonEffacer.Size = new System.Drawing.Size(75, 23);
            this.buttonEffacer.TabIndex = 9;
            this.buttonEffacer.Text = "Effacer";
            this.buttonEffacer.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(196, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "(JJ/MM/AAAA)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonEffacer);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtNom;
        private System.Windows.Forms.Label txtDate;
        private System.Windows.Forms.Label txtMontant;
        private System.Windows.Forms.Label txtCP;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonEffacer;
        private System.Windows.Forms.Label label5;
    }
}

