namespace WFCities
{
    partial class FormCities
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
            labelCityId = new Label();
            textBoxCityId = new TextBox();
            labelCityName = new Label();
            textBoxCityName = new TextBox();
            labelCountryCode = new Label();
            comboBoxCountryCode = new ComboBox();
            buttonValider = new Button();
            SuspendLayout();
            // 
            // labelCityId
            // 
            labelCityId.AutoSize = true;
            labelCityId.Location = new Point(12, 9);
            labelCityId.Name = "labelCityId";
            labelCityId.Size = new Size(38, 15);
            labelCityId.TabIndex = 0;
            labelCityId.Text = "CityId";
            // 
            // textBoxCityId
            // 
            textBoxCityId.Enabled = false;
            textBoxCityId.Location = new Point(137, 6);
            textBoxCityId.Name = "textBoxCityId";
            textBoxCityId.Size = new Size(100, 23);
            textBoxCityId.TabIndex = 1;
            // 
            // labelCityName
            // 
            labelCityName.AutoSize = true;
            labelCityName.Location = new Point(12, 38);
            labelCityName.Name = "labelCityName";
            labelCityName.Size = new Size(60, 15);
            labelCityName.TabIndex = 2;
            labelCityName.Text = "CityName";
            // 
            // textBoxCityName
            // 
            textBoxCityName.Location = new Point(137, 35);
            textBoxCityName.Name = "textBoxCityName";
            textBoxCityName.Size = new Size(100, 23);
            textBoxCityName.TabIndex = 3;
            // 
            // labelCountryCode
            // 
            labelCountryCode.AutoSize = true;
            labelCountryCode.Location = new Point(12, 74);
            labelCountryCode.Name = "labelCountryCode";
            labelCountryCode.Size = new Size(78, 15);
            labelCountryCode.TabIndex = 4;
            labelCountryCode.Text = "CountryCode";
            // 
            // comboBoxCountryCode
            // 
            comboBoxCountryCode.FormattingEnabled = true;
            comboBoxCountryCode.Location = new Point(137, 64);
            comboBoxCountryCode.Name = "comboBoxCountryCode";
            comboBoxCountryCode.Size = new Size(100, 23);
            comboBoxCountryCode.TabIndex = 5;
            // 
            // buttonValider
            // 
            buttonValider.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonValider.Location = new Point(169, 117);
            buttonValider.Name = "buttonValider";
            buttonValider.Size = new Size(75, 23);
            buttonValider.TabIndex = 6;
            buttonValider.Text = "Valider";
            buttonValider.UseVisualStyleBackColor = true;
            // 
            // FormCities
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 152);
            Controls.Add(buttonValider);
            Controls.Add(comboBoxCountryCode);
            Controls.Add(labelCountryCode);
            Controls.Add(textBoxCityName);
            Controls.Add(labelCityName);
            Controls.Add(textBoxCityId);
            Controls.Add(labelCityId);
            Name = "FormCities";
            Text = "FormCities";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCityId;
        private TextBox textBoxCityId;
        private Label labelCityName;
        private TextBox textBoxCityName;
        private Label labelCountryCode;
        private ComboBox comboBoxCountryCode;
        private Button buttonValider;
    }
}