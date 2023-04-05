namespace WFDefilementCouleurs
{
    partial class FormDefilementCouleurs
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
            labelRouge = new Label();
            labelVert = new Label();
            labelBleu = new Label();
            hScrollBarRouge = new HScrollBar();
            hScrollBarBleu = new HScrollBar();
            hScrollBarVert = new HScrollBar();
            textBoxRouge = new TextBox();
            textBoxBleu = new TextBox();
            textBoxVert = new TextBox();
            numericUpDownRouge = new NumericUpDown();
            numericUpDownBleu = new NumericUpDown();
            numericUpDownVert = new NumericUpDown();
            textBoxCouleurs = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRouge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBleu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVert).BeginInit();
            SuspendLayout();
            // 
            // labelRouge
            // 
            labelRouge.AutoSize = true;
            labelRouge.Location = new Point(36, 50);
            labelRouge.Name = "labelRouge";
            labelRouge.Size = new Size(41, 15);
            labelRouge.TabIndex = 0;
            labelRouge.Text = "Rouge";
            // 
            // labelVert
            // 
            labelVert.AutoSize = true;
            labelVert.Location = new Point(36, 78);
            labelVert.Name = "labelVert";
            labelVert.Size = new Size(27, 15);
            labelVert.TabIndex = 1;
            labelVert.Text = "Vert";
            // 
            // labelBleu
            // 
            labelBleu.AutoSize = true;
            labelBleu.Location = new Point(33, 107);
            labelBleu.Name = "labelBleu";
            labelBleu.Size = new Size(30, 15);
            labelBleu.TabIndex = 2;
            labelBleu.Text = "Bleu";
            // 
            // hScrollBarRouge
            // 
            hScrollBarRouge.Location = new Point(109, 42);
            hScrollBarRouge.Maximum = 264;
            hScrollBarRouge.Name = "hScrollBarRouge";
            hScrollBarRouge.Size = new Size(236, 23);
            hScrollBarRouge.TabIndex = 3;
            hScrollBarRouge.Scroll += hScrollBarRouge_Scroll;
            // 
            // hScrollBarBleu
            // 
            hScrollBarBleu.Location = new Point(109, 99);
            hScrollBarBleu.Maximum = 264;
            hScrollBarBleu.Name = "hScrollBarBleu";
            hScrollBarBleu.Size = new Size(236, 23);
            hScrollBarBleu.TabIndex = 4;
            hScrollBarBleu.Scroll += hScrollBarBleu_Scroll;
            // 
            // hScrollBarVert
            // 
            hScrollBarVert.Location = new Point(109, 70);
            hScrollBarVert.Maximum = 264;
            hScrollBarVert.Name = "hScrollBarVert";
            hScrollBarVert.Size = new Size(236, 23);
            hScrollBarVert.TabIndex = 5;
            hScrollBarVert.Scroll += hScrollBarVert_Scroll;
            // 
            // textBoxRouge
            // 
            textBoxRouge.Location = new Point(421, 41);
            textBoxRouge.Name = "textBoxRouge";
            textBoxRouge.Size = new Size(61, 23);
            textBoxRouge.TabIndex = 6;
            // 
            // textBoxBleu
            // 
            textBoxBleu.Location = new Point(421, 99);
            textBoxBleu.Name = "textBoxBleu";
            textBoxBleu.Size = new Size(61, 23);
            textBoxBleu.TabIndex = 7;
            // 
            // textBoxVert
            // 
            textBoxVert.Location = new Point(421, 70);
            textBoxVert.Name = "textBoxVert";
            textBoxVert.Size = new Size(61, 23);
            textBoxVert.TabIndex = 8;
            // 
            // numericUpDownRouge
            // 
            numericUpDownRouge.Location = new Point(348, 42);
            numericUpDownRouge.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownRouge.Name = "numericUpDownRouge";
            numericUpDownRouge.Size = new Size(67, 23);
            numericUpDownRouge.TabIndex = 9;
            // 
            // numericUpDownBleu
            // 
            numericUpDownBleu.Location = new Point(348, 99);
            numericUpDownBleu.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownBleu.Name = "numericUpDownBleu";
            numericUpDownBleu.Size = new Size(67, 23);
            numericUpDownBleu.TabIndex = 10;
            // 
            // numericUpDownVert
            // 
            numericUpDownVert.Location = new Point(348, 70);
            numericUpDownVert.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownVert.Name = "numericUpDownVert";
            numericUpDownVert.Size = new Size(67, 23);
            numericUpDownVert.TabIndex = 11;
            // 
            // textBoxCouleurs
            // 
            textBoxCouleurs.Location = new Point(36, 128);
            textBoxCouleurs.Multiline = true;
            textBoxCouleurs.Name = "textBoxCouleurs";
            textBoxCouleurs.Size = new Size(446, 60);
            textBoxCouleurs.TabIndex = 12;
            // 
            // FormDefilementCouleurs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 208);
            Controls.Add(textBoxCouleurs);
            Controls.Add(numericUpDownVert);
            Controls.Add(numericUpDownBleu);
            Controls.Add(numericUpDownRouge);
            Controls.Add(textBoxVert);
            Controls.Add(textBoxBleu);
            Controls.Add(textBoxRouge);
            Controls.Add(hScrollBarVert);
            Controls.Add(hScrollBarBleu);
            Controls.Add(hScrollBarRouge);
            Controls.Add(labelBleu);
            Controls.Add(labelVert);
            Controls.Add(labelRouge);
            Name = "FormDefilementCouleurs";
            Text = "FormDefilementCouleurs";
            ((System.ComponentModel.ISupportInitialize)numericUpDownRouge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBleu).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVert).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRouge;
        private Label labelVert;
        private Label labelBleu;
        private HScrollBar hScrollBarRouge;
        private HScrollBar hScrollBarBleu;
        private HScrollBar hScrollBarVert;
        private TextBox textBoxRouge;
        private TextBox textBoxBleu;
        private TextBox textBoxVert;
        private NumericUpDown numericUpDownRouge;
        private NumericUpDown numericUpDownBleu;
        private NumericUpDown numericUpDownVert;
        private TextBox textBoxCouleurs;
    }
}