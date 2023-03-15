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
            this.components = new System.ComponentModel.Container();
            this.labelNouvelElement = new System.Windows.Forms.Label();
            this.textBoxNouvelElement = new System.Windows.Forms.TextBox();
            this.buttonAjout = new System.Windows.Forms.Button();
            this.listBoxListe = new System.Windows.Forms.ListBox();
            this.labelListe = new System.Windows.Forms.Label();
            this.labelIndex = new System.Windows.Forms.Label();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.buttonSelectionner = new System.Windows.Forms.Button();
            this.buttonVider = new System.Windows.Forms.Button();
            this.labelProprietes = new System.Windows.Forms.Label();
            this.labelItemsCount = new System.Windows.Forms.Label();
            this.textBoxItemsCount = new System.Windows.Forms.TextBox();
            this.textBoxSelectedIndex = new System.Windows.Forms.TextBox();
            this.labelSelectedIndex = new System.Windows.Forms.Label();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.labelText = new System.Windows.Forms.Label();
            this.errorProviderIndex = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNouvelElement
            // 
            this.labelNouvelElement.AutoSize = true;
            this.labelNouvelElement.Location = new System.Drawing.Point(12, 9);
            this.labelNouvelElement.Name = "labelNouvelElement";
            this.labelNouvelElement.Size = new System.Drawing.Size(91, 15);
            this.labelNouvelElement.TabIndex = 0;
            this.labelNouvelElement.Text = "Nouvel Elément";
            // 
            // textBoxNouvelElement
            // 
            this.textBoxNouvelElement.Location = new System.Drawing.Point(12, 36);
            this.textBoxNouvelElement.Name = "textBoxNouvelElement";
            this.textBoxNouvelElement.Size = new System.Drawing.Size(125, 23);
            this.textBoxNouvelElement.TabIndex = 1;
            // 
            // buttonAjout
            // 
            this.buttonAjout.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAjout.Location = new System.Drawing.Point(12, 76);
            this.buttonAjout.Name = "buttonAjout";
            this.buttonAjout.Size = new System.Drawing.Size(125, 23);
            this.buttonAjout.TabIndex = 2;
            this.buttonAjout.Text = "Ajout Liste";
            this.buttonAjout.UseVisualStyleBackColor = false;
            this.buttonAjout.Click += new System.EventHandler(this.buttonAjout_Click);
            // 
            // listBoxListe
            // 
            this.listBoxListe.FormattingEnabled = true;
            this.listBoxListe.ItemHeight = 15;
            this.listBoxListe.Location = new System.Drawing.Point(12, 156);
            this.listBoxListe.Name = "listBoxListe";
            this.listBoxListe.Size = new System.Drawing.Size(125, 94);
            this.listBoxListe.TabIndex = 3;
            // 
            // labelListe
            // 
            this.labelListe.AutoSize = true;
            this.labelListe.Location = new System.Drawing.Point(12, 120);
            this.labelListe.Name = "labelListe";
            this.labelListe.Size = new System.Drawing.Size(46, 15);
            this.labelListe.TabIndex = 4;
            this.labelListe.Text = "LstListe";
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Location = new System.Drawing.Point(178, 9);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(82, 15);
            this.labelIndex.TabIndex = 5;
            this.labelIndex.Text = "Index Elément";
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Location = new System.Drawing.Point(178, 36);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(40, 23);
            this.textBoxIndex.TabIndex = 6;
            // 
            // buttonSelectionner
            // 
            this.buttonSelectionner.Location = new System.Drawing.Point(245, 35);
            this.buttonSelectionner.Name = "buttonSelectionner";
            this.buttonSelectionner.Size = new System.Drawing.Size(130, 23);
            this.buttonSelectionner.TabIndex = 7;
            this.buttonSelectionner.Text = "Sélectionner";
            this.buttonSelectionner.UseVisualStyleBackColor = true;
            this.buttonSelectionner.Click += new System.EventHandler(this.buttonSelectionner_Click);
            // 
            // buttonVider
            // 
            this.buttonVider.Location = new System.Drawing.Point(245, 76);
            this.buttonVider.Name = "buttonVider";
            this.buttonVider.Size = new System.Drawing.Size(130, 23);
            this.buttonVider.TabIndex = 8;
            this.buttonVider.Text = "Vider la Liste";
            this.buttonVider.UseVisualStyleBackColor = true;
            this.buttonVider.Click += new System.EventHandler(this.buttonVider_Click);
            // 
            // labelProprietes
            // 
            this.labelProprietes.AutoSize = true;
            this.labelProprietes.Location = new System.Drawing.Point(178, 120);
            this.labelProprietes.Name = "labelProprietes";
            this.labelProprietes.Size = new System.Drawing.Size(60, 15);
            this.labelProprietes.TabIndex = 9;
            this.labelProprietes.Text = "Propriétés";
            // 
            // labelItemsCount
            // 
            this.labelItemsCount.AutoSize = true;
            this.labelItemsCount.Location = new System.Drawing.Point(178, 156);
            this.labelItemsCount.Name = "labelItemsCount";
            this.labelItemsCount.Size = new System.Drawing.Size(72, 15);
            this.labelItemsCount.TabIndex = 10;
            this.labelItemsCount.Text = "Items.Count";
            // 
            // textBoxItemsCount
            // 
            this.textBoxItemsCount.Location = new System.Drawing.Point(275, 153);
            this.textBoxItemsCount.Name = "textBoxItemsCount";
            this.textBoxItemsCount.ReadOnly = true;
            this.textBoxItemsCount.Size = new System.Drawing.Size(40, 23);
            this.textBoxItemsCount.TabIndex = 11;
            this.textBoxItemsCount.TextChanged += new System.EventHandler(this.textBoxItemsCount_TextChanged);
            // 
            // textBoxSelectedIndex
            // 
            this.textBoxSelectedIndex.Location = new System.Drawing.Point(275, 188);
            this.textBoxSelectedIndex.Name = "textBoxSelectedIndex";
            this.textBoxSelectedIndex.ReadOnly = true;
            this.textBoxSelectedIndex.Size = new System.Drawing.Size(40, 23);
            this.textBoxSelectedIndex.TabIndex = 13;
            this.textBoxSelectedIndex.TextChanged += new System.EventHandler(this.textBoxSelectedIndex_TextChanged);
            // 
            // labelSelectedIndex
            // 
            this.labelSelectedIndex.AutoSize = true;
            this.labelSelectedIndex.Location = new System.Drawing.Point(178, 191);
            this.labelSelectedIndex.Name = "labelSelectedIndex";
            this.labelSelectedIndex.Size = new System.Drawing.Size(80, 15);
            this.labelSelectedIndex.TabIndex = 12;
            this.labelSelectedIndex.Text = "SelectedIndex";
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(275, 223);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.ReadOnly = true;
            this.textBoxText.Size = new System.Drawing.Size(100, 23);
            this.textBoxText.TabIndex = 15;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(178, 226);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(28, 15);
            this.labelText.TabIndex = 14;
            this.labelText.Text = "Text";
            // 
            // errorProviderIndex
            // 
            this.errorProviderIndex.ContainerControl = this;
            // 
            // FormListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.textBoxSelectedIndex);
            this.Controls.Add(this.labelSelectedIndex);
            this.Controls.Add(this.textBoxItemsCount);
            this.Controls.Add(this.labelItemsCount);
            this.Controls.Add(this.labelProprietes);
            this.Controls.Add(this.buttonVider);
            this.Controls.Add(this.buttonSelectionner);
            this.Controls.Add(this.textBoxIndex);
            this.Controls.Add(this.labelIndex);
            this.Controls.Add(this.labelListe);
            this.Controls.Add(this.listBoxListe);
            this.Controls.Add(this.buttonAjout);
            this.Controls.Add(this.textBoxNouvelElement);
            this.Controls.Add(this.labelNouvelElement);
            this.Name = "FormListBox";
            this.Text = "Les listes et leurs propriétés";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private ErrorProvider errorProviderIndex;
    }
}