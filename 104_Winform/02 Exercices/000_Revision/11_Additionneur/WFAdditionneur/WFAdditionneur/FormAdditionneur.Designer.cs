namespace WFAdditionneur
{
    partial class FormAdditionneur
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
            textBoxAffichage = new TextBox();
            button0 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonVider = new Button();
            buttonCalculer = new Button();
            SuspendLayout();
            // 
            // textBoxAffichage
            // 
            textBoxAffichage.Location = new Point(12, 12);
            textBoxAffichage.Multiline = true;
            textBoxAffichage.Name = "textBoxAffichage";
            textBoxAffichage.ScrollBars = ScrollBars.Vertical;
            textBoxAffichage.Size = new Size(276, 79);
            textBoxAffichage.TabIndex = 0;
            // 
            // button0
            // 
            button0.Location = new Point(12, 108);
            button0.Name = "button0";
            button0.Size = new Size(50, 50);
            button0.TabIndex = 1;
            button0.Tag = "0";
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button_Click;
            // 
            // button1
            // 
            button1.Location = new Point(68, 108);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 2;
            button1.Tag = "1";
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            // 
            // button2
            // 
            button2.Location = new Point(124, 108);
            button2.Name = "button2";
            button2.Size = new Size(50, 50);
            button2.TabIndex = 3;
            button2.Tag = "2";
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click;
            // 
            // button3
            // 
            button3.Location = new Point(180, 108);
            button3.Name = "button3";
            button3.Size = new Size(50, 50);
            button3.TabIndex = 4;
            button3.Tag = "3";
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click;
            // 
            // button4
            // 
            button4.Location = new Point(238, 108);
            button4.Name = "button4";
            button4.Size = new Size(50, 50);
            button4.TabIndex = 5;
            button4.Tag = "4";
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_Click;
            // 
            // button5
            // 
            button5.Location = new Point(12, 164);
            button5.Name = "button5";
            button5.Size = new Size(50, 50);
            button5.TabIndex = 6;
            button5.Tag = "5";
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_Click;
            // 
            // button6
            // 
            button6.Location = new Point(68, 164);
            button6.Name = "button6";
            button6.Size = new Size(50, 50);
            button6.TabIndex = 7;
            button6.Tag = "6";
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_Click;
            // 
            // button7
            // 
            button7.Location = new Point(124, 164);
            button7.Name = "button7";
            button7.Size = new Size(50, 50);
            button7.TabIndex = 8;
            button7.Tag = "7";
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_Click;
            // 
            // button8
            // 
            button8.Location = new Point(180, 164);
            button8.Name = "button8";
            button8.Size = new Size(50, 50);
            button8.TabIndex = 9;
            button8.Tag = "8";
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_Click;
            // 
            // button9
            // 
            button9.Location = new Point(238, 164);
            button9.Name = "button9";
            button9.Size = new Size(50, 50);
            button9.TabIndex = 10;
            button9.Tag = "9";
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_Click;
            // 
            // buttonVider
            // 
            buttonVider.Location = new Point(12, 230);
            buttonVider.Name = "buttonVider";
            buttonVider.Size = new Size(106, 23);
            buttonVider.TabIndex = 11;
            buttonVider.Text = "Vider";
            buttonVider.UseVisualStyleBackColor = true;
            buttonVider.Click += buttonVider_Click;
            // 
            // buttonCalculer
            // 
            buttonCalculer.Location = new Point(180, 230);
            buttonCalculer.Name = "buttonCalculer";
            buttonCalculer.Size = new Size(108, 23);
            buttonCalculer.TabIndex = 12;
            buttonCalculer.Text = "Calculer";
            buttonCalculer.UseVisualStyleBackColor = true;
            buttonCalculer.Click += buttonCalculer_Click;
            // 
            // FormAdditionneur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 261);
            Controls.Add(buttonCalculer);
            Controls.Add(buttonVider);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button0);
            Controls.Add(textBoxAffichage);
            Name = "FormAdditionneur";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Additionneur";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAffichage;
        private Button button0;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonVider;
        private Button buttonCalculer;
    }
}