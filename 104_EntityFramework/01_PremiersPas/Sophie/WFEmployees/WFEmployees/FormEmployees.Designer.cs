namespace WFEmployees
{
    partial class FormEmployees
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
            dataGridViewEmployees = new DataGridView();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonModify = new Button();
            textBoxId = new TextBox();
            labelFirstName = new Label();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            labelLastName = new Label();
            labelId = new Label();
            labelManagerId = new Label();
            textBoxManagerId = new TextBox();
            errorProviderAddEmployee = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderAddEmployee).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEmployees
            // 
            dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployees.Location = new Point(12, 12);
            dataGridViewEmployees.Name = "dataGridViewEmployees";
            dataGridViewEmployees.RowTemplate.Height = 25;
            dataGridViewEmployees.Size = new Size(449, 426);
            dataGridViewEmployees.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(467, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(108, 23);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "AddEmployee";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(467, 41);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(108, 23);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "DeleteEmployee";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonModify
            // 
            buttonModify.Location = new Point(467, 70);
            buttonModify.Name = "buttonModify";
            buttonModify.Size = new Size(108, 23);
            buttonModify.TabIndex = 3;
            buttonModify.Text = "ModifyEmployee";
            buttonModify.UseVisualStyleBackColor = true;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(682, 16);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(40, 23);
            textBoxId.TabIndex = 4;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(615, 49);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(61, 15);
            labelFirstName.TabIndex = 5;
            labelFirstName.Text = "FirstName";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(682, 46);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(100, 23);
            textBoxFirstName.TabIndex = 6;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(682, 75);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(100, 23);
            textBoxLastName.TabIndex = 8;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(615, 78);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(60, 15);
            labelLastName.TabIndex = 7;
            labelLastName.Text = "LastName";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(615, 19);
            labelId.Name = "labelId";
            labelId.Size = new Size(17, 15);
            labelId.TabIndex = 9;
            labelId.Text = "Id";
            // 
            // labelManagerId
            // 
            labelManagerId.AutoSize = true;
            labelManagerId.Location = new Point(615, 107);
            labelManagerId.Name = "labelManagerId";
            labelManagerId.Size = new Size(64, 15);
            labelManagerId.TabIndex = 11;
            labelManagerId.Text = "ManagerId";
            // 
            // textBoxManagerId
            // 
            textBoxManagerId.Location = new Point(682, 104);
            textBoxManagerId.Name = "textBoxManagerId";
            textBoxManagerId.Size = new Size(40, 23);
            textBoxManagerId.TabIndex = 10;
            // 
            // errorProviderAddEmployee
            // 
            errorProviderAddEmployee.ContainerControl = this;
            // 
            // FormEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelManagerId);
            Controls.Add(textBoxManagerId);
            Controls.Add(labelId);
            Controls.Add(textBoxLastName);
            Controls.Add(labelLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(labelFirstName);
            Controls.Add(textBoxId);
            Controls.Add(buttonModify);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewEmployees);
            Name = "FormEmployees";
            Text = "FormEmployees";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderAddEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewEmployees;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonModify;
        private TextBox textBoxId;
        private Label labelFirstName;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private Label labelLastName;
        private Label labelId;
        private Label labelManagerId;
        private TextBox textBoxManagerId;
        private ErrorProvider errorProviderAddEmployee;
    }
}