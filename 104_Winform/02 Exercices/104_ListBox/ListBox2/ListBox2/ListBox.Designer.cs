namespace ListBox2
{
    partial class ListBox
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelText = new System.Windows.Forms.Label();
            this.textBoxSelectedIndex = new System.Windows.Forms.TextBox();
            this.labelSelectedIndex = new System.Windows.Forms.Label();
            this.textBoxItemsCount = new System.Windows.Forms.TextBox();
            this.labelItemsCount = new System.Windows.Forms.Label();
            this.labelProprietes = new System.Windows.Forms.Label();
            this.buttonVider = new System.Windows.Forms.Button();
            this.buttonSelectionner = new System.Windows.Forms.Button();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.labelIndexElement = new System.Windows.Forms.Label();
            this.listBoxListe = new System.Windows.Forms.ListBox();
            this.labelLstListe = new System.Windows.Forms.Label();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.textBoxNouvelElement = new System.Windows.Forms.TextBox();
            this.labelNouvelElement = new System.Windows.Forms.Label();
            this.errorProviderIndex = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDoublons = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTexteInvalide = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDoublons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTexteInvalide)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(255, 193);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 31;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(161, 196);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(28, 15);
            this.labelText.TabIndex = 30;
            this.labelText.Text = "Text";
            // 
            // textBoxSelectedIndex
            // 
            this.textBoxSelectedIndex.Location = new System.Drawing.Point(255, 160);
            this.textBoxSelectedIndex.Name = "textBoxSelectedIndex";
            this.textBoxSelectedIndex.ReadOnly = true;
            this.textBoxSelectedIndex.Size = new System.Drawing.Size(40, 23);
            this.textBoxSelectedIndex.TabIndex = 29;
            // 
            // labelSelectedIndex
            // 
            this.labelSelectedIndex.AutoSize = true;
            this.labelSelectedIndex.Location = new System.Drawing.Point(161, 163);
            this.labelSelectedIndex.Name = "labelSelectedIndex";
            this.labelSelectedIndex.Size = new System.Drawing.Size(80, 15);
            this.labelSelectedIndex.TabIndex = 28;
            this.labelSelectedIndex.Text = "SelectedIndex";
            // 
            // textBoxItemsCount
            // 
            this.textBoxItemsCount.Location = new System.Drawing.Point(255, 124);
            this.textBoxItemsCount.Name = "textBoxItemsCount";
            this.textBoxItemsCount.ReadOnly = true;
            this.textBoxItemsCount.Size = new System.Drawing.Size(40, 23);
            this.textBoxItemsCount.TabIndex = 27;
            // 
            // labelItemsCount
            // 
            this.labelItemsCount.AutoSize = true;
            this.labelItemsCount.Location = new System.Drawing.Point(161, 132);
            this.labelItemsCount.Name = "labelItemsCount";
            this.labelItemsCount.Size = new System.Drawing.Size(72, 15);
            this.labelItemsCount.TabIndex = 26;
            this.labelItemsCount.Text = "Items.Count";
            // 
            // labelProprietes
            // 
            this.labelProprietes.AutoSize = true;
            this.labelProprietes.Location = new System.Drawing.Point(161, 101);
            this.labelProprietes.Name = "labelProprietes";
            this.labelProprietes.Size = new System.Drawing.Size(60, 15);
            this.labelProprietes.TabIndex = 25;
            this.labelProprietes.Text = "Propriétés";
            // 
            // buttonVider
            // 
            this.buttonVider.Location = new System.Drawing.Point(219, 55);
            this.buttonVider.Name = "buttonVider";
            this.buttonVider.Size = new System.Drawing.Size(136, 23);
            this.buttonVider.TabIndex = 24;
            this.buttonVider.Text = "Vider la Liste";
            this.buttonVider.UseVisualStyleBackColor = true;
            // 
            // buttonSelectionner
            // 
            this.buttonSelectionner.Location = new System.Drawing.Point(219, 26);
            this.buttonSelectionner.Name = "buttonSelectionner";
            this.buttonSelectionner.Size = new System.Drawing.Size(136, 23);
            this.buttonSelectionner.TabIndex = 23;
            this.buttonSelectionner.Text = "Selectionner";
            this.buttonSelectionner.UseVisualStyleBackColor = true;
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Location = new System.Drawing.Point(161, 27);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(40, 23);
            this.textBoxIndex.TabIndex = 22;
            this.textBoxIndex.TextChanged += new System.EventHandler(this.textBoxIndex_TextChanged);
            // 
            // labelIndexElement
            // 
            this.labelIndexElement.AutoSize = true;
            this.labelIndexElement.Location = new System.Drawing.Point(161, 9);
            this.labelIndexElement.Name = "labelIndexElement";
            this.labelIndexElement.Size = new System.Drawing.Size(82, 15);
            this.labelIndexElement.TabIndex = 21;
            this.labelIndexElement.Text = "Index Elément";
            // 
            // listBoxListe
            // 
            this.listBoxListe.FormattingEnabled = true;
            this.listBoxListe.ItemHeight = 15;
            this.listBoxListe.Location = new System.Drawing.Point(12, 119);
            this.listBoxListe.Name = "listBoxListe";
            this.listBoxListe.Size = new System.Drawing.Size(120, 109);
            this.listBoxListe.TabIndex = 20;
            // 
            // labelLstListe
            // 
            this.labelLstListe.AutoSize = true;
            this.labelLstListe.Location = new System.Drawing.Point(12, 101);
            this.labelLstListe.Name = "labelLstListe";
            this.labelLstListe.Size = new System.Drawing.Size(46, 15);
            this.labelLstListe.TabIndex = 19;
            this.labelLstListe.Text = "LstListe";
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(12, 56);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(120, 23);
            this.buttonAjouter.TabIndex = 18;
            this.buttonAjouter.Text = "Ajout Liste";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // textBoxNouvelElement
            // 
            this.textBoxNouvelElement.Location = new System.Drawing.Point(12, 27);
            this.textBoxNouvelElement.Name = "textBoxNouvelElement";
            this.textBoxNouvelElement.Size = new System.Drawing.Size(120, 23);
            this.textBoxNouvelElement.TabIndex = 17;
            this.textBoxNouvelElement.TextChanged += new System.EventHandler(this.textBoxNouvelElement_TextChanged);
            // 
            // labelNouvelElement
            // 
            this.labelNouvelElement.Location = new System.Drawing.Point(12, 9);
            this.labelNouvelElement.Name = "labelNouvelElement";
            this.labelNouvelElement.Size = new System.Drawing.Size(120, 15);
            this.labelNouvelElement.TabIndex = 16;
            this.labelNouvelElement.Text = "Nouvel Elément";
            // 
            // errorProviderIndex
            // 
            this.errorProviderIndex.ContainerControl = this;
            // 
            // errorProviderDoublons
            // 
            this.errorProviderDoublons.ContainerControl = this;
            // 
            // errorProviderTexteInvalide
            // 
            this.errorProviderTexteInvalide.ContainerControl = this;
            // 
            // ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.textBoxSelectedIndex);
            this.Controls.Add(this.labelSelectedIndex);
            this.Controls.Add(this.textBoxItemsCount);
            this.Controls.Add(this.labelItemsCount);
            this.Controls.Add(this.labelProprietes);
            this.Controls.Add(this.buttonVider);
            this.Controls.Add(this.buttonSelectionner);
            this.Controls.Add(this.textBoxIndex);
            this.Controls.Add(this.labelIndexElement);
            this.Controls.Add(this.listBoxListe);
            this.Controls.Add(this.labelLstListe);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.textBoxNouvelElement);
            this.Controls.Add(this.labelNouvelElement);
            this.Name = "ListBox";
            this.Text = "ListBox";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDoublons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTexteInvalide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Label labelText;
        private TextBox textBoxSelectedIndex;
        private Label labelSelectedIndex;
        private TextBox textBoxItemsCount;
        private Label labelItemsCount;
        private Label labelProprietes;
        private Button buttonVider;
        private Button buttonSelectionner;
        private TextBox textBoxIndex;
        private Label labelIndexElement;
        private System.Windows.Forms.ListBox listBoxListe;
        private Label labelLstListe;
        private Button buttonAjouter;
        private TextBox textBoxNouvelElement;
        private Label labelNouvelElement;
        private ErrorProvider errorProviderIndex;
        private ErrorProvider errorProviderDoublons;
        private ErrorProvider errorProviderTexteInvalide;
    }
}