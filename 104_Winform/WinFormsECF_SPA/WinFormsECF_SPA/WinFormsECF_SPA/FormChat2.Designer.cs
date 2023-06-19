namespace WinFormsECF_SPA
{
    partial class FormChat2
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
            buttonUpdate = new Button();
            comboBoxRace = new ComboBox();
            textBoxName = new TextBox();
            textBoxPuceNumber = new TextBox();
            labelAge = new Label();
            labelRace = new Label();
            labelName = new Label();
            labelPuce = new Label();
            errorProviderPuceNumber = new ErrorProvider(components);
            numericUpDownAge = new NumericUpDown();
            errorProviderNom = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderPuceNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderNom).BeginInit();
            SuspendLayout();
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(424, 147);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 23);
            buttonUpdate.TabIndex = 17;
            buttonUpdate.Text = "Modifier";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // comboBoxRace
            // 
            comboBoxRace.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRace.FormattingEnabled = true;
            comboBoxRace.Location = new Point(119, 108);
            comboBoxRace.Name = "comboBoxRace";
            comboBoxRace.Size = new Size(121, 23);
            comboBoxRace.TabIndex = 16;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(119, 65);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(148, 23);
            textBoxName.TabIndex = 14;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // textBoxPuceNumber
            // 
            textBoxPuceNumber.Location = new Point(119, 17);
            textBoxPuceNumber.Name = "textBoxPuceNumber";
            textBoxPuceNumber.Size = new Size(253, 23);
            textBoxPuceNumber.TabIndex = 13;
            textBoxPuceNumber.TextChanged += textBoxPuceNumber_TextChanged;
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Location = new Point(302, 73);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(28, 15);
            labelAge.TabIndex = 12;
            labelAge.Text = "Age";
            // 
            // labelRace
            // 
            labelRace.AutoSize = true;
            labelRace.Location = new Point(45, 119);
            labelRace.Name = "labelRace";
            labelRace.Size = new Size(32, 15);
            labelRace.TabIndex = 11;
            labelRace.Text = "Race";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(45, 73);
            labelName.Name = "labelName";
            labelName.Size = new Size(34, 15);
            labelName.TabIndex = 10;
            labelName.Text = "Nom";
            // 
            // labelPuce
            // 
            labelPuce.AutoSize = true;
            labelPuce.Location = new Point(45, 25);
            labelPuce.Name = "labelPuce";
            labelPuce.Size = new Size(33, 15);
            labelPuce.TabIndex = 9;
            labelPuce.Text = "Puce";
            // 
            // errorProviderPuceNumber
            // 
            errorProviderPuceNumber.ContainerControl = this;
            // 
            // numericUpDownAge
            // 
            numericUpDownAge.Location = new Point(347, 71);
            numericUpDownAge.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDownAge.Name = "numericUpDownAge";
            numericUpDownAge.Size = new Size(120, 23);
            numericUpDownAge.TabIndex = 18;
            numericUpDownAge.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // errorProviderNom
            // 
            errorProviderNom.ContainerControl = this;
            // 
            // FormChat2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 222);
            Controls.Add(numericUpDownAge);
            Controls.Add(buttonUpdate);
            Controls.Add(comboBoxRace);
            Controls.Add(textBoxName);
            Controls.Add(textBoxPuceNumber);
            Controls.Add(labelAge);
            Controls.Add(labelRace);
            Controls.Add(labelName);
            Controls.Add(labelPuce);
            Name = "FormChat2";
            Text = "è";
            ((System.ComponentModel.ISupportInitialize)errorProviderPuceNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderNom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonUpdate;
        private ComboBox comboBoxRace;
        private TextBox textBoxAge;
        private TextBox textBoxName;
        private TextBox textBoxPuceNumber;
        private Label labelAge;
        private Label labelRace;
        private Label labelName;
        private Label labelPuce;
        private ErrorProvider errorProviderPuceNumber;
        private NumericUpDown numericUpDownAge;
        private ErrorProvider errorProviderNom;
    }
}