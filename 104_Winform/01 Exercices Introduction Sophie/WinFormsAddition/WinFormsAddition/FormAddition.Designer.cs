namespace WinFormsAddition
{
    partial class FormAddition
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
            this.buttonDisBonjour = new System.Windows.Forms.Button();
            this.BoutonResizeDisBonjour = new System.Windows.Forms.Button();
            this.textBoxAddittionner = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonDisBonjour
            // 
            this.buttonDisBonjour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonDisBonjour.Location = new System.Drawing.Point(410, 97);
            this.buttonDisBonjour.Name = "buttonDisBonjour";
            this.buttonDisBonjour.Size = new System.Drawing.Size(75, 23);
            this.buttonDisBonjour.TabIndex = 1;
            this.buttonDisBonjour.Text = "DisBonjour";
            this.buttonDisBonjour.UseVisualStyleBackColor = false;
            this.buttonDisBonjour.Click += new System.EventHandler(this.buttonDisBonjour_Click);
            // 
            // BoutonResizeDisBonjour
            // 
            this.BoutonResizeDisBonjour.Location = new System.Drawing.Point(462, 180);
            this.BoutonResizeDisBonjour.Name = "BoutonResizeDisBonjour";
            this.BoutonResizeDisBonjour.Size = new System.Drawing.Size(136, 23);
            this.BoutonResizeDisBonjour.TabIndex = 0;
            this.BoutonResizeDisBonjour.Text = "Resize en carre";
            this.BoutonResizeDisBonjour.UseVisualStyleBackColor = true;
            this.BoutonResizeDisBonjour.Click += new System.EventHandler(this.BoutonResizeDisBonjour_Click);
            // 
            // textBoxAddittionner
            // 
            this.textBoxAddittionner.Location = new System.Drawing.Point(165, 77);
            this.textBoxAddittionner.Multiline = true;
            this.textBoxAddittionner.Name = "textBoxAddittionner";
            this.textBoxAddittionner.ReadOnly = true;
            this.textBoxAddittionner.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAddittionner.Size = new System.Drawing.Size(99, 84);
            this.textBoxAddittionner.TabIndex = 2;
            // 
            // FormAddition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxAddittionner);
            this.Controls.Add(this.BoutonResizeDisBonjour);
            this.Controls.Add(this.buttonDisBonjour);
            this.Name = "FormAddition";
            this.Text = "FormAddition";
            this.Load += new System.EventHandler(this.FormAddition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonDisBonjour;
        private Button BoutonResizeDisBonjour;
        private TextBox textBoxAddittionner;
    }
}