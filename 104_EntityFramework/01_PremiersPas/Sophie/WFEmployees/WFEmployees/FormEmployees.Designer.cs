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
            dataGridViewEmployees = new DataGridView();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonModify = new Button();
            textBoxId = new TextBox();
            labelFisrtName = new Label();
            textBoxFirstName = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            labelId = new Label();
            labelIdManager = new Label();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).BeginInit();
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
            // labelFisrtName
            // 
            labelFisrtName.AutoSize = true;
            labelFisrtName.Location = new Point(615, 49);
            labelFisrtName.Name = "labelFisrtName";
            labelFisrtName.Size = new Size(61, 15);
            labelFisrtName.TabIndex = 5;
            labelFisrtName.Text = "FisrtName";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(682, 46);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(100, 23);
            textBoxFirstName.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(682, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(615, 78);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 7;
            label1.Text = "FisrtName";
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
            // labelIdManager
            // 
            labelIdManager.AutoSize = true;
            labelIdManager.Location = new Point(615, 107);
            labelIdManager.Name = "labelIdManager";
            labelIdManager.Size = new Size(64, 15);
            labelIdManager.TabIndex = 11;
            labelIdManager.Text = "IdManager";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(682, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(40, 23);
            textBox2.TabIndex = 10;
            // 
            // FormEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelIdManager);
            Controls.Add(textBox2);
            Controls.Add(labelId);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(textBoxFirstName);
            Controls.Add(labelFisrtName);
            Controls.Add(textBoxId);
            Controls.Add(buttonModify);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewEmployees);
            Name = "FormEmployees";
            Text = "FormEmployees";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewEmployees;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonModify;
        private TextBox textBoxId;
        private Label labelFisrtName;
        private TextBox textBoxFirstName;
        private TextBox textBox1;
        private Label label1;
        private Label labelId;
        private Label labelIdManager;
        private TextBox textBox2;
    }
}