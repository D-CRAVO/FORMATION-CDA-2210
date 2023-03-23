namespace WFSaisie
{
    partial class FormSaisie
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
            textBoxTexte = new TextBox();
            buttonValider = new Button();
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
            // textBoxTexte
            // 
            textBoxTexte.Location = new Point(12, 27);
            textBoxTexte.Name = "textBoxTexte";
            textBoxTexte.Size = new Size(301, 23);
            textBoxTexte.TabIndex = 1;
            // 
            // buttonValider
            // 
            buttonValider.Location = new Point(337, 27);
            buttonValider.Name = "buttonValider";
            buttonValider.Size = new Size(75, 23);
            buttonValider.TabIndex = 2;
            buttonValider.Text = "Valider";
            buttonValider.UseVisualStyleBackColor = true;
            buttonValider.Click += buttonValider_Click;
            // 
            // FormSaisie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 70);
            Controls.Add(buttonValider);
            Controls.Add(textBoxTexte);
            Controls.Add(labelTexte);
            Name = "FormSaisie";
            Text = "FormSaisie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTexte;
        private TextBox textBoxTexte;
        private Button buttonValider;
    }
}