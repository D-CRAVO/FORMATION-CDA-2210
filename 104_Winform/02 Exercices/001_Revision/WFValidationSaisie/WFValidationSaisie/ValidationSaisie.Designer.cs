namespace WFValidationSaisie
{
    partial class ValidationSaisie
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
            labelNom = new Label();
            textBoxNom = new TextBox();
            labelDate = new Label();
            labelMontant = new Label();
            labelCp = new Label();
            textBoxDate = new TextBox();
            textBoxMontant = new TextBox();
            textBoxCp = new TextBox();
            labelCommentaire = new Label();
            buttonValider = new Button();
            buttonEffacer = new Button();
            errorProviderNom = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderNom).BeginInit();
            SuspendLayout();
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(12, 38);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(34, 15);
            labelNom.TabIndex = 0;
            labelNom.Text = "Nom";
            // 
            // textBoxNom
            // 
            textBoxNom.Location = new Point(102, 35);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(150, 23);
            textBoxNom.TabIndex = 1;
            textBoxNom.TextChanged += textBoxNom_TextChanged;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(12, 67);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(31, 15);
            labelDate.TabIndex = 2;
            labelDate.Text = "Date";
            // 
            // labelMontant
            // 
            labelMontant.AutoSize = true;
            labelMontant.Location = new Point(12, 96);
            labelMontant.Name = "labelMontant";
            labelMontant.Size = new Size(53, 15);
            labelMontant.TabIndex = 3;
            labelMontant.Text = "Montant";
            // 
            // labelCp
            // 
            labelCp.AutoSize = true;
            labelCp.Location = new Point(12, 125);
            labelCp.Name = "labelCp";
            labelCp.Size = new Size(70, 15);
            labelCp.TabIndex = 4;
            labelCp.Text = "Code Postal";
            // 
            // textBoxDate
            // 
            textBoxDate.Location = new Point(102, 64);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(125, 23);
            textBoxDate.TabIndex = 5;
            // 
            // textBoxMontant
            // 
            textBoxMontant.Location = new Point(102, 93);
            textBoxMontant.Name = "textBoxMontant";
            textBoxMontant.Size = new Size(125, 23);
            textBoxMontant.TabIndex = 6;
            // 
            // textBoxCp
            // 
            textBoxCp.Location = new Point(102, 122);
            textBoxCp.Name = "textBoxCp";
            textBoxCp.Size = new Size(100, 23);
            textBoxCp.TabIndex = 7;
            // 
            // labelCommentaire
            // 
            labelCommentaire.AutoSize = true;
            labelCommentaire.Location = new Point(257, 69);
            labelCommentaire.Name = "labelCommentaire";
            labelCommentaire.Size = new Size(87, 15);
            labelCommentaire.TabIndex = 8;
            labelCommentaire.Text = "(JJ/MM/AAAA)";
            // 
            // buttonValider
            // 
            buttonValider.Location = new Point(269, 125);
            buttonValider.Name = "buttonValider";
            buttonValider.Size = new Size(75, 23);
            buttonValider.TabIndex = 9;
            buttonValider.Text = "Valider";
            buttonValider.UseVisualStyleBackColor = true;
            // 
            // buttonEffacer
            // 
            buttonEffacer.Location = new Point(269, 154);
            buttonEffacer.Name = "buttonEffacer";
            buttonEffacer.Size = new Size(75, 23);
            buttonEffacer.TabIndex = 10;
            buttonEffacer.Text = "Effacer";
            buttonEffacer.UseVisualStyleBackColor = true;
            // 
            // errorProviderNom
            // 
            errorProviderNom.ContainerControl = this;
            // 
            // ValidationSaisie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 190);
            Controls.Add(buttonEffacer);
            Controls.Add(buttonValider);
            Controls.Add(labelCommentaire);
            Controls.Add(textBoxCp);
            Controls.Add(textBoxMontant);
            Controls.Add(textBoxDate);
            Controls.Add(labelCp);
            Controls.Add(labelMontant);
            Controls.Add(labelDate);
            Controls.Add(textBoxNom);
            Controls.Add(labelNom);
            Name = "ValidationSaisie";
            Text = "ValidationSaisie";
            ((System.ComponentModel.ISupportInitialize)errorProviderNom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNom;
        private TextBox textBoxNom;
        private Label labelDate;
        private Label labelMontant;
        private Label labelCp;
        private TextBox textBoxDate;
        private TextBox textBoxMontant;
        private TextBox textBoxCp;
        private Label labelCommentaire;
        private Button buttonValider;
        private Button buttonEffacer;
        private ErrorProvider errorProviderNom;
    }
}