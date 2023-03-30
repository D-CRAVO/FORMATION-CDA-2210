namespace WFCheckBoxRadioButton
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
            labelTexte = new Label();
            textBoxTexteOrigine = new TextBox();
            groupBoxChoix = new GroupBox();
            checkBoxCasse = new CheckBox();
            checkBoxCouleurCaracteres = new CheckBox();
            checkBoxCouleurFond = new CheckBox();
            groupBoxFond = new GroupBox();
            radioButtonFondVert = new RadioButton();
            radioButtonFondBleu = new RadioButton();
            radioButtonFondRouge = new RadioButton();
            groupBoxCaracteres = new GroupBox();
            radioButtonCaracteresNoir = new RadioButton();
            radioButtonCaracteresBlanc = new RadioButton();
            radioButtonCaracteresRouge = new RadioButton();
            groupBoxCasse = new GroupBox();
            radioButtonMajuscules = new RadioButton();
            radioButtonMinuscules = new RadioButton();
            labelTexteModifie = new Label();
            groupBoxChoix.SuspendLayout();
            groupBoxFond.SuspendLayout();
            groupBoxCaracteres.SuspendLayout();
            groupBoxCasse.SuspendLayout();
            SuspendLayout();
            // 
            // labelTexte
            // 
            labelTexte.AutoSize = true;
            labelTexte.Location = new Point(12, 9);
            labelTexte.Name = "labelTexte";
            labelTexte.Size = new Size(95, 15);
            labelTexte.TabIndex = 0;
            labelTexte.Text = "Tapez votre texte";
            // 
            // textBoxTexteOrigine
            // 
            textBoxTexteOrigine.Location = new Point(12, 38);
            textBoxTexteOrigine.Name = "textBoxTexteOrigine";
            textBoxTexteOrigine.Size = new Size(250, 23);
            textBoxTexteOrigine.TabIndex = 1;
            textBoxTexteOrigine.TextChanged += textBoxTexteOrigine_TextChanged;
            // 
            // groupBoxChoix
            // 
            groupBoxChoix.Controls.Add(checkBoxCasse);
            groupBoxChoix.Controls.Add(checkBoxCouleurCaracteres);
            groupBoxChoix.Controls.Add(checkBoxCouleurFond);
            groupBoxChoix.Enabled = false;
            groupBoxChoix.Location = new Point(278, 12);
            groupBoxChoix.Name = "groupBoxChoix";
            groupBoxChoix.Size = new Size(162, 100);
            groupBoxChoix.TabIndex = 3;
            groupBoxChoix.TabStop = false;
            groupBoxChoix.Text = "Choix";
            // 
            // checkBoxCasse
            // 
            checkBoxCasse.AutoSize = true;
            checkBoxCasse.Location = new Point(6, 72);
            checkBoxCasse.Name = "checkBoxCasse";
            checkBoxCasse.Size = new Size(56, 19);
            checkBoxCasse.TabIndex = 2;
            checkBoxCasse.Text = "Casse";
            checkBoxCasse.UseVisualStyleBackColor = true;
            checkBoxCasse.CheckedChanged += checkBoxCasse_CheckedChanged;
            // 
            // checkBoxCouleurCaracteres
            // 
            checkBoxCouleurCaracteres.AutoSize = true;
            checkBoxCouleurCaracteres.Location = new Point(6, 47);
            checkBoxCouleurCaracteres.Name = "checkBoxCouleurCaracteres";
            checkBoxCouleurCaracteres.Size = new Size(145, 19);
            checkBoxCouleurCaracteres.TabIndex = 1;
            checkBoxCouleurCaracteres.Text = "Couleur des caractères";
            checkBoxCouleurCaracteres.UseVisualStyleBackColor = true;
            checkBoxCouleurCaracteres.CheckedChanged += checkBoxCouleurCaracteres_CheckedChanged;
            // 
            // checkBoxCouleurFond
            // 
            checkBoxCouleurFond.AutoSize = true;
            checkBoxCouleurFond.Location = new Point(6, 22);
            checkBoxCouleurFond.Name = "checkBoxCouleurFond";
            checkBoxCouleurFond.Size = new Size(112, 19);
            checkBoxCouleurFond.TabIndex = 0;
            checkBoxCouleurFond.Text = "Couleur de fond";
            checkBoxCouleurFond.UseVisualStyleBackColor = true;
            checkBoxCouleurFond.CheckedChanged += checkBoxCouleurFond_CheckedChanged;
            // 
            // groupBoxFond
            // 
            groupBoxFond.Controls.Add(radioButtonFondVert);
            groupBoxFond.Controls.Add(radioButtonFondBleu);
            groupBoxFond.Controls.Add(radioButtonFondRouge);
            groupBoxFond.Location = new Point(12, 142);
            groupBoxFond.Name = "groupBoxFond";
            groupBoxFond.Size = new Size(95, 100);
            groupBoxFond.TabIndex = 4;
            groupBoxFond.TabStop = false;
            groupBoxFond.Text = "Fond";
            groupBoxFond.Visible = false;
            // 
            // radioButtonFondVert
            // 
            radioButtonFondVert.AutoSize = true;
            radioButtonFondVert.Location = new Point(6, 47);
            radioButtonFondVert.Name = "radioButtonFondVert";
            radioButtonFondVert.Size = new Size(45, 19);
            radioButtonFondVert.TabIndex = 2;
            radioButtonFondVert.TabStop = true;
            radioButtonFondVert.Text = "Vert";
            radioButtonFondVert.UseVisualStyleBackColor = true;
            radioButtonFondVert.CheckedChanged += radioButtonFondVert_CheckedChanged;
            // 
            // radioButtonFondBleu
            // 
            radioButtonFondBleu.AutoSize = true;
            radioButtonFondBleu.Location = new Point(6, 72);
            radioButtonFondBleu.Name = "radioButtonFondBleu";
            radioButtonFondBleu.Size = new Size(48, 19);
            radioButtonFondBleu.TabIndex = 1;
            radioButtonFondBleu.TabStop = true;
            radioButtonFondBleu.Text = "Bleu";
            radioButtonFondBleu.UseVisualStyleBackColor = true;
            radioButtonFondBleu.CheckedChanged += radioButtonFondBleu_CheckedChanged;
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
            groupBoxCaracteres.Location = new Point(113, 142);
            groupBoxCaracteres.Name = "groupBoxCaracteres";
            groupBoxCaracteres.Size = new Size(98, 100);
            groupBoxCaracteres.TabIndex = 5;
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
            radioButtonCaracteresNoir.TabIndex = 2;
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
            radioButtonCaracteresBlanc.TabIndex = 1;
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
            radioButtonCaracteresRouge.TabIndex = 0;
            radioButtonCaracteresRouge.TabStop = true;
            radioButtonCaracteresRouge.Text = "Rouge";
            radioButtonCaracteresRouge.UseVisualStyleBackColor = true;
            radioButtonCaracteresRouge.CheckedChanged += radioButtonCaracteresRouge_CheckedChanged;
            // 
            // groupBoxCasse
            // 
            groupBoxCasse.Controls.Add(radioButtonMajuscules);
            groupBoxCasse.Controls.Add(radioButtonMinuscules);
            groupBoxCasse.Location = new Point(217, 164);
            groupBoxCasse.Name = "groupBoxCasse";
            groupBoxCasse.Size = new Size(104, 78);
            groupBoxCasse.TabIndex = 6;
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
            radioButtonMajuscules.TabIndex = 1;
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
            radioButtonMinuscules.TabIndex = 0;
            radioButtonMinuscules.TabStop = true;
            radioButtonMinuscules.Text = "Minuscules";
            radioButtonMinuscules.UseVisualStyleBackColor = true;
            radioButtonMinuscules.CheckedChanged += radioButtonMinuscules_CheckedChanged;
            // 
            // labelTexteModifie
            // 
            labelTexteModifie.AutoSize = true;
            labelTexteModifie.Location = new Point(18, 97);
            labelTexteModifie.Name = "labelTexteModifie";
            labelTexteModifie.Size = new Size(0, 15);
            labelTexteModifie.TabIndex = 7;
            // 
            // FormCheckBoxRadioButton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 251);
            Controls.Add(labelTexteModifie);
            Controls.Add(groupBoxCasse);
            Controls.Add(groupBoxCaracteres);
            Controls.Add(groupBoxFond);
            Controls.Add(groupBoxChoix);
            Controls.Add(textBoxTexteOrigine);
            Controls.Add(labelTexte);
            Name = "FormCheckBoxRadioButton";
            Text = "FormCheckBoxRadioButton";
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

        private Label labelTexte;
        private TextBox textBoxTexteOrigine;
        private GroupBox groupBoxChoix;
        private CheckBox checkBoxCasse;
        private CheckBox checkBoxCouleurCaracteres;
        private CheckBox checkBoxCouleurFond;
        private GroupBox groupBoxFond;
        private RadioButton radioButtonFondVert;
        private RadioButton radioButtonFondBleu;
        private RadioButton radioButtonFondRouge;
        private GroupBox groupBoxCaracteres;
        private RadioButton radioButtonCaracteresNoir;
        private RadioButton radioButtonCaracteresBlanc;
        private RadioButton radioButtonCaracteresRouge;
        private GroupBox groupBoxCasse;
        private RadioButton radioButtonMajuscules;
        private RadioButton radioButtonMinuscules;
        private Label labelTexteModifie;
    }
}