namespace ECF_SPA
{
    partial class FormAjouterModifier
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
            labelPuce = new Label();
            textBoxPuce = new TextBox();
            labelNom = new Label();
            textBox2 = new TextBox();
            labelAge = new Label();
            textBox1 = new TextBox();
            labelRace = new Label();
            comboBox1 = new ComboBox();
            buttonModifier = new Button();
            SuspendLayout();
            // 
            // labelPuce
            // 
            labelPuce.AutoSize = true;
            labelPuce.Location = new Point(25, 37);
            labelPuce.Name = "labelPuce";
            labelPuce.Size = new Size(33, 15);
            labelPuce.TabIndex = 0;
            labelPuce.Text = "Puce";
            // 
            // textBoxPuce
            // 
            textBoxPuce.Enabled = false;
            textBoxPuce.Location = new Point(81, 34);
            textBoxPuce.Name = "textBoxPuce";
            textBoxPuce.Size = new Size(121, 23);
            textBoxPuce.TabIndex = 1;
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(25, 80);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(34, 15);
            labelNom.TabIndex = 2;
            labelNom.Text = "Nom";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(81, 72);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 3;
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Location = new Point(25, 121);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(28, 15);
            labelAge.TabIndex = 4;
            labelAge.Text = "Age";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(81, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 5;
            // 
            // labelRace
            // 
            labelRace.AutoSize = true;
            labelRace.Location = new Point(25, 168);
            labelRace.Name = "labelRace";
            labelRace.Size = new Size(32, 15);
            labelRace.TabIndex = 6;
            labelRace.Text = "Race";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(81, 165);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            // 
            // buttonModifier
            // 
            buttonModifier.Location = new Point(127, 219);
            buttonModifier.Name = "buttonModifier";
            buttonModifier.Size = new Size(75, 23);
            buttonModifier.TabIndex = 8;
            buttonModifier.Text = "Modifier";
            buttonModifier.UseVisualStyleBackColor = true;
            // 
            // FormAjouterModifier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(231, 274);
            Controls.Add(buttonModifier);
            Controls.Add(comboBox1);
            Controls.Add(labelRace);
            Controls.Add(textBox1);
            Controls.Add(labelAge);
            Controls.Add(textBox2);
            Controls.Add(labelNom);
            Controls.Add(textBoxPuce);
            Controls.Add(labelPuce);
            Name = "FormAjouterModifier";
            Text = "FormAjouterModifier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPuce;
        private TextBox textBoxPuce;
        private Label labelNom;
        private TextBox textBox2;
        private Label labelAge;
        private TextBox textBox1;
        private Label labelRace;
        private ComboBox comboBox1;
        private Button buttonModifier;
    }
}