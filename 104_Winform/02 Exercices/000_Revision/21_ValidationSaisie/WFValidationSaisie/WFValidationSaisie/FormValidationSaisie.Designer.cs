namespace WFValidationSaisie
{
    partial class FormValidationSaisie
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
            labelDate = new Label();
            labelMontant = new Label();
            labelCp = new Label();
            textBoxNom = new TextBox();
            textBoxDate = new TextBox();
            textBoxMontant = new TextBox();
            textBoxCp = new TextBox();
            buttonValider = new Button();
            buttonEffacer = new Button();
            labelCommentaires = new Label();
            errorProviderNom = new ErrorProvider(components);
            errorProviderDate = new ErrorProvider(components);
            errorProviderMontant = new ErrorProvider(components);
            errorProviderCp = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderNom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderMontant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderCp).BeginInit();
            SuspendLayout();
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(19, 30);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(34, 15);
            labelNom.TabIndex = 0;
            labelNom.Text = "Nom";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(19, 68);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(31, 15);
            labelDate.TabIndex = 1;
            labelDate.Text = "Date";
            // 
            // labelMontant
            // 
            labelMontant.AutoSize = true;
            labelMontant.Location = new Point(19, 106);
            labelMontant.Name = "labelMontant";
            labelMontant.Size = new Size(53, 15);
            labelMontant.TabIndex = 2;
            labelMontant.Text = "Montant";
            // 
            // labelCp
            // 
            labelCp.AutoSize = true;
            labelCp.Location = new Point(19, 146);
            labelCp.Name = "labelCp";
            labelCp.Size = new Size(70, 15);
            labelCp.TabIndex = 3;
            labelCp.Text = "Code Postal";
            // 
            // textBoxNom
            // 
            textBoxNom.Location = new Point(132, 22);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(150, 23);
            textBoxNom.TabIndex = 4;
            textBoxNom.TextChanged += textBoxNom_TextChanged;
            // 
            // textBoxDate
            // 
            textBoxDate.Location = new Point(132, 60);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(100, 23);
            textBoxDate.TabIndex = 5;
            textBoxDate.TextChanged += textBoxDate_TextChanged;
            // 
            // textBoxMontant
            // 
            textBoxMontant.Location = new Point(132, 98);
            textBoxMontant.Name = "textBoxMontant";
            textBoxMontant.Size = new Size(100, 23);
            textBoxMontant.TabIndex = 6;
            textBoxMontant.TextChanged += textBoxMontant_TextChanged;
            // 
            // textBoxCp
            // 
            textBoxCp.Location = new Point(132, 138);
            textBoxCp.Name = "textBoxCp";
            textBoxCp.Size = new Size(75, 23);
            textBoxCp.TabIndex = 7;
            textBoxCp.TextChanged += textBoxCp_TextChanged;
            // 
            // buttonValider
            // 
            buttonValider.Location = new Point(288, 125);
            buttonValider.Name = "buttonValider";
            buttonValider.Size = new Size(75, 23);
            buttonValider.TabIndex = 8;
            buttonValider.Text = "Valider";
            buttonValider.UseVisualStyleBackColor = true;
            buttonValider.Click += buttonValider_Click;
            // 
            // buttonEffacer
            // 
            buttonEffacer.Location = new Point(288, 154);
            buttonEffacer.Name = "buttonEffacer";
            buttonEffacer.Size = new Size(75, 23);
            buttonEffacer.TabIndex = 9;
            buttonEffacer.Text = "Effacer";
            buttonEffacer.UseVisualStyleBackColor = true;
            // 
            // labelCommentaires
            // 
            labelCommentaires.AutoSize = true;
            labelCommentaires.Location = new Point(276, 68);
            labelCommentaires.Name = "labelCommentaires";
            labelCommentaires.Size = new Size(87, 15);
            labelCommentaires.TabIndex = 10;
            labelCommentaires.Text = "(JJ/MM/AAAA)";
            // 
            // errorProviderNom
            // 
            errorProviderNom.ContainerControl = this;
            // 
            // errorProviderDate
            // 
            errorProviderDate.ContainerControl = this;
            // 
            // errorProviderMontant
            // 
            errorProviderMontant.ContainerControl = this;
            // 
            // errorProviderCp
            // 
            errorProviderCp.ContainerControl = this;
            // 
            // FormValidationSaisie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 185);
            Controls.Add(labelCommentaires);
            Controls.Add(buttonEffacer);
            Controls.Add(buttonValider);
            Controls.Add(textBoxCp);
            Controls.Add(textBoxMontant);
            Controls.Add(textBoxDate);
            Controls.Add(textBoxNom);
            Controls.Add(labelCp);
            Controls.Add(labelMontant);
            Controls.Add(labelDate);
            Controls.Add(labelNom);
            Name = "FormValidationSaisie";
            Text = "FormValidationSaisie";
            ((System.ComponentModel.ISupportInitialize)errorProviderNom).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderMontant).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderCp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNom;
        private Label labelDate;
        private Label labelMontant;
        private Label labelCp;
        private TextBox textBoxNom;
        private TextBox textBoxDate;
        private TextBox textBoxMontant;
        private TextBox textBoxCp;
        private Button buttonValider;
        private Button buttonEffacer;
        private Label labelCommentaires;
        private ErrorProvider errorProviderNom;
        private ErrorProvider errorProviderDate;
        private ErrorProvider errorProviderMontant;
        private ErrorProvider errorProviderCp;
    }
}