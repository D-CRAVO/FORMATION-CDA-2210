namespace WFEmployees2
{
    partial class FormUpdateCreate
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
            textBoxId = new TextBox();
            labelId = new Label();
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
            errorProviderLastname = new ErrorProvider(components);
            errorProviderFirstname = new ErrorProvider(components);
            errorProviderSalary = new ErrorProvider(components);
            errorProviderHiredate = new ErrorProvider(components);
            errorProviderManagerId = new ErrorProvider(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProviderLastname).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderFirstname).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderHiredate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderManagerId).BeginInit();
            SuspendLayout();
            // 
            // textBoxId
            // 
            textBoxId.Enabled = false;
            textBoxId.Location = new Point(92, 6);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(100, 23);
            textBoxId.TabIndex = 39;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(12, 9);
            labelId.Name = "labelId";
            labelId.Size = new Size(17, 15);
            labelId.TabIndex = 38;
            labelId.Text = "Id";
            // 
            // buttonValidate
            // 
            buttonValidate.Location = new Point(224, 35);
            buttonValidate.Name = "buttonValidate";
            buttonValidate.Size = new Size(75, 23);
            buttonValidate.TabIndex = 37;
            buttonValidate.Text = "Validate";
            buttonValidate.UseVisualStyleBackColor = true;
            buttonValidate.Click += buttonValidate_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(224, 6);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 36;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // textBoxManagerId
            // 
            textBoxManagerId.Location = new Point(92, 152);
            textBoxManagerId.Name = "textBoxManagerId";
            textBoxManagerId.Size = new Size(100, 23);
            textBoxManagerId.TabIndex = 35;
            textBoxManagerId.TextChanged += textBoxManagerId_TextChanged;
            // 
            // labelManagerId
            // 
            labelManagerId.AutoSize = true;
            labelManagerId.Location = new Point(12, 155);
            labelManagerId.Name = "labelManagerId";
            labelManagerId.Size = new Size(64, 15);
            labelManagerId.TabIndex = 34;
            labelManagerId.Text = "ManagerId";
            // 
            // textBoxHireDate
            // 
            textBoxHireDate.Location = new Point(92, 123);
            textBoxHireDate.Name = "textBoxHireDate";
            textBoxHireDate.Size = new Size(100, 23);
            textBoxHireDate.TabIndex = 33;
            textBoxHireDate.TextChanged += textBoxHireDate_TextChanged;
            // 
            // labelHireDate
            // 
            labelHireDate.AutoSize = true;
            labelHireDate.Location = new Point(12, 126);
            labelHireDate.Name = "labelHireDate";
            labelHireDate.Size = new Size(53, 15);
            labelHireDate.TabIndex = 32;
            labelHireDate.Text = "HireDate";
            // 
            // textBoxSalary
            // 
            textBoxSalary.Location = new Point(92, 94);
            textBoxSalary.Name = "textBoxSalary";
            textBoxSalary.Size = new Size(100, 23);
            textBoxSalary.TabIndex = 31;
            textBoxSalary.TextChanged += textBoxSalary_TextChanged;
            // 
            // labelSalary
            // 
            labelSalary.AutoSize = true;
            labelSalary.Location = new Point(12, 97);
            labelSalary.Name = "labelSalary";
            labelSalary.Size = new Size(38, 15);
            labelSalary.TabIndex = 30;
            labelSalary.Text = "Salary";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(92, 65);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(100, 23);
            textBoxFirstName.TabIndex = 29;
            textBoxFirstName.TextChanged += textBoxFirstName_TextChanged;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(92, 36);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(100, 23);
            textBoxLastName.TabIndex = 28;
            textBoxLastName.TextChanged += textBoxLastName_TextChanged;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(12, 68);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(61, 15);
            labelFirstName.TabIndex = 27;
            labelFirstName.Text = "FirstName";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(12, 39);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(60, 15);
            labelLastName.TabIndex = 26;
            labelLastName.Text = "LastName";
            // 
            // errorProviderLastname
            // 
            errorProviderLastname.ContainerControl = this;
            // 
            // errorProviderFirstname
            // 
            errorProviderFirstname.ContainerControl = this;
            // 
            // errorProviderSalary
            // 
            errorProviderSalary.ContainerControl = this;
            // 
            // errorProviderHiredate
            // 
            errorProviderHiredate.ContainerControl = this;
            // 
            // errorProviderManagerId
            // 
            errorProviderManagerId.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(216, 126);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 40;
            label1.Text = "DD/MM/YYYY";
            // 
            // FormUpdateCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 199);
            Controls.Add(label1);
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
            Name = "FormUpdateCreate";
            Text = "FormUpdateCreate";
            ((System.ComponentModel.ISupportInitialize)errorProviderLastname).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderFirstname).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderHiredate).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderManagerId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxId;
        private Label labelId;
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
        private ErrorProvider errorProviderLastname;
        private ErrorProvider errorProviderFirstname;
        private ErrorProvider errorProviderSalary;
        private ErrorProvider errorProviderHiredate;
        private ErrorProvider errorProviderManagerId;
        private Label label1;
    }
}