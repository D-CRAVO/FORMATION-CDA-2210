namespace Emprunts
{
    partial class Traitement
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
            progressBarTraitement = new ProgressBar();
            label1 = new Label();
            SuspendLayout();
            // 
            // progressBarTraitement
            // 
            progressBarTraitement.Location = new Point(88, 86);
            progressBarTraitement.Name = "progressBarTraitement";
            progressBarTraitement.Size = new Size(150, 23);
            progressBarTraitement.TabIndex = 0;
            progressBarTraitement.Click += progressBar1_Click;
            // 
            // label1
            // 
            label1.Location = new Point(88, 35);
            label1.Name = "label1";
            label1.Size = new Size(150, 15);
            label1.TabIndex = 1;
            label1.Text = "Traitement en cours ...";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Traitement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 150);
            Controls.Add(label1);
            Controls.Add(progressBarTraitement);
            Name = "Traitement";
            Text = "Traitement";
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBarTraitement;
        private Label label1;
    }
}