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
            components = new System.ComponentModel.Container();
            progressBarTraitement = new ProgressBar();
            label1 = new Label();
            timerTraitement = new System.Windows.Forms.Timer(components);
            buttonFermer = new Button();
            SuspendLayout();
            // 
            // progressBarTraitement
            // 
            progressBarTraitement.Location = new Point(88, 70);
            progressBarTraitement.Name = "progressBarTraitement";
            progressBarTraitement.Size = new Size(150, 23);
            progressBarTraitement.TabIndex = 0;
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
            // timerTraitement
            // 
            timerTraitement.Interval = 30;
            timerTraitement.Tick += timer1_Tick;
            // 
            // buttonFermer
            // 
            buttonFermer.Location = new Point(129, 115);
            buttonFermer.Name = "buttonFermer";
            buttonFermer.Size = new Size(75, 23);
            buttonFermer.TabIndex = 2;
            buttonFermer.Text = "Fermer";
            buttonFermer.UseVisualStyleBackColor = true;
            buttonFermer.Visible = false;
            buttonFermer.Click += buttonFermer_Click;
            // 
            // Traitement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 150);
            Controls.Add(buttonFermer);
            Controls.Add(label1);
            Controls.Add(progressBarTraitement);
            Name = "Traitement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Traitement";
            FormClosing += Traitement_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBarTraitement;
        private Label label1;
        private System.Windows.Forms.Timer timerTraitement;
        private Button buttonFermer;
    }
}