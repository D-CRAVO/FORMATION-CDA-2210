namespace WinFormsEmprunts
{
    partial class FormAlors
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
            this.buttonNon = new System.Windows.Forms.Button();
            this.buttonOui = new System.Windows.Forms.Button();
            this.labelEmoji = new System.Windows.Forms.Label();
            this.pictureBoxEmoji = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmoji)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNon
            // 
            this.buttonNon.Location = new System.Drawing.Point(221, 385);
            this.buttonNon.Name = "buttonNon";
            this.buttonNon.Size = new System.Drawing.Size(75, 23);
            this.buttonNon.TabIndex = 7;
            this.buttonNon.Text = "Pas encore";
            this.buttonNon.UseVisualStyleBackColor = true;
            this.buttonNon.Click += new System.EventHandler(this.buttonNon_Click);
            // 
            // buttonOui
            // 
            this.buttonOui.Location = new System.Drawing.Point(12, 385);
            this.buttonOui.Name = "buttonOui";
            this.buttonOui.Size = new System.Drawing.Size(75, 23);
            this.buttonOui.TabIndex = 6;
            this.buttonOui.Text = "Oui";
            this.buttonOui.UseVisualStyleBackColor = true;
            this.buttonOui.Click += new System.EventHandler(this.buttonOui_Click);
            // 
            // labelEmoji
            // 
            this.labelEmoji.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmoji.Location = new System.Drawing.Point(12, 297);
            this.labelEmoji.Name = "labelEmoji";
            this.labelEmoji.Size = new System.Drawing.Size(284, 49);
            this.labelEmoji.TabIndex = 5;
            this.labelEmoji.Text = "Dites ! Dites ! Mon exercice est presque juste ?";
            this.labelEmoji.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxEmoji
            // 
            this.pictureBoxEmoji.Image = global::WinFormsEmprunts.Properties.Resources.Emoji_Tout_va_bien;
            this.pictureBoxEmoji.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxEmoji.Name = "pictureBoxEmoji";
            this.pictureBoxEmoji.Size = new System.Drawing.Size(284, 271);
            this.pictureBoxEmoji.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEmoji.TabIndex = 4;
            this.pictureBoxEmoji.TabStop = false;
            // 
            // FormAlors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 450);
            this.Controls.Add(this.buttonNon);
            this.Controls.Add(this.buttonOui);
            this.Controls.Add(this.labelEmoji);
            this.Controls.Add(this.pictureBoxEmoji);
            this.Name = "FormAlors";
            this.Text = "FormAlors";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmoji)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonNon;
        private Button buttonOui;
        private Label labelEmoji;
        private PictureBox pictureBoxEmoji;
    }
}