namespace WFCarsOwners
{
    partial class FormCar
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
            dataGridViewCar = new DataGridView();
            buttonAdd = new Button();
            buttonDeleteCar = new Button();
            textBoxCarId = new TextBox();
            labelCarId = new Label();
            buttonModifyCar = new Button();
            textBoxNewName = new TextBox();
            labelNewName = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCar).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCar
            // 
            dataGridViewCar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCar.Location = new Point(12, 12);
            dataGridViewCar.Name = "dataGridViewCar";
            dataGridViewCar.RowTemplate.Height = 25;
            dataGridViewCar.Size = new Size(474, 426);
            dataGridViewCar.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(492, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "AddCar";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDeleteCar
            // 
            buttonDeleteCar.Location = new Point(492, 70);
            buttonDeleteCar.Name = "buttonDeleteCar";
            buttonDeleteCar.Size = new Size(75, 23);
            buttonDeleteCar.TabIndex = 2;
            buttonDeleteCar.Text = "DeleteCar";
            buttonDeleteCar.UseVisualStyleBackColor = true;
            buttonDeleteCar.Click += buttonDeleteCar_Click;
            // 
            // textBoxCarId
            // 
            textBoxCarId.Location = new Point(492, 41);
            textBoxCarId.Name = "textBoxCarId";
            textBoxCarId.Size = new Size(75, 23);
            textBoxCarId.TabIndex = 3;
            // 
            // labelCarId
            // 
            labelCarId.AutoSize = true;
            labelCarId.Location = new Point(573, 44);
            labelCarId.Name = "labelCarId";
            labelCarId.Size = new Size(35, 15);
            labelCarId.TabIndex = 4;
            labelCarId.Text = "CarId";
            // 
            // buttonModifyCar
            // 
            buttonModifyCar.Location = new Point(492, 99);
            buttonModifyCar.Name = "buttonModifyCar";
            buttonModifyCar.Size = new Size(75, 23);
            buttonModifyCar.TabIndex = 5;
            buttonModifyCar.Text = "ModifyCar";
            buttonModifyCar.UseVisualStyleBackColor = true;
            buttonModifyCar.Click += buttonModifyCar_Click;
            // 
            // textBoxNewName
            // 
            textBoxNewName.Location = new Point(573, 99);
            textBoxNewName.Name = "textBoxNewName";
            textBoxNewName.Size = new Size(123, 23);
            textBoxNewName.TabIndex = 6;
            // 
            // labelNewName
            // 
            labelNewName.AutoSize = true;
            labelNewName.Location = new Point(704, 103);
            labelNewName.Name = "labelNewName";
            labelNewName.Size = new Size(63, 15);
            labelNewName.TabIndex = 7;
            labelNewName.Text = "NewName";
            // 
            // FormCar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelNewName);
            Controls.Add(textBoxNewName);
            Controls.Add(buttonModifyCar);
            Controls.Add(labelCarId);
            Controls.Add(textBoxCarId);
            Controls.Add(buttonDeleteCar);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewCar);
            Name = "FormCar";
            Text = "FormCar";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCar;
        private Button buttonAdd;
        private Button buttonDeleteCar;
        private TextBox textBoxCarId;
        private Label labelCarId;
        private Button buttonModifyCar;
        private TextBox textBoxNewName;
        private Label labelNewName;
    }
}