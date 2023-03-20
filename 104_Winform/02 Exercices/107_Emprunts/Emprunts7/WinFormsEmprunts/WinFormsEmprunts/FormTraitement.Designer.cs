namespace WinFormsEmprunts
{
    partial class FormTraitement
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
            this.components = new System.ComponentModel.Container();
            this.buttonFermer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarTraitement = new System.Windows.Forms.ProgressBar();
            this.timerTraitement = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonFermer
            // 
            this.buttonFermer.Location = new System.Drawing.Point(114, 107);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(75, 23);
            this.buttonFermer.TabIndex = 5;
            this.buttonFermer.Text = "Fermer";
            this.buttonFermer.UseVisualStyleBackColor = true;
            this.buttonFermer.Visible = false;
            this.buttonFermer.Click += new System.EventHandler(this.buttonFermer_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(73, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Traitement en cours ...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBarTraitement
            // 
            this.progressBarTraitement.Location = new System.Drawing.Point(73, 62);
            this.progressBarTraitement.Name = "progressBarTraitement";
            this.progressBarTraitement.Size = new System.Drawing.Size(150, 23);
            this.progressBarTraitement.TabIndex = 3;
            // 
            // timerTraitement
            // 
            this.timerTraitement.Interval = 25;
            this.timerTraitement.Tick += new System.EventHandler(this.timerTraitement_Tick);
            // 
            // FormTraitement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 158);
            this.Controls.Add(this.buttonFermer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarTraitement);
            this.Name = "FormTraitement";
            this.Text = "FormTraitement";
            //FormClosing += FormTraitement_FormClosing;
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonFermer;
        private Label label1;
        private ProgressBar progressBarTraitement;
        private System.Windows.Forms.Timer timerTraitement;
    }
}