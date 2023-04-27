namespace WFSpa
{
    partial class FormSpa
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
            labelName = new Label();
            textBoxName = new TextBox();
            labelAge = new Label();
            numericUpDownAge = new NumericUpDown();
            labelRace = new Label();
            comboBoxRace = new ComboBox();
            buttonCreate = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            textBoxPuce = new TextBox();
            errorProviderPuce = new ErrorProvider(components);
            comboBoxPuce = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPuce).BeginInit();
            SuspendLayout();
            // 
            // labelPuce
            // 
            labelPuce.AutoSize = true;
            labelPuce.Location = new Point(12, 15);
            labelPuce.Name = "labelPuce";
            labelPuce.Size = new Size(33, 15);
            labelPuce.TabIndex = 0;
            labelPuce.Text = "Puce";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(12, 73);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 2;
            labelName.Text = "Name";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(62, 70);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(216, 23);
            textBoxName.TabIndex = 3;
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Location = new Point(12, 102);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(28, 15);
            labelAge.TabIndex = 4;
            labelAge.Text = "Age";
            // 
            // numericUpDownAge
            // 
            numericUpDownAge.Location = new Point(62, 99);
            numericUpDownAge.Name = "numericUpDownAge";
            numericUpDownAge.Size = new Size(81, 23);
            numericUpDownAge.TabIndex = 5;
            // 
            // labelRace
            // 
            labelRace.AutoSize = true;
            labelRace.Location = new Point(149, 102);
            labelRace.Name = "labelRace";
            labelRace.Size = new Size(32, 15);
            labelRace.TabIndex = 6;
            labelRace.Text = "Race";
            // 
            // comboBoxRace
            // 
            comboBoxRace.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRace.FormattingEnabled = true;
            comboBoxRace.Location = new Point(187, 99);
            comboBoxRace.Name = "comboBoxRace";
            comboBoxRace.Size = new Size(91, 23);
            comboBoxRace.TabIndex = 7;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(12, 128);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(75, 23);
            buttonCreate.TabIndex = 8;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(106, 128);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 23);
            buttonUpdate.TabIndex = 9;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(203, 128);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 10;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // textBoxPuce
            // 
            textBoxPuce.Location = new Point(62, 12);
            textBoxPuce.Name = "textBoxPuce";
            textBoxPuce.Size = new Size(216, 23);
            textBoxPuce.TabIndex = 11;
            // 
            // errorProviderPuce
            // 
            errorProviderPuce.ContainerControl = this;
            // 
            // comboBoxPuce
            // 
            comboBoxPuce.FormattingEnabled = true;
            comboBoxPuce.Location = new Point(62, 41);
            comboBoxPuce.Name = "comboBoxPuce";
            comboBoxPuce.Size = new Size(216, 23);
            comboBoxPuce.TabIndex = 12;
            comboBoxPuce.SelectedIndexChanged += comboBoxPuce_SelectedIndexChanged;
            // 
            // FormSpa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 176);
            Controls.Add(comboBoxPuce);
            Controls.Add(textBoxPuce);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonCreate);
            Controls.Add(comboBoxRace);
            Controls.Add(labelRace);
            Controls.Add(numericUpDownAge);
            Controls.Add(labelAge);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Controls.Add(labelPuce);
            Name = "FormSpa";
            Text = "FormSpa";
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPuce).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPuce;
        private Label labelName;
        private TextBox textBoxName;
        private Label labelAge;
        private NumericUpDown numericUpDownAge;
        private Label labelRace;
        private ComboBox comboBoxRace;
        private Button buttonCreate;
        private Button buttonUpdate;
        private Button buttonDelete;
        private TextBox textBoxPuce;
        private ErrorProvider errorProviderPuce;
        private ComboBox comboBoxPuce;
    }
}