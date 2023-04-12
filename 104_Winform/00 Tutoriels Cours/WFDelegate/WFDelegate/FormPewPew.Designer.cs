namespace WFDelegate
{
    partial class FormPewPew
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
            textBoxNom = new TextBox();
            buttonValider = new Button();
            buttonAnnuler = new Button();
            SuspendLayout();
            // 
            // textBoxNom
            // 
            textBoxNom.Location = new Point(111, 103);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(100, 23);
            textBoxNom.TabIndex = 0;
            // 
            // buttonValider
            // 
            buttonValider.DialogResult = DialogResult.OK;
            buttonValider.Location = new Point(254, 250);
            buttonValider.Name = "buttonValider";
            buttonValider.Size = new Size(75, 23);
            buttonValider.TabIndex = 1;
            buttonValider.Text = "Valider";
            buttonValider.UseVisualStyleBackColor = true;
            buttonValider.Click += buttonValider_Click;
            // 
            // buttonAnnuler
            // 
            buttonAnnuler.DialogResult = DialogResult.Cancel;
            buttonAnnuler.Location = new Point(151, 250);
            buttonAnnuler.Name = "buttonAnnuler";
            buttonAnnuler.Size = new Size(75, 23);
            buttonAnnuler.TabIndex = 2;
            buttonAnnuler.Text = "Annuler";
            buttonAnnuler.UseVisualStyleBackColor = true;
            buttonAnnuler.Click += buttonAnnuler_Click;
            // 
            // FormPewPew
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 343);
            Controls.Add(buttonAnnuler);
            Controls.Add(buttonValider);
            Controls.Add(textBoxNom);
            Name = "FormPewPew";
            Text = "FormPewPew";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNom;
        private Button buttonValider;
        private Button buttonAnnuler;
    }
}