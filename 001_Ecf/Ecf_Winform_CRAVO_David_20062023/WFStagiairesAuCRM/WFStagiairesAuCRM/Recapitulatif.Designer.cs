namespace WFStagiairesAuCRM
{
    partial class Recapitulatif
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
            labelSection = new Label();
            SuspendLayout();
            // 
            // labelSection
            // 
            labelSection.AutoSize = true;
            labelSection.BackColor = Color.Lime;
            labelSection.Location = new Point(32, 71);
            labelSection.Name = "labelSection";
            labelSection.Size = new Size(55, 15);
            labelSection.TabIndex = 0;
            labelSection.Text = "Section : ";
            // 
            // Recapitulatif
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 168);
            Controls.Add(labelSection);
            Name = "Recapitulatif";
            Text = "Recapitulatif";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSection;
    }
}