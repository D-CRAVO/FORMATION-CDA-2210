namespace WFEmployees2
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
            buttonCreate = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            dataGridViewEmployees = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).BeginInit();
            SuspendLayout();
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(561, 41);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(124, 23);
            buttonCreate.TabIndex = 7;
            buttonCreate.Text = "CreateEmployee";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(561, 70);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(124, 23);
            buttonUpdate.TabIndex = 6;
            buttonUpdate.Text = "UpdateEmployee";
            buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(561, 12);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(124, 23);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "DeleteEmployee";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // dataGridViewEmployees
            // 
            dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployees.Location = new Point(12, 12);
            dataGridViewEmployees.Name = "dataGridViewEmployees";
            dataGridViewEmployees.RowTemplate.Height = 25;
            dataGridViewEmployees.Size = new Size(543, 426);
            dataGridViewEmployees.TabIndex = 4;
            // 
            // FormEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 450);
            Controls.Add(buttonCreate);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonDelete);
            Controls.Add(dataGridViewEmployees);
            Name = "FormEmployees";
            Text = "FormEmployees";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCreate;
        private Button buttonUpdate;
        private Button buttonDelete;
        private DataGridView dataGridViewEmployees;
    }
}