namespace ValidationSaisie2
{
    partial class FormulaireSaisie2
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
            this.labelNom = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonEffacer = new System.Windows.Forms.Button();
            this.errorProviderNom = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.labelMontant = new System.Windows.Forms.Label();
            this.textBoxMontant = new System.Windows.Forms.TextBox();
            this.labelCP = new System.Windows.Forms.Label();
            this.textBoxCP = new System.Windows.Forms.TextBox();
            this.errorProviderDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMontant = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCP = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMontant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCP)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(125, 149);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(34, 15);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(207, 141);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 23);
            this.textBoxNom.TabIndex = 1;
            this.textBoxNom.TextChanged += new System.EventHandler(this.textBoxNom_TextChanged);
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(659, 333);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 9;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonEffacer
            // 
            this.buttonEffacer.Location = new System.Drawing.Point(659, 362);
            this.buttonEffacer.Name = "buttonEffacer";
            this.buttonEffacer.Size = new System.Drawing.Size(75, 23);
            this.buttonEffacer.TabIndex = 10;
            this.buttonEffacer.Text = "Effacer";
            this.buttonEffacer.UseVisualStyleBackColor = true;
            this.buttonEffacer.Click += new System.EventHandler(this.buttonEffacer_Click);
            // 
            // errorProviderNom
            // 
            this.errorProviderNom.ContainerControl = this;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(125, 192);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(37, 15);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "Date :";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(207, 184);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(100, 23);
            this.textBoxDate.TabIndex = 4;
            this.textBoxDate.TextChanged += new System.EventHandler(this.textBoxDate_TextChanged);
            // 
            // labelMontant
            // 
            this.labelMontant.AutoSize = true;
            this.labelMontant.Location = new System.Drawing.Point(125, 238);
            this.labelMontant.Name = "labelMontant";
            this.labelMontant.Size = new System.Drawing.Size(59, 15);
            this.labelMontant.TabIndex = 5;
            this.labelMontant.Text = "Montant :";
            // 
            // textBoxMontant
            // 
            this.textBoxMontant.Location = new System.Drawing.Point(207, 230);
            this.textBoxMontant.Name = "textBoxMontant";
            this.textBoxMontant.Size = new System.Drawing.Size(100, 23);
            this.textBoxMontant.TabIndex = 6;
            this.textBoxMontant.TextChanged += new System.EventHandler(this.textBoxMontant_TextChanged);
            // 
            // labelCP
            // 
            this.labelCP.AutoSize = true;
            this.labelCP.Location = new System.Drawing.Point(125, 284);
            this.labelCP.Name = "labelCP";
            this.labelCP.Size = new System.Drawing.Size(76, 15);
            this.labelCP.TabIndex = 7;
            this.labelCP.Text = "Code Postal :";
            // 
            // textBoxCP
            // 
            this.textBoxCP.Location = new System.Drawing.Point(207, 276);
            this.textBoxCP.Name = "textBoxCP";
            this.textBoxCP.Size = new System.Drawing.Size(100, 23);
            this.textBoxCP.TabIndex = 8;
            this.textBoxCP.TextChanged += new System.EventHandler(this.textBoxCP_TextChanged);
            // 
            // errorProviderDate
            // 
            this.errorProviderDate.ContainerControl = this;
            // 
            // errorProviderMontant
            // 
            this.errorProviderMontant.ContainerControl = this;
            // 
            // errorProviderCP
            // 
            this.errorProviderCP.ContainerControl = this;
            // 
            // FormulaireSaisie2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxCP);
            this.Controls.Add(this.labelCP);
            this.Controls.Add(this.textBoxMontant);
            this.Controls.Add(this.labelMontant);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.buttonEffacer);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelNom);
            this.Name = "FormulaireSaisie2";
            this.Text = "FormulaireSaisie2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormulaireSaisie2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMontant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNom;
        private TextBox textBoxNom;
        private Button buttonValider;
        private Button buttonEffacer;
        private ErrorProvider errorProviderNom;
        private Label labelDate;
        private TextBox textBoxCP;
        private Label labelCP;
        private TextBox textBoxMontant;
        private Label labelMontant;
        private TextBox textBoxDate;
        private ErrorProvider errorProviderDate;
        private ErrorProvider errorProviderMontant;
        private ErrorProvider errorProviderCP;
    }
}