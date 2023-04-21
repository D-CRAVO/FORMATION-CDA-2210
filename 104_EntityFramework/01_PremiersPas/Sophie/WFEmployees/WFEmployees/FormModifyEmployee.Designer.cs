namespace WFEmployees
{
    partial class FormModifyEmployee
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
            buttonValidate = new Button();
            buttonClear = new Button();
            textBoxManagerId = new TextBox();
            labelManagerId = new Label();
            textBoxHireDate = new TextBox();
            labelHireDate = new Label();
            textBoxSalary = new TextBox();
            labelSalary = new Label();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            labelFirstName = new Label();
            labelLastName = new Label();
            labelId = new Label();
            textBoxId = new TextBox();
            SuspendLayout();
            // 
            // buttonValidate
            // 
            buttonValidate.Location = new Point(198, 35);
            buttonValidate.Name = "buttonValidate";
            buttonValidate.Size = new Size(75, 23);
            buttonValidate.TabIndex = 23;
            buttonValidate.Text = "Validate";
            buttonValidate.UseVisualStyleBackColor = true;
            buttonValidate.Click += buttonValidate_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(198, 6);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 22;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            // 
            // textBoxManagerId
            // 
            textBoxManagerId.Location = new Point(92, 152);
            textBoxManagerId.Name = "textBoxManagerId";
            textBoxManagerId.Size = new Size(100, 23);
            textBoxManagerId.TabIndex = 21;
            // 
            // labelManagerId
            // 
            labelManagerId.AutoSize = true;
            labelManagerId.Location = new Point(12, 155);
            labelManagerId.Name = "labelManagerId";
            labelManagerId.Size = new Size(64, 15);
            labelManagerId.TabIndex = 20;
            labelManagerId.Text = "ManagerId";
            // 
            // textBoxHireDate
            // 
            textBoxHireDate.Location = new Point(92, 123);
            textBoxHireDate.Name = "textBoxHireDate";
            textBoxHireDate.Size = new Size(100, 23);
            textBoxHireDate.TabIndex = 19;
            // 
            // labelHireDate
            // 
            labelHireDate.AutoSize = true;
            labelHireDate.Location = new Point(12, 126);
            labelHireDate.Name = "labelHireDate";
            labelHireDate.Size = new Size(53, 15);
            labelHireDate.TabIndex = 18;
            labelHireDate.Text = "HireDate";
            // 
            // textBoxSalary
            // 
            textBoxSalary.Location = new Point(92, 94);
            textBoxSalary.Name = "textBoxSalary";
            textBoxSalary.Size = new Size(100, 23);
            textBoxSalary.TabIndex = 17;
            // 
            // labelSalary
            // 
            labelSalary.AutoSize = true;
            labelSalary.Location = new Point(12, 97);
            labelSalary.Name = "labelSalary";
            labelSalary.Size = new Size(38, 15);
            labelSalary.TabIndex = 16;
            labelSalary.Text = "Salary";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(92, 65);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(100, 23);
            textBoxFirstName.TabIndex = 15;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(92, 36);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(100, 23);
            textBoxLastName.TabIndex = 14;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(12, 68);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(61, 15);
            labelFirstName.TabIndex = 13;
            labelFirstName.Text = "FirstName";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(12, 39);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(60, 15);
            labelLastName.TabIndex = 12;
            labelLastName.Text = "LastName";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(12, 9);
            labelId.Name = "labelId";
            labelId.Size = new Size(17, 15);
            labelId.TabIndex = 24;
            labelId.Text = "Id";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(92, 6);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(100, 23);
            textBoxId.TabIndex = 25;
            // 
            // FormModifyEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 190);
            Controls.Add(textBoxId);
            Controls.Add(labelId);
            Controls.Add(buttonValidate);
            Controls.Add(buttonClear);
            Controls.Add(textBoxManagerId);
            Controls.Add(labelManagerId);
            Controls.Add(textBoxHireDate);
            Controls.Add(labelHireDate);
            Controls.Add(textBoxSalary);
            Controls.Add(labelSalary);
            Controls.Add(textBoxFirstName);
            Controls.Add(textBoxLastName);
            Controls.Add(labelFirstName);
            Controls.Add(labelLastName);
            Name = "FormModifyEmployee";
            Text = "FormModifyEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonValidate;
        private Button buttonClear;
        private TextBox textBoxManagerId;
        private Label labelManagerId;
        private TextBox textBoxHireDate;
        private Label labelHireDate;
        private TextBox textBoxSalary;
        private Label labelSalary;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private Label labelFirstName;
        private Label labelLastName;
        private Label labelId;
        private TextBox textBoxId;
    }
}