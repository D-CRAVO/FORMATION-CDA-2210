namespace Emprunts
{
    partial class Alors
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
            pictureBoxEmoji = new PictureBox();
            labelEmoji = new Label();
            buttonOui = new Button();
            buttonNon = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmoji).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxEmoji
            // 
            pictureBoxEmoji.Image = Properties.Resources.Emoji_Tout_va_bien;
            pictureBoxEmoji.Location = new Point(12, 12);
            pictureBoxEmoji.Name = "pictureBoxEmoji";
            pictureBoxEmoji.Size = new Size(284, 271);
            pictureBoxEmoji.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxEmoji.TabIndex = 0;
            pictureBoxEmoji.TabStop = false;
            // 
            // labelEmoji
            // 
            labelEmoji.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmoji.Location = new Point(12, 297);
            labelEmoji.Name = "labelEmoji";
            labelEmoji.Size = new Size(284, 49);
            labelEmoji.TabIndex = 1;
            labelEmoji.Text = "Dites ! Dites ! Mon exercice est presque juste ?";
            labelEmoji.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonOui
            // 
            buttonOui.Location = new Point(12, 385);
            buttonOui.Name = "buttonOui";
            buttonOui.Size = new Size(75, 23);
            buttonOui.TabIndex = 2;
            buttonOui.Text = "Oui";
            buttonOui.UseVisualStyleBackColor = true;
            buttonOui.Click += buttonOui_Click;
            // 
            // buttonNon
            // 
            buttonNon.Location = new Point(221, 385);
            buttonNon.Name = "buttonNon";
            buttonNon.Size = new Size(75, 23);
            buttonNon.TabIndex = 3;
            buttonNon.Text = "Pas encore";
            buttonNon.UseVisualStyleBackColor = true;
            buttonNon.Click += buttonNon_Click;
            // 
            // Alors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 426);
            Controls.Add(buttonNon);
            Controls.Add(buttonOui);
            Controls.Add(labelEmoji);
            Controls.Add(pictureBoxEmoji);
            Name = "Alors";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alors";
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmoji).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxEmoji;
        private Label labelEmoji;
        private Button buttonOui;
        private Button buttonNon;
    }
}