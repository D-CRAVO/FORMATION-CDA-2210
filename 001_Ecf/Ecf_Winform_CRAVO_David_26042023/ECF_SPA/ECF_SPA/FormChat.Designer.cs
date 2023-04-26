namespace ECF_SPA
{
    partial class FormChat
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
            labelPuce = new Label();
            labelNom = new Label();
            labelRace = new Label();
            labelAge = new Label();
            textBoxNom = new TextBox();
            numericUpDownAge = new NumericUpDown();
            comboBoxRace = new ComboBox();
            buttonModifier = new Button();
            errorProviderPuce = new ErrorProvider(components);
            dataGridViewChats = new DataGridView();
            comboBoxPuce = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPuce).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewChats).BeginInit();
            SuspendLayout();
            // 
            // labelPuce
            // 
            labelPuce.AutoSize = true;
            labelPuce.Location = new Point(492, 23);
            labelPuce.Name = "labelPuce";
            labelPuce.Size = new Size(33, 15);
            labelPuce.TabIndex = 0;
            labelPuce.Text = "Puce";
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(492, 59);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(34, 15);
            labelNom.TabIndex = 2;
            labelNom.Text = "Nom";
            // 
            // labelRace
            // 
            labelRace.AutoSize = true;
            labelRace.Location = new Point(492, 133);
            labelRace.Name = "labelRace";
            labelRace.Size = new Size(32, 15);
            labelRace.TabIndex = 3;
            labelRace.Text = "Race";
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Location = new Point(492, 96);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(28, 15);
            labelAge.TabIndex = 4;
            labelAge.Text = "Age";
            // 
            // textBoxNom
            // 
            textBoxNom.Location = new Point(542, 56);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(100, 23);
            textBoxNom.TabIndex = 5;
            // 
            // numericUpDownAge
            // 
            numericUpDownAge.Location = new Point(543, 94);
            numericUpDownAge.Name = "numericUpDownAge";
            numericUpDownAge.Size = new Size(120, 23);
            numericUpDownAge.TabIndex = 6;
            // 
            // comboBoxRace
            // 
            comboBoxRace.FormattingEnabled = true;
            comboBoxRace.Location = new Point(542, 130);
            comboBoxRace.Name = "comboBoxRace";
            comboBoxRace.Size = new Size(121, 23);
            comboBoxRace.TabIndex = 7;
            // 
            // buttonModifier
            // 
            buttonModifier.Location = new Point(569, 192);
            buttonModifier.Name = "buttonModifier";
            buttonModifier.Size = new Size(75, 23);
            buttonModifier.TabIndex = 8;
            buttonModifier.Text = "Modifier";
            buttonModifier.UseVisualStyleBackColor = true;
            buttonModifier.Click += buttonModifier_Click;
            // 
            // errorProviderPuce
            // 
            errorProviderPuce.ContainerControl = this;
            // 
            // dataGridViewChats
            // 
            dataGridViewChats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewChats.Location = new Point(12, 12);
            dataGridViewChats.Name = "dataGridViewChats";
            dataGridViewChats.RowTemplate.Height = 25;
            dataGridViewChats.Size = new Size(460, 349);
            dataGridViewChats.TabIndex = 10;
            // 
            // comboBoxPuce
            // 
            comboBoxPuce.FormattingEnabled = true;
            comboBoxPuce.Location = new Point(542, 20);
            comboBoxPuce.Name = "comboBoxPuce";
            comboBoxPuce.Size = new Size(197, 23);
            comboBoxPuce.TabIndex = 11;
            // 
            // FormChat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 384);
            Controls.Add(comboBoxPuce);
            Controls.Add(dataGridViewChats);
            Controls.Add(buttonModifier);
            Controls.Add(comboBoxRace);
            Controls.Add(numericUpDownAge);
            Controls.Add(textBoxNom);
            Controls.Add(labelAge);
            Controls.Add(labelRace);
            Controls.Add(labelNom);
            Controls.Add(labelPuce);
            Name = "FormChat";
            Text = "FormChat";
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPuce).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewChats).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPuce;
        private Label labelNom;
        private Label labelRace;
        private Label labelAge;
        private TextBox textBoxNom;
        private NumericUpDown numericUpDownAge;
        private ComboBox comboBoxRace;
        private Button buttonModifier;
        private ErrorProvider errorProviderPuce;
        private DataGridView dataGridViewChats;
        private TextBox textBoxPuce;
        private ComboBox comboBoxPuce;
    }
}