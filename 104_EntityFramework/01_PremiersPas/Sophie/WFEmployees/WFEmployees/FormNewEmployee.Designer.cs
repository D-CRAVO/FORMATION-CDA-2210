namespace WFEmployees
{
    partial class FormNewEmployee
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
            labelLastName = new Label();
            labelFirstName = new Label();
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            labelSalary = new Label();
            textBoxSalary = new TextBox();
            labelHireDate = new Label();
            textBoxHireDate = new TextBox();
            labelManagerId = new Label();
            textBoxManagerId = new TextBox();
            buttonClear = new Button();
            buttonValidate = new Button();
            SuspendLayout();
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(26, 29);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(60, 15);
            labelLastName.TabIndex = 0;
            labelLastName.Text = "LastName";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(26, 58);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(61, 15);
            labelFirstName.TabIndex = 1;
            labelFirstName.Text = "FirstName";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(106, 26);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(100, 23);
            textBoxLastName.TabIndex = 2;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(106, 55);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(100, 23);
            textBoxFirstName.TabIndex = 3;
            // 
            // labelSalary
            // 
            labelSalary.AutoSize = true;
            labelSalary.Location = new Point(26, 87);
            labelSalary.Name = "labelSalary";
            labelSalary.Size = new Size(38, 15);
            labelSalary.TabIndex = 4;
            labelSalary.Text = "Salary";
            // 
            // textBoxSalary
            // 
            textBoxSalary.Location = new Point(106, 84);
            textBoxSalary.Name = "textBoxSalary";
            textBoxSalary.Size = new Size(100, 23);
            textBoxSalary.TabIndex = 5;
            // 
            // labelHireDate
            // 
            labelHireDate.AutoSize = true;
            labelHireDate.Location = new Point(26, 116);
            labelHireDate.Name = "labelHireDate";
            labelHireDate.Size = new Size(53, 15);
            labelHireDate.TabIndex = 6;
            labelHireDate.Text = "HireDate";
            // 
            // textBoxHireDate
            // 
            textBoxHireDate.Location = new Point(106, 113);
            textBoxHireDate.Name = "textBoxHireDate";
            textBoxHireDate.Size = new Size(100, 23);
            textBoxHireDate.TabIndex = 7;
            // 
            // labelManagerId
            // 
            labelManagerId.AutoSize = true;
            labelManagerId.Location = new Point(22, 145);
            labelManagerId.Name = "labelManagerId";
            labelManagerId.Size = new Size(64, 15);
            labelManagerId.TabIndex = 8;
            labelManagerId.Text = "ManagerId";
            // 
            // textBoxManagerId
            // 
            textBoxManagerId.Location = new Point(106, 142);
            textBoxManagerId.Name = "textBoxManagerId";
            textBoxManagerId.Size = new Size(100, 23);
            textBoxManagerId.TabIndex = 9;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(212, 26);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 10;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonValidate
            // 
            buttonValidate.Location = new Point(212, 55);
            buttonValidate.Name = "buttonValidate";
            buttonValidate.Size = new Size(75, 23);
            buttonValidate.TabIndex = 11;
            buttonValidate.Text = "Validate";
            buttonValidate.UseVisualStyleBackColor = true;
            buttonValidate.Click += buttonValidate_Click;
            // 
            // FormNewEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 178);
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
            Name = "FormNewEmployee";
            Text = "FormNewEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLastName;
        private Label labelFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private Label labelSalary;
        private TextBox textBoxSalary;
        private Label labelHireDate;
        private TextBox textBoxHireDate;
        private Label labelManagerId;
        private TextBox textBoxManagerId;
        private Button buttonClear;
        private Button buttonValidate;
    }
}