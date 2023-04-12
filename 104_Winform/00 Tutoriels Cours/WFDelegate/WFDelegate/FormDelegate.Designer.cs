namespace WFDelegate
{
    partial class FormDelegate
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
            buttonChatouiller = new Button();
            buttonChatouiller2 = new Button();
            SuspendLayout();
            // 
            // buttonChatouiller
            // 
            buttonChatouiller.Location = new Point(118, 108);
            buttonChatouiller.Name = "buttonChatouiller";
            buttonChatouiller.Size = new Size(187, 23);
            buttonChatouiller.TabIndex = 0;
            buttonChatouiller.Text = "Chatouiller Modal";
            buttonChatouiller.UseVisualStyleBackColor = true;
            buttonChatouiller.Click += buttonChatouiller_Click;
            // 
            // buttonChatouiller2
            // 
            buttonChatouiller2.Location = new Point(118, 150);
            buttonChatouiller2.Name = "buttonChatouiller2";
            buttonChatouiller2.Size = new Size(187, 23);
            buttonChatouiller2.TabIndex = 1;
            buttonChatouiller2.Text = "Chatouiller 2 Non Modal";
            buttonChatouiller2.UseVisualStyleBackColor = true;
            buttonChatouiller2.Click += buttonChatouiller2_Click;
            // 
            // FormDelegate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 343);
            Controls.Add(buttonChatouiller2);
            Controls.Add(buttonChatouiller);
            Name = "FormDelegate";
            Text = "FormDelegate";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonChatouiller;
        private Button buttonChatouiller2;
    }
}