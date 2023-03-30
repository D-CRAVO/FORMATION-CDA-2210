namespace WFSaisieTexte
{
    partial class FormSaisieTexte
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
            textBoxTexte = new TextBox();
            buttonValider = new Button();
            labelTexte = new Label();
            SuspendLayout();
            // 
            // textBoxTexte
            // 
            textBoxTexte.Location = new Point(12, 43);
            textBoxTexte.Name = "textBoxTexte";
            textBoxTexte.Size = new Size(272, 23);
            textBoxTexte.TabIndex = 0;
            // 
            // buttonValider
            // 
            buttonValider.Location = new Point(310, 43);
            buttonValider.Name = "buttonValider";
            buttonValider.Size = new Size(75, 23);
            buttonValider.TabIndex = 1;
            buttonValider.Text = "Valider";
            buttonValider.UseVisualStyleBackColor = true;
            buttonValider.Click += buttonValider_Click;
            // 
            // labelTexte
            // 
            labelTexte.AutoSize = true;
            labelTexte.Location = new Point(15, 14);
            labelTexte.Name = "labelTexte";
            labelTexte.Size = new Size(95, 15);
            labelTexte.TabIndex = 2;
            labelTexte.Text = "Tapez votre texte";
            // 
            // FormSaisieTexte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 86);
            Controls.Add(labelTexte);
            Controls.Add(buttonValider);
            Controls.Add(textBoxTexte);
            Name = "FormSaisieTexte";
            Text = "FormSaisieTexte";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTexte;
        private Button buttonValider;
        private Label labelTexte;
    }
}