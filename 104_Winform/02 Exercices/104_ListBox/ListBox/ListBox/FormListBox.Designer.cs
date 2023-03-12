namespace ListBox
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
            labelNouvelElement = new Label();
            textBoxNouvelElement = new TextBox();
            buttonAjout = new Button();
            listBoxListe = new System.Windows.Forms.ListBox();
            labelListe = new Label();
            labelIndex = new Label();
            textBoxIndex = new TextBox();
            buttonSelectionner = new Button();
            buttonVider = new Button();
            labelProprietes = new Label();
            labelItemsCount = new Label();
            textBoxItemsCount = new TextBox();
            textBoxSelectedIndex = new TextBox();
            labelSelectedIndex = new Label();
            textBoxText = new TextBox();
            labelText = new Label();
            SuspendLayout();
            // 
            // labelNouvelElement
            // 
            labelNouvelElement.AutoSize = true;
            labelNouvelElement.Location = new Point(12, 9);
            labelNouvelElement.Name = "labelNouvelElement";
            labelNouvelElement.Size = new Size(91, 15);
            labelNouvelElement.TabIndex = 0;
            labelNouvelElement.Text = "Nouvel Elément";
            // 
            // textBoxNouvelElement
            // 
            textBoxNouvelElement.Location = new Point(12, 36);
            textBoxNouvelElement.Name = "textBoxNouvelElement";
            textBoxNouvelElement.Size = new Size(125, 23);
            textBoxNouvelElement.TabIndex = 1;
            // 
            // buttonAjout
            // 
            buttonAjout.BackColor = SystemColors.Control;
            buttonAjout.Location = new Point(12, 76);
            buttonAjout.Name = "buttonAjout";
            buttonAjout.Size = new Size(125, 23);
            buttonAjout.TabIndex = 2;
            buttonAjout.Text = "Ajout Liste";
            buttonAjout.UseVisualStyleBackColor = false;
            buttonAjout.Click += buttonAjout_Click;
            // 
            // listBoxListe
            // 
            listBoxListe.FormattingEnabled = true;
            listBoxListe.ItemHeight = 15;
            listBoxListe.Location = new Point(12, 156);
            listBoxListe.Name = "listBoxListe";
            listBoxListe.Size = new Size(125, 94);
            listBoxListe.TabIndex = 3;
            listBoxListe.SelectedIndexChanged += listBoxListe_SelectedIndexChanged;
            // 
            // labelListe
            // 
            labelListe.AutoSize = true;
            labelListe.Location = new Point(12, 120);
            labelListe.Name = "labelListe";
            labelListe.Size = new Size(46, 15);
            labelListe.TabIndex = 4;
            labelListe.Text = "LstListe";
            // 
            // labelIndex
            // 
            labelIndex.AutoSize = true;
            labelIndex.Location = new Point(178, 9);
            labelIndex.Name = "labelIndex";
            labelIndex.Size = new Size(82, 15);
            labelIndex.TabIndex = 5;
            labelIndex.Text = "Index Elément";
            // 
            // textBoxIndex
            // 
            textBoxIndex.Location = new Point(178, 36);
            textBoxIndex.Name = "textBoxIndex";
            textBoxIndex.Size = new Size(40, 23);
            textBoxIndex.TabIndex = 6;
            // 
            // buttonSelectionner
            // 
            buttonSelectionner.Location = new Point(245, 35);
            buttonSelectionner.Name = "buttonSelectionner";
            buttonSelectionner.Size = new Size(130, 23);
            buttonSelectionner.TabIndex = 7;
            buttonSelectionner.Text = "Sélectionner";
            buttonSelectionner.UseVisualStyleBackColor = true;
            buttonSelectionner.Click += buttonSelectionner_Click;
            // 
            // buttonVider
            // 
            buttonVider.Location = new Point(245, 76);
            buttonVider.Name = "buttonVider";
            buttonVider.Size = new Size(130, 23);
            buttonVider.TabIndex = 8;
            buttonVider.Text = "Vider la Liste";
            buttonVider.UseVisualStyleBackColor = true;
            buttonVider.Click += buttonVider_Click;
            // 
            // labelProprietes
            // 
            labelProprietes.AutoSize = true;
            labelProprietes.Location = new Point(178, 120);
            labelProprietes.Name = "labelProprietes";
            labelProprietes.Size = new Size(60, 15);
            labelProprietes.TabIndex = 9;
            labelProprietes.Text = "Propriétés";
            // 
            // labelItemsCount
            // 
            labelItemsCount.AutoSize = true;
            labelItemsCount.Location = new Point(178, 156);
            labelItemsCount.Name = "labelItemsCount";
            labelItemsCount.Size = new Size(72, 15);
            labelItemsCount.TabIndex = 10;
            labelItemsCount.Text = "Items.Count";
            // 
            // textBoxItemsCount
            // 
            textBoxItemsCount.Location = new Point(275, 153);
            textBoxItemsCount.Name = "textBoxItemsCount";
            textBoxItemsCount.ReadOnly = true;
            textBoxItemsCount.Size = new Size(40, 23);
            textBoxItemsCount.TabIndex = 11;
            textBoxItemsCount.TextChanged += textBoxItemsCount_TextChanged;
            // 
            // textBoxSelectedIndex
            // 
            textBoxSelectedIndex.Location = new Point(275, 188);
            textBoxSelectedIndex.Name = "textBoxSelectedIndex";
            textBoxSelectedIndex.ReadOnly = true;
            textBoxSelectedIndex.Size = new Size(40, 23);
            textBoxSelectedIndex.TabIndex = 13;
            // 
            // labelSelectedIndex
            // 
            labelSelectedIndex.AutoSize = true;
            labelSelectedIndex.Location = new Point(178, 191);
            labelSelectedIndex.Name = "labelSelectedIndex";
            labelSelectedIndex.Size = new Size(80, 15);
            labelSelectedIndex.TabIndex = 12;
            labelSelectedIndex.Text = "SelectedIndex";
            // 
            // textBoxText
            // 
            textBoxText.Location = new Point(275, 223);
            textBoxText.Name = "textBoxText";
            textBoxText.ReadOnly = true;
            textBoxText.Size = new Size(100, 23);
            textBoxText.TabIndex = 15;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Location = new Point(178, 226);
            labelText.Name = "labelText";
            labelText.Size = new Size(28, 15);
            labelText.TabIndex = 14;
            labelText.Text = "Text";
            // 
            // FormListBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(textBoxText);
            Controls.Add(labelText);
            Controls.Add(textBoxSelectedIndex);
            Controls.Add(labelSelectedIndex);
            Controls.Add(textBoxItemsCount);
            Controls.Add(labelItemsCount);
            Controls.Add(labelProprietes);
            Controls.Add(buttonVider);
            Controls.Add(buttonSelectionner);
            Controls.Add(textBoxIndex);
            Controls.Add(labelIndex);
            Controls.Add(labelListe);
            Controls.Add(listBoxListe);
            Controls.Add(buttonAjout);
            Controls.Add(textBoxNouvelElement);
            Controls.Add(labelNouvelElement);
            Name = "FormListBox";
            Text = "Les listes et leurs propriétés";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNouvelElement;
        private TextBox textBoxNouvelElement;
        private Button buttonAjout;
        private System.Windows.Forms.ListBox listBoxListe;
        private Label labelListe;
        private Label labelIndex;
        private TextBox textBoxIndex;
        private Button buttonSelectionner;
        private Button buttonVider;
        private Label labelProprietes;
        private Label labelItemsCount;
        private TextBox textBoxItemsCount;
        private TextBox textBoxSelectedIndex;
        private Label labelSelectedIndex;
        private TextBox textBoxText;
        private Label labelText;
    }
}