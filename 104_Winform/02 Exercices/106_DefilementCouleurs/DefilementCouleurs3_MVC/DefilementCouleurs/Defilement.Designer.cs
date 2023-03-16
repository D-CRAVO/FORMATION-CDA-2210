namespace DefilementCouleurs
{
    partial class Defilement
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
            this.labelRouge = new System.Windows.Forms.Label();
            this.labelVert = new System.Windows.Forms.Label();
            this.labelBleu = new System.Windows.Forms.Label();
            this.hScrollBarRouge = new System.Windows.Forms.HScrollBar();
            this.hScrollBarVert = new System.Windows.Forms.HScrollBar();
            this.hScrollBarBleu = new System.Windows.Forms.HScrollBar();
            this.numericUpDownRouge = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownVert = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBleu = new System.Windows.Forms.NumericUpDown();
            this.textBoxRouge = new System.Windows.Forms.TextBox();
            this.textBoxVert = new System.Windows.Forms.TextBox();
            this.textBoxBleu = new System.Windows.Forms.TextBox();
            this.textBoxCouleur = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRouge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBleu)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRouge
            // 
            this.labelRouge.AutoSize = true;
            this.labelRouge.Location = new System.Drawing.Point(24, 52);
            this.labelRouge.Name = "labelRouge";
            this.labelRouge.Size = new System.Drawing.Size(41, 15);
            this.labelRouge.TabIndex = 0;
            this.labelRouge.Text = "Rouge";
            // 
            // labelVert
            // 
            this.labelVert.AutoSize = true;
            this.labelVert.Location = new System.Drawing.Point(24, 81);
            this.labelVert.Name = "labelVert";
            this.labelVert.Size = new System.Drawing.Size(27, 15);
            this.labelVert.TabIndex = 1;
            this.labelVert.Text = "Vert";
            // 
            // labelBleu
            // 
            this.labelBleu.AutoSize = true;
            this.labelBleu.Location = new System.Drawing.Point(24, 110);
            this.labelBleu.Name = "labelBleu";
            this.labelBleu.Size = new System.Drawing.Size(30, 15);
            this.labelBleu.TabIndex = 2;
            this.labelBleu.Text = "Bleu";
            // 
            // hScrollBarRouge
            // 
            this.hScrollBarRouge.Location = new System.Drawing.Point(81, 50);
            this.hScrollBarRouge.Maximum = 264;
            this.hScrollBarRouge.Name = "hScrollBarRouge";
            this.hScrollBarRouge.Size = new System.Drawing.Size(150, 17);
            this.hScrollBarRouge.TabIndex = 6;
            this.hScrollBarRouge.Value = 191;
            this.hScrollBarRouge.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarRouge_Scroll);
            // 
            // hScrollBarVert
            // 
            this.hScrollBarVert.Location = new System.Drawing.Point(81, 79);
            this.hScrollBarVert.Maximum = 264;
            this.hScrollBarVert.Name = "hScrollBarVert";
            this.hScrollBarVert.Size = new System.Drawing.Size(150, 17);
            this.hScrollBarVert.TabIndex = 7;
            this.hScrollBarVert.Value = 154;
            this.hScrollBarVert.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarVert_Scroll);
            // 
            // hScrollBarBleu
            // 
            this.hScrollBarBleu.Location = new System.Drawing.Point(81, 108);
            this.hScrollBarBleu.Maximum = 264;
            this.hScrollBarBleu.Name = "hScrollBarBleu";
            this.hScrollBarBleu.Size = new System.Drawing.Size(150, 17);
            this.hScrollBarBleu.TabIndex = 8;
            this.hScrollBarBleu.Value = 209;
            this.hScrollBarBleu.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarBleu_Scroll);
            // 
            // numericUpDownRouge
            // 
            this.numericUpDownRouge.Location = new System.Drawing.Point(234, 44);
            this.numericUpDownRouge.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownRouge.Name = "numericUpDownRouge";
            this.numericUpDownRouge.Size = new System.Drawing.Size(60, 23);
            this.numericUpDownRouge.TabIndex = 9;
            this.numericUpDownRouge.Value = new decimal(new int[] {
            191,
            0,
            0,
            0});
            this.numericUpDownRouge.ValueChanged += new System.EventHandler(this.numericUpDownRouge_ValueChanged);
            // 
            // numericUpDownVert
            // 
            this.numericUpDownVert.Location = new System.Drawing.Point(234, 73);
            this.numericUpDownVert.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownVert.Name = "numericUpDownVert";
            this.numericUpDownVert.Size = new System.Drawing.Size(60, 23);
            this.numericUpDownVert.TabIndex = 10;
            this.numericUpDownVert.Value = new decimal(new int[] {
            154,
            0,
            0,
            0});
            this.numericUpDownVert.ValueChanged += new System.EventHandler(this.numericUpDownVert_ValueChanged);
            // 
            // numericUpDownBleu
            // 
            this.numericUpDownBleu.Location = new System.Drawing.Point(234, 102);
            this.numericUpDownBleu.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBleu.Name = "numericUpDownBleu";
            this.numericUpDownBleu.Size = new System.Drawing.Size(60, 23);
            this.numericUpDownBleu.TabIndex = 11;
            this.numericUpDownBleu.Value = new decimal(new int[] {
            209,
            0,
            0,
            0});
            this.numericUpDownBleu.ValueChanged += new System.EventHandler(this.numericUpDownBleu_ValueChanged);
            // 
            // textBoxRouge
            // 
            this.textBoxRouge.Location = new System.Drawing.Point(300, 43);
            this.textBoxRouge.Name = "textBoxRouge";
            this.textBoxRouge.Size = new System.Drawing.Size(60, 23);
            this.textBoxRouge.TabIndex = 12;
            // 
            // textBoxVert
            // 
            this.textBoxVert.Location = new System.Drawing.Point(300, 72);
            this.textBoxVert.Name = "textBoxVert";
            this.textBoxVert.Size = new System.Drawing.Size(60, 23);
            this.textBoxVert.TabIndex = 13;
            // 
            // textBoxBleu
            // 
            this.textBoxBleu.Location = new System.Drawing.Point(300, 102);
            this.textBoxBleu.Name = "textBoxBleu";
            this.textBoxBleu.Size = new System.Drawing.Size(60, 23);
            this.textBoxBleu.TabIndex = 14;
            // 
            // textBoxCouleur
            // 
            this.textBoxCouleur.Location = new System.Drawing.Point(24, 131);
            this.textBoxCouleur.Multiline = true;
            this.textBoxCouleur.Name = "textBoxCouleur";
            this.textBoxCouleur.Size = new System.Drawing.Size(336, 58);
            this.textBoxCouleur.TabIndex = 15;
            // 
            // Defilement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.textBoxCouleur);
            this.Controls.Add(this.textBoxBleu);
            this.Controls.Add(this.textBoxVert);
            this.Controls.Add(this.textBoxRouge);
            this.Controls.Add(this.numericUpDownBleu);
            this.Controls.Add(this.numericUpDownVert);
            this.Controls.Add(this.numericUpDownRouge);
            this.Controls.Add(this.hScrollBarBleu);
            this.Controls.Add(this.hScrollBarVert);
            this.Controls.Add(this.hScrollBarRouge);
            this.Controls.Add(this.labelBleu);
            this.Controls.Add(this.labelVert);
            this.Controls.Add(this.labelRouge);
            this.Name = "Defilement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Defilement";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRouge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBleu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelRouge;
        private Label labelVert;
        private Label labelBleu;
        private HScrollBar hScrollBarRouge;
        private HScrollBar hScrollBarVert;
        private HScrollBar hScrollBarBleu;
        private NumericUpDown numericUpDownRouge;
        private NumericUpDown numericUpDownVert;
        private NumericUpDown numericUpDownBleu;
        private TextBox textBoxRouge;
        private TextBox textBoxVert;
        private TextBox textBoxBleu;
        private TextBox textBoxCouleur;
    }
}