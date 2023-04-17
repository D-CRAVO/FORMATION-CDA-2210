namespace WFCities
{
    partial class FormCity
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
            dataGridViewCities = new DataGridView();
            buttonAddCity = new Button();
            buttonDeleteCity1 = new Button();
            buttonDeleteCity2 = new Button();
            textBoxId = new TextBox();
            buttonModifyCity = new Button();
            labelNom = new Label();
            textBoxNom = new TextBox();
            buttonClear = new Button();
            dataGridView1 = new DataGridView();
            textBoxConsole = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCities).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCities
            // 
            dataGridViewCities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCities.Location = new Point(12, 12);
            dataGridViewCities.Name = "dataGridViewCities";
            dataGridViewCities.RowTemplate.Height = 25;
            dataGridViewCities.Size = new Size(441, 593);
            dataGridViewCities.TabIndex = 0;
            // 
            // buttonAddCity
            // 
            buttonAddCity.Location = new Point(459, 12);
            buttonAddCity.Name = "buttonAddCity";
            buttonAddCity.Size = new Size(75, 23);
            buttonAddCity.TabIndex = 1;
            buttonAddCity.Text = "AddCity";
            buttonAddCity.UseVisualStyleBackColor = true;
            buttonAddCity.Click += buttonAddCity_Click;
            // 
            // buttonDeleteCity1
            // 
            buttonDeleteCity1.Location = new Point(459, 41);
            buttonDeleteCity1.Name = "buttonDeleteCity1";
            buttonDeleteCity1.Size = new Size(156, 23);
            buttonDeleteCity1.TabIndex = 2;
            buttonDeleteCity1.Text = "DeleteCity method 1";
            buttonDeleteCity1.UseVisualStyleBackColor = true;
            buttonDeleteCity1.Click += buttonDeleteCity1_Click;
            // 
            // buttonDeleteCity2
            // 
            buttonDeleteCity2.Location = new Point(459, 70);
            buttonDeleteCity2.Name = "buttonDeleteCity2";
            buttonDeleteCity2.Size = new Size(156, 23);
            buttonDeleteCity2.TabIndex = 3;
            buttonDeleteCity2.Text = "DeleteCity method 2";
            buttonDeleteCity2.UseVisualStyleBackColor = true;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(621, 41);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(28, 23);
            textBoxId.TabIndex = 4;
            // 
            // buttonModifyCity
            // 
            buttonModifyCity.Location = new Point(459, 99);
            buttonModifyCity.Name = "buttonModifyCity";
            buttonModifyCity.Size = new Size(75, 23);
            buttonModifyCity.TabIndex = 5;
            buttonModifyCity.Text = "ModifyCity";
            buttonModifyCity.UseVisualStyleBackColor = true;
            buttonModifyCity.Click += buttonModifyCity_Click;
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(540, 103);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(34, 15);
            labelNom.TabIndex = 6;
            labelNom.Text = "Nom";
            // 
            // textBoxNom
            // 
            textBoxNom.Location = new Point(580, 99);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(100, 23);
            textBoxNom.TabIndex = 7;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(773, 220);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 8;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(459, 128);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(389, 86);
            dataGridView1.TabIndex = 9;
            // 
            // textBoxConsole
            // 
            textBoxConsole.Location = new Point(459, 250);
            textBoxConsole.Multiline = true;
            textBoxConsole.Name = "textBoxConsole";
            textBoxConsole.ScrollBars = ScrollBars.Vertical;
            textBoxConsole.Size = new Size(389, 355);
            textBoxConsole.TabIndex = 10;
            // 
            // FormCity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 617);
            Controls.Add(textBoxConsole);
            Controls.Add(dataGridView1);
            Controls.Add(buttonClear);
            Controls.Add(textBoxNom);
            Controls.Add(labelNom);
            Controls.Add(buttonModifyCity);
            Controls.Add(textBoxId);
            Controls.Add(buttonDeleteCity2);
            Controls.Add(buttonDeleteCity1);
            Controls.Add(buttonAddCity);
            Controls.Add(dataGridViewCities);
            Name = "FormCity";
            Text = "FormCity";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCities).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCities;
        private Button buttonAddCity;
        private Button buttonDeleteCity1;
        private Button buttonDeleteCity2;
        private TextBox textBoxId;
        private Button buttonModifyCity;
        private Label labelNom;
        private TextBox textBoxNom;
        private Button buttonClear;
        private DataGridView dataGridView1;
        private TextBox textBoxConsole;
    }
}