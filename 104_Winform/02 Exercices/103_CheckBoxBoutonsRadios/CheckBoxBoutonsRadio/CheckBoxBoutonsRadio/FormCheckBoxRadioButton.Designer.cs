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
            groupBoxChoix = new GroupBox();
            checkBoxCasse = new CheckBox();
            checkBoxCaracteres = new CheckBox();
            checkBoxFond = new CheckBox();
            groupBoxFond = new GroupBox();
            radioButtonFondBleu = new RadioButton();
            radioButtonFondVert = new RadioButton();
            radioButtonFondRouge = new RadioButton();
            groupBoxCaracteres = new GroupBox();
            radioButtonCaracteresNoir = new RadioButton();
            radioButtonCaracteresBlanc = new RadioButton();
            radioButtonCaracteresRouge = new RadioButton();
            groupBoxCasse = new GroupBox();
            radioButtonMajuscules = new RadioButton();
            radioButtonMinuscules = new RadioButton();
            labelTexte = new Label();
            textBoxOrigine = new TextBox();
            textBoxModifie = new TextBox();
            groupBoxChoix.SuspendLayout();
            groupBoxFond.SuspendLayout();
            groupBoxCaracteres.SuspendLayout();
            groupBoxCasse.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxChoix
            // 
            groupBoxChoix.Controls.Add(checkBoxCasse);
            groupBoxChoix.Controls.Add(checkBoxCaracteres);
            groupBoxChoix.Controls.Add(checkBoxFond);
            groupBoxChoix.Enabled = false;
            groupBoxChoix.Location = new Point(292, 12);
            groupBoxChoix.Name = "groupBoxChoix";
            groupBoxChoix.Size = new Size(180, 99);
            groupBoxChoix.TabIndex = 0;
            groupBoxChoix.TabStop = false;
            groupBoxChoix.Text = "Choix";
            // 
            // checkBoxCasse
            // 
            checkBoxCasse.AutoSize = true;
            checkBoxCasse.Location = new Point(9, 76);
            checkBoxCasse.Name = "checkBoxCasse";
            checkBoxCasse.Size = new Size(56, 19);
            checkBoxCasse.TabIndex = 4;
            checkBoxCasse.Text = "Casse";
            checkBoxCasse.UseVisualStyleBackColor = true;
            checkBoxCasse.CheckedChanged += checkBoxCasse_CheckedChanged;
            // 
            // checkBoxCaracteres
            // 
            checkBoxCaracteres.AutoSize = true;
            checkBoxCaracteres.Location = new Point(9, 51);
            checkBoxCaracteres.Name = "checkBoxCaracteres";
            checkBoxCaracteres.Size = new Size(145, 19);
            checkBoxCaracteres.TabIndex = 3;
            checkBoxCaracteres.Text = "Couleur des caractères";
            checkBoxCaracteres.UseVisualStyleBackColor = true;
            checkBoxCaracteres.CheckedChanged += checkBoxCaracteres_CheckedChanged;
            // 
            // checkBoxFond
            // 
            checkBoxFond.AutoSize = true;
            checkBoxFond.Location = new Point(9, 26);
            checkBoxFond.Name = "checkBoxFond";
            checkBoxFond.Size = new Size(112, 19);
            checkBoxFond.TabIndex = 2;
            checkBoxFond.Text = "Couleur de fond";
            checkBoxFond.UseVisualStyleBackColor = true;
            checkBoxFond.CheckedChanged += checkBoxFond_CheckedChanged;
            // 
            // groupBoxFond
            // 
            groupBoxFond.Controls.Add(radioButtonFondBleu);
            groupBoxFond.Controls.Add(radioButtonFondVert);
            groupBoxFond.Controls.Add(radioButtonFondRouge);
            groupBoxFond.Location = new Point(12, 143);
            groupBoxFond.Name = "groupBoxFond";
            groupBoxFond.Size = new Size(90, 106);
            groupBoxFond.TabIndex = 1;
            groupBoxFond.TabStop = false;
            groupBoxFond.Text = "Fond";
            groupBoxFond.Visible = false;
            // 
            // radioButtonFondBleu
            // 
            radioButtonFondBleu.AutoSize = true;
            radioButtonFondBleu.Location = new Point(6, 72);
            radioButtonFondBleu.Name = "radioButtonFondBleu";
            radioButtonFondBleu.Size = new Size(48, 19);
            radioButtonFondBleu.TabIndex = 2;
            radioButtonFondBleu.Text = "Bleu";
            radioButtonFondBleu.UseVisualStyleBackColor = true;
            radioButtonFondBleu.CheckedChanged += radioButtonFondBleu_CheckedChanged;
            // 
            // radioButtonFondVert
            // 
            radioButtonFondVert.AutoSize = true;
            radioButtonFondVert.Location = new Point(6, 47);
            radioButtonFondVert.Name = "radioButtonFondVert";
            radioButtonFondVert.Size = new Size(45, 19);
            radioButtonFondVert.TabIndex = 1;
            radioButtonFondVert.Text = "Vert";
            radioButtonFondVert.UseVisualStyleBackColor = true;
            radioButtonFondVert.CheckedChanged += radioButtonFondVert_CheckedChanged;
            // 
            // radioButtonFondRouge
            // 
            radioButtonFondRouge.AutoSize = true;
            radioButtonFondRouge.Location = new Point(6, 22);
            radioButtonFondRouge.Name = "radioButtonFondRouge";
            radioButtonFondRouge.Size = new Size(59, 19);
            radioButtonFondRouge.TabIndex = 0;
            radioButtonFondRouge.TabStop = true;
            radioButtonFondRouge.Text = "Rouge";
            radioButtonFondRouge.UseVisualStyleBackColor = true;
            radioButtonFondRouge.CheckedChanged += radioButtonFondRouge_CheckedChanged;
            // 
            // groupBoxCaracteres
            // 
            groupBoxCaracteres.Controls.Add(radioButtonCaracteresNoir);
            groupBoxCaracteres.Controls.Add(radioButtonCaracteresBlanc);
            groupBoxCaracteres.Controls.Add(radioButtonCaracteresRouge);
            groupBoxCaracteres.Location = new Point(108, 143);
            groupBoxCaracteres.Name = "groupBoxCaracteres";
            groupBoxCaracteres.Size = new Size(90, 106);
            groupBoxCaracteres.TabIndex = 2;
            groupBoxCaracteres.TabStop = false;
            groupBoxCaracteres.Text = "Caractères";
            groupBoxCaracteres.Visible = false;
            // 
            // radioButtonCaracteresNoir
            // 
            radioButtonCaracteresNoir.AutoSize = true;
            radioButtonCaracteresNoir.Location = new Point(6, 72);
            radioButtonCaracteresNoir.Name = "radioButtonCaracteresNoir";
            radioButtonCaracteresNoir.Size = new Size(48, 19);
            radioButtonCaracteresNoir.TabIndex = 10;
            radioButtonCaracteresNoir.TabStop = true;
            radioButtonCaracteresNoir.Text = "Noir";
            radioButtonCaracteresNoir.UseVisualStyleBackColor = true;
            radioButtonCaracteresNoir.CheckedChanged += radioButtonCaracteresNoir_CheckedChanged;
            // 
            // radioButtonCaracteresBlanc
            // 
            radioButtonCaracteresBlanc.AutoSize = true;
            radioButtonCaracteresBlanc.Location = new Point(6, 47);
            radioButtonCaracteresBlanc.Name = "radioButtonCaracteresBlanc";
            radioButtonCaracteresBlanc.Size = new Size(54, 19);
            radioButtonCaracteresBlanc.TabIndex = 9;
            radioButtonCaracteresBlanc.TabStop = true;
            radioButtonCaracteresBlanc.Text = "Blanc";
            radioButtonCaracteresBlanc.UseVisualStyleBackColor = true;
            radioButtonCaracteresBlanc.CheckedChanged += radioButtonCaracteresBlanc_CheckedChanged;
            // 
            // radioButtonCaracteresRouge
            // 
            radioButtonCaracteresRouge.AutoSize = true;
            radioButtonCaracteresRouge.Location = new Point(6, 22);
            radioButtonCaracteresRouge.Name = "radioButtonCaracteresRouge";
            radioButtonCaracteresRouge.Size = new Size(59, 19);
            radioButtonCaracteresRouge.TabIndex = 8;
            radioButtonCaracteresRouge.TabStop = true;
            radioButtonCaracteresRouge.Text = "Rouge";
            radioButtonCaracteresRouge.UseVisualStyleBackColor = true;
            radioButtonCaracteresRouge.CheckedChanged += radioButtonCaracteresRouge_CheckedChanged;
            // 
            // groupBoxCasse
            // 
            groupBoxCasse.Controls.Add(radioButtonMajuscules);
            groupBoxCasse.Controls.Add(radioButtonMinuscules);
            groupBoxCasse.Location = new Point(204, 171);
            groupBoxCasse.Name = "groupBoxCasse";
            groupBoxCasse.Size = new Size(105, 78);
            groupBoxCasse.TabIndex = 3;
            groupBoxCasse.TabStop = false;
            groupBoxCasse.Text = "Casse";
            groupBoxCasse.Visible = false;
            // 
            // radioButtonMajuscules
            // 
            radioButtonMajuscules.AutoSize = true;
            radioButtonMajuscules.Location = new Point(6, 47);
            radioButtonMajuscules.Name = "radioButtonMajuscules";
            radioButtonMajuscules.Size = new Size(84, 19);
            radioButtonMajuscules.TabIndex = 12;
            radioButtonMajuscules.TabStop = true;
            radioButtonMajuscules.Text = "Majuscules";
            radioButtonMajuscules.UseVisualStyleBackColor = true;
            radioButtonMajuscules.CheckedChanged += radioButtonMajuscules_CheckedChanged;
            // 
            // radioButtonMinuscules
            // 
            radioButtonMinuscules.AutoSize = true;
            radioButtonMinuscules.Location = new Point(6, 22);
            radioButtonMinuscules.Name = "radioButtonMinuscules";
            radioButtonMinuscules.Size = new Size(85, 19);
            radioButtonMinuscules.TabIndex = 11;
            radioButtonMinuscules.TabStop = true;
            radioButtonMinuscules.Text = "Minuscules";
            radioButtonMinuscules.UseVisualStyleBackColor = true;
            radioButtonMinuscules.CheckedChanged += radioButtonMinuscules_CheckedChanged;
            // 
            // labelTexte
            // 
            labelTexte.AutoSize = true;
            labelTexte.Location = new Point(12, 9);
            labelTexte.Name = "labelTexte";
            labelTexte.Size = new Size(95, 15);
            labelTexte.TabIndex = 4;
            labelTexte.Text = "Tapez votre texte";
            // 
            // textBoxOrigine
            // 
            textBoxOrigine.Location = new Point(12, 34);
            textBoxOrigine.Name = "textBoxOrigine";
            textBoxOrigine.Size = new Size(256, 23);
            textBoxOrigine.TabIndex = 1;
            textBoxOrigine.TextChanged += textBoxOrigine_TextChanged;
            // 
            // textBoxModifie
            // 
            textBoxModifie.Location = new Point(12, 84);
            textBoxModifie.Name = "textBoxModifie";
            textBoxModifie.ReadOnly = true;
            textBoxModifie.Size = new Size(256, 23);
            textBoxModifie.TabIndex = 6;
            // 
            // FormCheckBoxRadioButton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(textBoxModifie);
            Controls.Add(textBoxOrigine);
            Controls.Add(labelTexte);
            Controls.Add(groupBoxCasse);
            Controls.Add(groupBoxCaracteres);
            Controls.Add(groupBoxFond);
            Controls.Add(groupBoxChoix);
            Name = "FormCheckBoxRadioButton";
            Text = "CheckBox RadioButton";
            groupBoxChoix.ResumeLayout(false);
            groupBoxChoix.PerformLayout();
            groupBoxFond.ResumeLayout(false);
            groupBoxFond.PerformLayout();
            groupBoxCaracteres.ResumeLayout(false);
            groupBoxCaracteres.PerformLayout();
            groupBoxCasse.ResumeLayout(false);
            groupBoxCasse.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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