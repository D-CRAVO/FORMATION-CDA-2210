namespace WFListBox
{
    partial class FormListBox
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
            labelNouvelElement = new Label();
            textBoxNouvelElement = new TextBox();
            buttonAjoutListe = new Button();
            labelLstListe = new Label();
            listBoxLstListe = new ListBox();
            textBoxIndexElement = new TextBox();
            labelIndexElement = new Label();
            buttonSelectionner = new Button();
            buttonViderListe = new Button();
            labelProprietes = new Label();
            labelItemsCount = new Label();
            labelSelectedIndex = new Label();
            labelText = new Label();
            textBoxItemsCount = new TextBox();
            textBoxSelectedIndex = new TextBox();
            textBoxText = new TextBox();
            errorProviderNouvelElement = new ErrorProvider(components);
            errorProviderIndexInvalide = new ErrorProvider(components);
            errorProviderHorsLimite = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderNouvelElement).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderIndexInvalide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderHorsLimite).BeginInit();
            SuspendLayout();
            // 
            // labelNouvelElement
            // 
            labelNouvelElement.AutoSize = true;
            labelNouvelElement.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNouvelElement.Location = new Point(12, 9);
            labelNouvelElement.Name = "labelNouvelElement";
            labelNouvelElement.Size = new Size(96, 15);
            labelNouvelElement.TabIndex = 0;
            labelNouvelElement.Text = "Nouvel Elément";
            // 
            // textBoxNouvelElement
            // 
            textBoxNouvelElement.Location = new Point(12, 36);
            textBoxNouvelElement.Name = "textBoxNouvelElement";
            textBoxNouvelElement.Size = new Size(150, 23);
            textBoxNouvelElement.TabIndex = 1;
            textBoxNouvelElement.TextChanged += textBoxNouvelElement_TextChanged;
            // 
            // buttonAjoutListe
            // 
            buttonAjoutListe.Location = new Point(12, 74);
            buttonAjoutListe.Name = "buttonAjoutListe";
            buttonAjoutListe.Size = new Size(150, 23);
            buttonAjoutListe.TabIndex = 2;
            buttonAjoutListe.Text = "Ajout Liste";
            buttonAjoutListe.UseVisualStyleBackColor = true;
            buttonAjoutListe.Click += buttonAjoutListe_Click;
            // 
            // labelLstListe
            // 
            labelLstListe.AutoSize = true;
            labelLstListe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelLstListe.Location = new Point(12, 111);
            labelLstListe.Name = "labelLstListe";
            labelLstListe.Size = new Size(49, 15);
            labelLstListe.TabIndex = 3;
            labelLstListe.Text = "LstListe";
            // 
            // listBoxLstListe
            // 
            listBoxLstListe.FormattingEnabled = true;
            listBoxLstListe.ItemHeight = 15;
            listBoxLstListe.Location = new Point(12, 145);
            listBoxLstListe.Name = "listBoxLstListe";
            listBoxLstListe.Size = new Size(150, 94);
            listBoxLstListe.TabIndex = 4;
            listBoxLstListe.SelectedIndexChanged += listBoxLstListe_SelectedIndexChanged;
            // 
            // textBoxIndexElement
            // 
            textBoxIndexElement.Location = new Point(213, 36);
            textBoxIndexElement.Name = "textBoxIndexElement";
            textBoxIndexElement.Size = new Size(50, 23);
            textBoxIndexElement.TabIndex = 5;
            textBoxIndexElement.TextChanged += textBoxIndexElement_TextChanged;
            // 
            // labelIndexElement
            // 
            labelIndexElement.AutoSize = true;
            labelIndexElement.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelIndexElement.Location = new Point(213, 9);
            labelIndexElement.Name = "labelIndexElement";
            labelIndexElement.Size = new Size(88, 15);
            labelIndexElement.TabIndex = 6;
            labelIndexElement.Text = "Index Elément";
            // 
            // buttonSelectionner
            // 
            buttonSelectionner.Location = new Point(282, 36);
            buttonSelectionner.Name = "buttonSelectionner";
            buttonSelectionner.Size = new Size(129, 23);
            buttonSelectionner.TabIndex = 7;
            buttonSelectionner.Text = "Selectionner";
            buttonSelectionner.UseVisualStyleBackColor = true;
            buttonSelectionner.Click += buttonSelectionner_Click;
            // 
            // buttonViderListe
            // 
            buttonViderListe.Location = new Point(282, 65);
            buttonViderListe.Name = "buttonViderListe";
            buttonViderListe.Size = new Size(129, 23);
            buttonViderListe.TabIndex = 8;
            buttonViderListe.Text = "Vider le Liste";
            buttonViderListe.UseVisualStyleBackColor = true;
            buttonViderListe.Click += buttonViderListe_Click;
            // 
            // labelProprietes
            // 
            labelProprietes.AutoSize = true;
            labelProprietes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelProprietes.Location = new Point(213, 111);
            labelProprietes.Name = "labelProprietes";
            labelProprietes.Size = new Size(65, 15);
            labelProprietes.TabIndex = 9;
            labelProprietes.Text = "Propriétés";
            // 
            // labelItemsCount
            // 
            labelItemsCount.AutoSize = true;
            labelItemsCount.Location = new Point(213, 145);
            labelItemsCount.Name = "labelItemsCount";
            labelItemsCount.Size = new Size(72, 15);
            labelItemsCount.TabIndex = 10;
            labelItemsCount.Text = "Items.Count";
            // 
            // labelSelectedIndex
            // 
            labelSelectedIndex.AutoSize = true;
            labelSelectedIndex.Location = new Point(213, 174);
            labelSelectedIndex.Name = "labelSelectedIndex";
            labelSelectedIndex.Size = new Size(80, 15);
            labelSelectedIndex.TabIndex = 11;
            labelSelectedIndex.Text = "SelectedIndex";
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Location = new Point(213, 203);
            labelText.Name = "labelText";
            labelText.Size = new Size(28, 15);
            labelText.TabIndex = 12;
            labelText.Text = "Text";
            // 
            // textBoxItemsCount
            // 
            textBoxItemsCount.Location = new Point(304, 137);
            textBoxItemsCount.Name = "textBoxItemsCount";
            textBoxItemsCount.ReadOnly = true;
            textBoxItemsCount.Size = new Size(50, 23);
            textBoxItemsCount.TabIndex = 13;
            // 
            // textBoxSelectedIndex
            // 
            textBoxSelectedIndex.Location = new Point(304, 166);
            textBoxSelectedIndex.Name = "textBoxSelectedIndex";
            textBoxSelectedIndex.ReadOnly = true;
            textBoxSelectedIndex.Size = new Size(50, 23);
            textBoxSelectedIndex.TabIndex = 14;
            // 
            // textBoxText
            // 
            textBoxText.Location = new Point(304, 195);
            textBoxText.Name = "textBoxText";
            textBoxText.ReadOnly = true;
            textBoxText.Size = new Size(107, 23);
            textBoxText.TabIndex = 15;
            // 
            // errorProviderNouvelElement
            // 
            errorProviderNouvelElement.ContainerControl = this;
            // 
            // errorProviderIndexInvalide
            // 
            errorProviderIndexInvalide.ContainerControl = this;
            // 
            // errorProviderHorsLimite
            // 
            errorProviderHorsLimite.ContainerControl = this;
            // 
            // FormListBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 253);
            Controls.Add(textBoxText);
            Controls.Add(textBoxSelectedIndex);
            Controls.Add(textBoxItemsCount);
            Controls.Add(labelText);
            Controls.Add(labelSelectedIndex);
            Controls.Add(labelItemsCount);
            Controls.Add(labelProprietes);
            Controls.Add(buttonViderListe);
            Controls.Add(buttonSelectionner);
            Controls.Add(labelIndexElement);
            Controls.Add(textBoxIndexElement);
            Controls.Add(listBoxLstListe);
            Controls.Add(labelLstListe);
            Controls.Add(buttonAjoutListe);
            Controls.Add(textBoxNouvelElement);
            Controls.Add(labelNouvelElement);
            Name = "FormListBox";
            Text = "FormListBox";
            ((System.ComponentModel.ISupportInitialize)errorProviderNouvelElement).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderIndexInvalide).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderHorsLimite).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNouvelElement;
        private TextBox textBoxNouvelElement;
        private Button buttonAjoutListe;
        private Label labelLstListe;
        private ListBox listBoxLstListe;
        private TextBox textBoxIndexElement;
        private Label labelIndexElement;
        private Button buttonSelectionner;
        private Button buttonViderListe;
        private Label labelProprietes;
        private Label labelItemsCount;
        private Label labelSelectedIndex;
        private Label labelText;
        private TextBox textBoxItemsCount;
        private TextBox textBoxSelectedIndex;
        private TextBox textBoxText;
        private ErrorProvider errorProviderNouvelElement;
        private ErrorProvider errorProviderIndexInvalide;
        private ErrorProvider errorProviderHorsLimite;
    }
}