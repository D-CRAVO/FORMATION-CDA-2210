namespace CheckBoxBoutonsRadio
{
    partial class FormCheckBoxRadioButton
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
            this.groupBoxChoix = new System.Windows.Forms.GroupBox();
            this.checkBoxCasse = new System.Windows.Forms.CheckBox();
            this.checkBoxCaracteres = new System.Windows.Forms.CheckBox();
            this.checkBoxFond = new System.Windows.Forms.CheckBox();
            this.groupBoxFond = new System.Windows.Forms.GroupBox();
            this.radioButtonFondBleu = new System.Windows.Forms.RadioButton();
            this.radioButtonFondVert = new System.Windows.Forms.RadioButton();
            this.radioButtonFondRouge = new System.Windows.Forms.RadioButton();
            this.groupBoxCaracteres = new System.Windows.Forms.GroupBox();
            this.radioButtonCaracteresNoir = new System.Windows.Forms.RadioButton();
            this.radioButtonCaracteresBlanc = new System.Windows.Forms.RadioButton();
            this.radioButtonCaracteresRouge = new System.Windows.Forms.RadioButton();
            this.groupBoxCasse = new System.Windows.Forms.GroupBox();
            this.radioButtonMajuscules = new System.Windows.Forms.RadioButton();
            this.radioButtonMinuscules = new System.Windows.Forms.RadioButton();
            this.labelTexte = new System.Windows.Forms.Label();
            this.textBoxOrigine = new System.Windows.Forms.TextBox();
            this.textBoxModifie = new System.Windows.Forms.TextBox();
            this.groupBoxChoix.SuspendLayout();
            this.groupBoxFond.SuspendLayout();
            this.groupBoxCaracteres.SuspendLayout();
            this.groupBoxCasse.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxChoix
            // 
            this.groupBoxChoix.Controls.Add(this.checkBoxCasse);
            this.groupBoxChoix.Controls.Add(this.checkBoxCaracteres);
            this.groupBoxChoix.Controls.Add(this.checkBoxFond);
            this.groupBoxChoix.Enabled = false;
            this.groupBoxChoix.Location = new System.Drawing.Point(292, 12);
            this.groupBoxChoix.Name = "groupBoxChoix";
            this.groupBoxChoix.Size = new System.Drawing.Size(180, 99);
            this.groupBoxChoix.TabIndex = 0;
            this.groupBoxChoix.TabStop = false;
            this.groupBoxChoix.Text = "Choix";
            // 
            // checkBoxCasse
            // 
            this.checkBoxCasse.AutoSize = true;
            this.checkBoxCasse.Location = new System.Drawing.Point(9, 76);
            this.checkBoxCasse.Name = "checkBoxCasse";
            this.checkBoxCasse.Size = new System.Drawing.Size(56, 19);
            this.checkBoxCasse.TabIndex = 4;
            this.checkBoxCasse.Text = "Casse";
            this.checkBoxCasse.UseVisualStyleBackColor = true;
            this.checkBoxCasse.CheckedChanged += new System.EventHandler(this.checkBoxCasse_CheckedChanged);
            // 
            // checkBoxCaracteres
            // 
            this.checkBoxCaracteres.AutoSize = true;
            this.checkBoxCaracteres.Location = new System.Drawing.Point(9, 51);
            this.checkBoxCaracteres.Name = "checkBoxCaracteres";
            this.checkBoxCaracteres.Size = new System.Drawing.Size(145, 19);
            this.checkBoxCaracteres.TabIndex = 3;
            this.checkBoxCaracteres.Text = "Couleur des caractères";
            this.checkBoxCaracteres.UseVisualStyleBackColor = true;
            this.checkBoxCaracteres.CheckedChanged += new System.EventHandler(this.checkBoxCaracteres_CheckedChanged);
            // 
            // checkBoxFond
            // 
            this.checkBoxFond.AutoSize = true;
            this.checkBoxFond.Location = new System.Drawing.Point(9, 26);
            this.checkBoxFond.Name = "checkBoxFond";
            this.checkBoxFond.Size = new System.Drawing.Size(112, 19);
            this.checkBoxFond.TabIndex = 2;
            this.checkBoxFond.Text = "Couleur de fond";
            this.checkBoxFond.UseVisualStyleBackColor = true;
            this.checkBoxFond.CheckedChanged += new System.EventHandler(this.checkBoxFond_CheckedChanged);
            // 
            // groupBoxFond
            // 
            this.groupBoxFond.Controls.Add(this.radioButtonFondBleu);
            this.groupBoxFond.Controls.Add(this.radioButtonFondVert);
            this.groupBoxFond.Controls.Add(this.radioButtonFondRouge);
            this.groupBoxFond.Location = new System.Drawing.Point(12, 143);
            this.groupBoxFond.Name = "groupBoxFond";
            this.groupBoxFond.Size = new System.Drawing.Size(90, 106);
            this.groupBoxFond.TabIndex = 1;
            this.groupBoxFond.TabStop = false;
            this.groupBoxFond.Text = "Fond";
            this.groupBoxFond.Visible = false;
            // 
            // radioButtonFondBleu
            // 
            this.radioButtonFondBleu.AutoSize = true;
            this.radioButtonFondBleu.Location = new System.Drawing.Point(6, 72);
            this.radioButtonFondBleu.Name = "radioButtonFondBleu";
            this.radioButtonFondBleu.Size = new System.Drawing.Size(48, 19);
            this.radioButtonFondBleu.TabIndex = 2;
            this.radioButtonFondBleu.Text = "Bleu";
            this.radioButtonFondBleu.UseVisualStyleBackColor = true;
            this.radioButtonFondBleu.CheckedChanged += new System.EventHandler(this.radioButtonFondBleu_CheckedChanged);
            // 
            // radioButtonFondVert
            // 
            this.radioButtonFondVert.AutoSize = true;
            this.radioButtonFondVert.Location = new System.Drawing.Point(6, 47);
            this.radioButtonFondVert.Name = "radioButtonFondVert";
            this.radioButtonFondVert.Size = new System.Drawing.Size(45, 19);
            this.radioButtonFondVert.TabIndex = 1;
            this.radioButtonFondVert.Text = "Vert";
            this.radioButtonFondVert.UseVisualStyleBackColor = true;
            this.radioButtonFondVert.CheckedChanged += new System.EventHandler(this.radioButtonFondVert_CheckedChanged);
            // 
            // radioButtonFondRouge
            // 
            this.radioButtonFondRouge.AutoSize = true;
            this.radioButtonFondRouge.Location = new System.Drawing.Point(6, 22);
            this.radioButtonFondRouge.Name = "radioButtonFondRouge";
            this.radioButtonFondRouge.Size = new System.Drawing.Size(59, 19);
            this.radioButtonFondRouge.TabIndex = 0;
            this.radioButtonFondRouge.TabStop = true;
            this.radioButtonFondRouge.Text = "Rouge";
            this.radioButtonFondRouge.UseVisualStyleBackColor = true;
            this.radioButtonFondRouge.CheckedChanged += new System.EventHandler(this.radioButtonFondRouge_CheckedChanged);
            // 
            // groupBoxCaracteres
            // 
            this.groupBoxCaracteres.Controls.Add(this.radioButtonCaracteresNoir);
            this.groupBoxCaracteres.Controls.Add(this.radioButtonCaracteresBlanc);
            this.groupBoxCaracteres.Controls.Add(this.radioButtonCaracteresRouge);
            this.groupBoxCaracteres.Location = new System.Drawing.Point(108, 143);
            this.groupBoxCaracteres.Name = "groupBoxCaracteres";
            this.groupBoxCaracteres.Size = new System.Drawing.Size(90, 106);
            this.groupBoxCaracteres.TabIndex = 2;
            this.groupBoxCaracteres.TabStop = false;
            this.groupBoxCaracteres.Text = "Caractères";
            this.groupBoxCaracteres.Visible = false;
            // 
            // radioButtonCaracteresNoir
            // 
            this.radioButtonCaracteresNoir.AutoSize = true;
            this.radioButtonCaracteresNoir.Location = new System.Drawing.Point(6, 72);
            this.radioButtonCaracteresNoir.Name = "radioButtonCaracteresNoir";
            this.radioButtonCaracteresNoir.Size = new System.Drawing.Size(48, 19);
            this.radioButtonCaracteresNoir.TabIndex = 10;
            this.radioButtonCaracteresNoir.TabStop = true;
            this.radioButtonCaracteresNoir.Text = "Noir";
            this.radioButtonCaracteresNoir.UseVisualStyleBackColor = true;
            this.radioButtonCaracteresNoir.CheckedChanged += new System.EventHandler(this.radioButtonCaracteresNoir_CheckedChanged);
            // 
            // radioButtonCaracteresBlanc
            // 
            this.radioButtonCaracteresBlanc.AutoSize = true;
            this.radioButtonCaracteresBlanc.Location = new System.Drawing.Point(6, 47);
            this.radioButtonCaracteresBlanc.Name = "radioButtonCaracteresBlanc";
            this.radioButtonCaracteresBlanc.Size = new System.Drawing.Size(54, 19);
            this.radioButtonCaracteresBlanc.TabIndex = 9;
            this.radioButtonCaracteresBlanc.TabStop = true;
            this.radioButtonCaracteresBlanc.Text = "Blanc";
            this.radioButtonCaracteresBlanc.UseVisualStyleBackColor = true;
            this.radioButtonCaracteresBlanc.CheckedChanged += new System.EventHandler(this.radioButtonCaracteresBlanc_CheckedChanged);
            // 
            // radioButtonCaracteresRouge
            // 
            this.radioButtonCaracteresRouge.AutoSize = true;
            this.radioButtonCaracteresRouge.Location = new System.Drawing.Point(6, 22);
            this.radioButtonCaracteresRouge.Name = "radioButtonCaracteresRouge";
            this.radioButtonCaracteresRouge.Size = new System.Drawing.Size(59, 19);
            this.radioButtonCaracteresRouge.TabIndex = 8;
            this.radioButtonCaracteresRouge.TabStop = true;
            this.radioButtonCaracteresRouge.Text = "Rouge";
            this.radioButtonCaracteresRouge.UseVisualStyleBackColor = true;
            this.radioButtonCaracteresRouge.CheckedChanged += new System.EventHandler(this.radioButtonCaracteresRouge_CheckedChanged);
            // 
            // groupBoxCasse
            // 
            this.groupBoxCasse.Controls.Add(this.radioButtonMajuscules);
            this.groupBoxCasse.Controls.Add(this.radioButtonMinuscules);
            this.groupBoxCasse.Location = new System.Drawing.Point(204, 171);
            this.groupBoxCasse.Name = "groupBoxCasse";
            this.groupBoxCasse.Size = new System.Drawing.Size(105, 78);
            this.groupBoxCasse.TabIndex = 3;
            this.groupBoxCasse.TabStop = false;
            this.groupBoxCasse.Text = "Casse";
            this.groupBoxCasse.Visible = false;
            // 
            // radioButtonMajuscules
            // 
            this.radioButtonMajuscules.AutoSize = true;
            this.radioButtonMajuscules.Location = new System.Drawing.Point(6, 47);
            this.radioButtonMajuscules.Name = "radioButtonMajuscules";
            this.radioButtonMajuscules.Size = new System.Drawing.Size(84, 19);
            this.radioButtonMajuscules.TabIndex = 12;
            this.radioButtonMajuscules.TabStop = true;
            this.radioButtonMajuscules.Text = "Majuscules";
            this.radioButtonMajuscules.UseVisualStyleBackColor = true;
            this.radioButtonMajuscules.CheckedChanged += new System.EventHandler(this.radioButtonMajuscules_CheckedChanged);
            // 
            // radioButtonMinuscules
            // 
            this.radioButtonMinuscules.AutoSize = true;
            this.radioButtonMinuscules.Location = new System.Drawing.Point(6, 22);
            this.radioButtonMinuscules.Name = "radioButtonMinuscules";
            this.radioButtonMinuscules.Size = new System.Drawing.Size(85, 19);
            this.radioButtonMinuscules.TabIndex = 11;
            this.radioButtonMinuscules.TabStop = true;
            this.radioButtonMinuscules.Text = "Minuscules";
            this.radioButtonMinuscules.UseVisualStyleBackColor = true;
            this.radioButtonMinuscules.CheckedChanged += new System.EventHandler(this.radioButtonMinuscules_CheckedChanged);
            // 
            // labelTexte
            // 
            this.labelTexte.AutoSize = true;
            this.labelTexte.Location = new System.Drawing.Point(12, 9);
            this.labelTexte.Name = "labelTexte";
            this.labelTexte.Size = new System.Drawing.Size(95, 15);
            this.labelTexte.TabIndex = 4;
            this.labelTexte.Text = "Tapez votre texte";
            // 
            // textBoxOrigine
            // 
            this.textBoxOrigine.Location = new System.Drawing.Point(12, 34);
            this.textBoxOrigine.Name = "textBoxOrigine";
            this.textBoxOrigine.Size = new System.Drawing.Size(256, 23);
            this.textBoxOrigine.TabIndex = 1;
            this.textBoxOrigine.TextChanged += new System.EventHandler(this.textBoxOrigine_TextChanged);
            // 
            // textBoxModifie
            // 
            this.textBoxModifie.BackColor = System.Drawing.SystemColors.Control;
            //this.textBoxModifie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBoxModifie.Location = new System.Drawing.Point(12, 84);
            this.textBoxModifie.Name = "textBoxModifie";
            this.textBoxModifie.Size = new System.Drawing.Size(256, 23);
            this.textBoxModifie.TabIndex = 6;
            // 
            // FormCheckBoxRadioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.textBoxModifie);
            this.Controls.Add(this.textBoxOrigine);
            this.Controls.Add(this.labelTexte);
            this.Controls.Add(this.groupBoxCasse);
            this.Controls.Add(this.groupBoxCaracteres);
            this.Controls.Add(this.groupBoxFond);
            this.Controls.Add(this.groupBoxChoix);
            this.Name = "FormCheckBoxRadioButton";
            this.Text = "CheckBox RadioButton";
            this.groupBoxChoix.ResumeLayout(false);
            this.groupBoxChoix.PerformLayout();
            this.groupBoxFond.ResumeLayout(false);
            this.groupBoxFond.PerformLayout();
            this.groupBoxCaracteres.ResumeLayout(false);
            this.groupBoxCaracteres.PerformLayout();
            this.groupBoxCasse.ResumeLayout(false);
            this.groupBoxCasse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBoxChoix;
        private CheckBox checkBoxCasse;
        private CheckBox checkBoxCaracteres;
        private CheckBox checkBoxFond;
        private GroupBox groupBoxFond;
        private RadioButton radioButtonFondBleu;
        private RadioButton radioButtonFondVert;
        private RadioButton radioButtonFondRouge;
        private GroupBox groupBoxCaracteres;
        private RadioButton radioButtonCaracteresNoir;
        private RadioButton radioButtonCaracteresBlanc;
        private RadioButton radioButtonCaracteresRouge;
        private GroupBox groupBoxCasse;
        private RadioButton radioButtonMajuscules;
        private RadioButton radioButtonMinuscules;
        private Label labelTexte;
        private TextBox textBoxOrigine;
        private TextBox textBoxModifie;
    }
}