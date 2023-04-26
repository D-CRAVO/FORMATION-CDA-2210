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
            numericUpDown1 = new NumericUpDown();
            labelRace = new Label();
            comboBox2 = new ComboBox();
            buttonCreate = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            textBox2 = new TextBox();
            errorProviderPuce = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            labelName.Location = new Point(12, 44);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 2;
            labelName.Text = "Name";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(62, 41);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(216, 23);
            textBoxName.TabIndex = 3;
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Location = new Point(12, 73);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(28, 15);
            labelAge.TabIndex = 4;
            labelAge.Text = "Age";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(62, 70);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(81, 23);
            numericUpDown1.TabIndex = 5;
            // 
            // labelRace
            // 
            labelRace.AutoSize = true;
            labelRace.Location = new Point(149, 73);
            labelRace.Name = "labelRace";
            labelRace.Size = new Size(32, 15);
            labelRace.TabIndex = 6;
            labelRace.Text = "Race";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(187, 70);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(91, 23);
            comboBox2.TabIndex = 7;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(12, 99);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(75, 23);
            buttonCreate.TabIndex = 8;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(106, 99);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 23);
            buttonUpdate.TabIndex = 9;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(203, 99);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 10;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(62, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(216, 23);
            textBox2.TabIndex = 11;
            // 
            // errorProviderPuce
            // 
            errorProviderPuce.ContainerControl = this;
            // 
            // FormSpa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 133);
            Controls.Add(textBox2);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonCreate);
            Controls.Add(comboBox2);
            Controls.Add(labelRace);
            Controls.Add(numericUpDown1);
            Controls.Add(labelAge);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Controls.Add(labelPuce);
            Name = "FormSpa";
            Text = "FormSpa";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPuce).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPuce;
        private Label labelName;
        private TextBox textBoxName;
        private Label labelAge;
        private NumericUpDown numericUpDown1;
        private Label labelRace;
        private ComboBox comboBox2;
        private Button buttonCreate;
        private Button buttonUpdate;
        private Button buttonDelete;
        private TextBox textBox2;
        private ErrorProvider errorProviderPuce;
    }
}