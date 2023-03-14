namespace ListBoxComboBox
{
    partial class FormFormulaire
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
            this.comboBoxSource = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxSource = new System.Windows.Forms.ListBox();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonAjouterTout = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonSupprimerTout = new System.Windows.Forms.Button();
            this.listBoxCible = new System.Windows.Forms.ListBox();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.labelCible = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxSource
            // 
            this.comboBoxSource.FormattingEnabled = true;
            this.comboBoxSource.Location = new System.Drawing.Point(12, 38);
            this.comboBoxSource.Name = "comboBoxSource";
            this.comboBoxSource.Size = new System.Drawing.Size(125, 23);
            this.comboBoxSource.TabIndex = 0;
            this.comboBoxSource.SelectedIndexChanged += new System.EventHandler(this.comboBoxSource_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxSource
            // 
            this.listBoxSource.FormattingEnabled = true;
            this.listBoxSource.ItemHeight = 15;
            this.listBoxSource.Location = new System.Drawing.Point(12, 67);
            this.listBoxSource.Name = "listBoxSource";
            this.listBoxSource.Size = new System.Drawing.Size(125, 94);
            this.listBoxSource.TabIndex = 2;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(143, 38);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(75, 23);
            this.buttonAjouter.TabIndex = 3;
            this.buttonAjouter.Text = ">";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonAjouterTout
            // 
            this.buttonAjouterTout.Location = new System.Drawing.Point(143, 67);
            this.buttonAjouterTout.Name = "buttonAjouterTout";
            this.buttonAjouterTout.Size = new System.Drawing.Size(75, 23);
            this.buttonAjouterTout.TabIndex = 4;
            this.buttonAjouterTout.Text = ">>";
            this.buttonAjouterTout.UseVisualStyleBackColor = true;
            this.buttonAjouterTout.Click += new System.EventHandler(this.buttonAjouterTout_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(143, 160);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(75, 23);
            this.buttonSupprimer.TabIndex = 5;
            this.buttonSupprimer.Text = "<";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonSupprimerTout
            // 
            this.buttonSupprimerTout.Location = new System.Drawing.Point(143, 189);
            this.buttonSupprimerTout.Name = "buttonSupprimerTout";
            this.buttonSupprimerTout.Size = new System.Drawing.Size(75, 23);
            this.buttonSupprimerTout.TabIndex = 6;
            this.buttonSupprimerTout.Text = "<<";
            this.buttonSupprimerTout.UseVisualStyleBackColor = true;
            this.buttonSupprimerTout.Click += new System.EventHandler(this.buttonSupprimerTout_Click);
            // 
            // listBoxCible
            // 
            this.listBoxCible.FormattingEnabled = true;
            this.listBoxCible.ItemHeight = 15;
            this.listBoxCible.Location = new System.Drawing.Point(224, 38);
            this.listBoxCible.Name = "listBoxCible";
            this.listBoxCible.Size = new System.Drawing.Size(125, 169);
            this.listBoxCible.TabIndex = 7;
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(228, 213);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(50, 23);
            this.buttonUp.TabIndex = 8;
            this.buttonUp.Text = "Up";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(284, 213);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(50, 23);
            this.buttonDown.TabIndex = 9;
            this.buttonDown.Text = "Down";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // labelCible
            // 
            this.labelCible.Location = new System.Drawing.Point(224, 12);
            this.labelCible.Name = "labelCible";
            this.labelCible.Size = new System.Drawing.Size(125, 15);
            this.labelCible.TabIndex = 10;
            this.labelCible.Text = "Cible";
            this.labelCible.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormFormulaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.labelCible);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.listBoxCible);
            this.Controls.Add(this.buttonSupprimerTout);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonAjouterTout);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.listBoxSource);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSource);
            this.Name = "FormFormulaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Les Listes";
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox comboBoxSource;
        private Label label1;
        private ListBox listBoxSource;
        private Button buttonAjouter;
        private Button buttonAjouterTout;
        private Button buttonSupprimer;
        private Button buttonSupprimerTout;
        private ListBox listBoxCible;
        private Button buttonUp;
        private Button buttonDown;
        private Label labelCible;
    }
}