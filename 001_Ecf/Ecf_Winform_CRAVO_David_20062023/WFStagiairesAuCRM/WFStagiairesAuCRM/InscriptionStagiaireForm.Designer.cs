namespace WFStagiairesAuCRM
{
    partial class InscriptionStagiaireForm
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
            labelPrenom = new Label();
            labelDateDebut = new Label();
            labelDateFin = new Label();
            listBoxFormation = new ListBox();
            textBoxNom = new TextBox();
            textBoxPrenom = new TextBox();
            textBoxDateDebut = new TextBox();
            textBoxDateFin = new TextBox();
            buttonValider = new Button();
            labelFormation = new Label();
            errorProviderNom = new ErrorProvider(components);
            errorProviderPrenom = new ErrorProvider(components);
            errorProviderDateDebut = new ErrorProvider(components);
            errorProviderDateFin = new ErrorProvider(components);
            buttonEffacer = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProviderNom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPrenom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDateDebut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDateFin).BeginInit();
            SuspendLayout();
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(12, 47);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(34, 15);
            labelNom.TabIndex = 0;
            labelNom.Text = "Nom";
            // 
            // labelPrenom
            // 
            labelPrenom.AutoSize = true;
            labelPrenom.Location = new Point(12, 82);
            labelPrenom.Name = "labelPrenom";
            labelPrenom.Size = new Size(49, 15);
            labelPrenom.TabIndex = 1;
            labelPrenom.Text = "Prénom";
            // 
            // labelDateDebut
            // 
            labelDateDebut.AutoSize = true;
            labelDateDebut.Location = new Point(12, 118);
            labelDateDebut.Name = "labelDateDebut";
            labelDateDebut.Size = new Size(153, 15);
            labelDateDebut.TabIndex = 2;
            labelDateDebut.Text = "Date de début de formation";
            // 
            // labelDateFin
            // 
            labelDateFin.AutoSize = true;
            labelDateFin.Location = new Point(12, 154);
            labelDateFin.Name = "labelDateFin";
            labelDateFin.Size = new Size(136, 15);
            labelDateFin.TabIndex = 3;
            labelDateFin.Text = "Date de fin de formation";
            // 
            // listBoxFormation
            // 
            listBoxFormation.FormattingEnabled = true;
            listBoxFormation.ItemHeight = 15;
            listBoxFormation.Items.AddRange(new object[] { "ABC-DEV", "DWWM", "CDA", "" });
            listBoxFormation.Location = new Point(179, 189);
            listBoxFormation.Name = "listBoxFormation";
            listBoxFormation.Size = new Size(153, 49);
            listBoxFormation.TabIndex = 4;
            // 
            // textBoxNom
            // 
            textBoxNom.Location = new Point(180, 44);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(150, 23);
            textBoxNom.TabIndex = 5;
            // 
            // textBoxPrenom
            // 
            textBoxPrenom.Location = new Point(180, 79);
            textBoxPrenom.Name = "textBoxPrenom";
            textBoxPrenom.Size = new Size(150, 23);
            textBoxPrenom.TabIndex = 6;
            // 
            // textBoxDateDebut
            // 
            textBoxDateDebut.Location = new Point(180, 115);
            textBoxDateDebut.Name = "textBoxDateDebut";
            textBoxDateDebut.Size = new Size(150, 23);
            textBoxDateDebut.TabIndex = 7;
            // 
            // textBoxDateFin
            // 
            textBoxDateFin.Location = new Point(180, 151);
            textBoxDateFin.Name = "textBoxDateFin";
            textBoxDateFin.Size = new Size(150, 23);
            textBoxDateFin.TabIndex = 8;
            // 
            // buttonValider
            // 
            buttonValider.Location = new Point(73, 266);
            buttonValider.Name = "buttonValider";
            buttonValider.Size = new Size(75, 23);
            buttonValider.TabIndex = 9;
            buttonValider.Text = "Valider";
            buttonValider.UseVisualStyleBackColor = true;
            buttonValider.Click += buttonValider_Click;
            // 
            // labelFormation
            // 
            labelFormation.AutoSize = true;
            labelFormation.Location = new Point(12, 189);
            labelFormation.Name = "labelFormation";
            labelFormation.Size = new Size(118, 15);
            labelFormation.TabIndex = 10;
            labelFormation.Text = "Nom de la formation";
            // 
            // errorProviderNom
            // 
            errorProviderNom.ContainerControl = this;
            // 
            // errorProviderPrenom
            // 
            errorProviderPrenom.ContainerControl = this;
            // 
            // errorProviderDateDebut
            // 
            errorProviderDateDebut.ContainerControl = this;
            // 
            // errorProviderDateFin
            // 
            errorProviderDateFin.ContainerControl = this;
            // 
            // buttonEffacer
            // 
            buttonEffacer.Location = new Point(179, 266);
            buttonEffacer.Name = "buttonEffacer";
            buttonEffacer.Size = new Size(75, 23);
            buttonEffacer.TabIndex = 11;
            buttonEffacer.Text = "Effacer";
            buttonEffacer.UseVisualStyleBackColor = true;
            buttonEffacer.Click += buttonEffacer_Click;
            // 
            // InscriptionStagiaireForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 301);
            Controls.Add(buttonEffacer);
            Controls.Add(labelFormation);
            Controls.Add(buttonValider);
            Controls.Add(textBoxDateFin);
            Controls.Add(textBoxDateDebut);
            Controls.Add(textBoxPrenom);
            Controls.Add(textBoxNom);
            Controls.Add(listBoxFormation);
            Controls.Add(labelDateFin);
            Controls.Add(labelDateDebut);
            Controls.Add(labelPrenom);
            Controls.Add(labelNom);
            Name = "InscriptionStagiaireForm";
            Text = "InscriptionStagiaireForm";
            ((System.ComponentModel.ISupportInitialize)errorProviderNom).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPrenom).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDateDebut).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDateFin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNom;
        private Label labelPrenom;
        private Label labelDateDebut;
        private Label labelDateFin;
        private ListBox listBoxFormation;
        private TextBox textBoxNom;
        private TextBox textBoxPrenom;
        private TextBox textBoxDateDebut;
        private TextBox textBoxDateFin;
        private Button buttonValider;
        private Label labelFormation;
        private ErrorProvider errorProviderNom;
        private ErrorProvider errorProviderPrenom;
        private ErrorProvider errorProviderDateDebut;
        private ErrorProvider errorProviderDateFin;
        private Button buttonEffacer;
    }
}