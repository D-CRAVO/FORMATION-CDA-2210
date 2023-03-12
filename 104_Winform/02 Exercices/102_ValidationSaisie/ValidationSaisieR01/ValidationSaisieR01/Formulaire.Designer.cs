namespace ValidationSaisieR01
{
    partial class Formulaire
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
            labelCP = new Label();
            textBoxNom = new TextBox();
            textBoxDate = new TextBox();
            textBoxMontant = new TextBox();
            textBoxCP = new TextBox();
            buttonValider = new Button();
            buttonEffacer = new Button();
            labelInfo = new Label();
            errorProviderNom = new ErrorProvider(components);
            errorProviderDate = new ErrorProvider(components);
            errorProviderMontant = new ErrorProvider(components);
            errorProviderCP = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderNom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderMontant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderCP).BeginInit();
            SuspendLayout();
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(28, 47);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(40, 15);
            labelNom.TabIndex = 0;
            labelNom.Text = "Nom :";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(28, 74);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(37, 15);
            labelDate.TabIndex = 1;
            labelDate.Text = "Date :";
            // 
            // labelMontant
            // 
            labelMontant.AutoSize = true;
            labelMontant.Location = new Point(28, 102);
            labelMontant.Name = "labelMontant";
            labelMontant.Size = new Size(59, 15);
            labelMontant.TabIndex = 2;
            labelMontant.Text = "Montant :";
            // 
            // labelCP
            // 
            labelCP.AutoSize = true;
            labelCP.Location = new Point(28, 131);
            labelCP.Name = "labelCP";
            labelCP.Size = new Size(76, 15);
            labelCP.TabIndex = 3;
            labelCP.Text = "Code Postal :";
            // 
            // textBoxNom
            // 
            textBoxNom.Location = new Point(117, 39);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(125, 23);
            textBoxNom.TabIndex = 4;
            textBoxNom.TextChanged += textBoxNom_TextChanged;
            // 
            // textBoxDate
            // 
            textBoxDate.Location = new Point(117, 66);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(100, 23);
            textBoxDate.TabIndex = 5;
            textBoxDate.TextChanged += textBoxDate_TextChanged;
            // 
            // textBoxMontant
            // 
            textBoxMontant.Location = new Point(117, 94);
            textBoxMontant.Name = "textBoxMontant";
            textBoxMontant.Size = new Size(100, 23);
            textBoxMontant.TabIndex = 6;
            textBoxMontant.TextChanged += textBoxMontant_TextChanged;
            // 
            // textBoxCP
            // 
            textBoxCP.Location = new Point(117, 123);
            textBoxCP.Name = "textBoxCP";
            textBoxCP.Size = new Size(75, 23);
            textBoxCP.TabIndex = 7;
            textBoxCP.TextChanged += textBoxCP_TextChanged;
            // 
            // buttonValider
            // 
            buttonValider.Location = new Point(280, 182);
            buttonValider.Name = "buttonValider";
            buttonValider.Size = new Size(75, 23);
            buttonValider.TabIndex = 8;
            buttonValider.Text = "Valider";
            buttonValider.UseVisualStyleBackColor = true;
            buttonValider.Click += buttonValider_Click;
            // 
            // buttonEffacer
            // 
            buttonEffacer.Location = new Point(280, 211);
            buttonEffacer.Name = "buttonEffacer";
            buttonEffacer.Size = new Size(75, 23);
            buttonEffacer.TabIndex = 9;
            buttonEffacer.Text = "Effacer";
            buttonEffacer.UseVisualStyleBackColor = true;
            buttonEffacer.Click += buttonEffacer_Click;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(244, 74);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(87, 15);
            labelInfo.TabIndex = 10;
            labelInfo.Text = "(JJ/MM/AAAA)";
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
            // errorProviderCP
            // 
            errorProviderCP.ContainerControl = this;
            // 
            // Formulaire
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(labelInfo);
            Controls.Add(buttonEffacer);
            Controls.Add(buttonValider);
            Controls.Add(textBoxCP);
            Controls.Add(textBoxMontant);
            Controls.Add(textBoxDate);
            Controls.Add(textBoxNom);
            Controls.Add(labelCP);
            Controls.Add(labelMontant);
            Controls.Add(labelDate);
            Controls.Add(labelNom);
            Name = "Formulaire";
            Text = "Les contrôles";
            FormClosing += Formulaire_FormClosing;
            ((System.ComponentModel.ISupportInitialize)errorProviderNom).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderMontant).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderCP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNom;
        private Label labelDate;
        private Label labelMontant;
        private Label labelCP;
        private TextBox textBoxNom;
        private TextBox textBoxDate;
        private TextBox textBoxMontant;
        private TextBox textBoxCP;
        private Button buttonValider;
        private Button buttonEffacer;
        private Label labelInfo;
        private ErrorProvider errorProviderNom;
        private ErrorProvider errorProviderDate;
        private ErrorProvider errorProviderMontant;
        private ErrorProvider errorProviderCP;
    }
}