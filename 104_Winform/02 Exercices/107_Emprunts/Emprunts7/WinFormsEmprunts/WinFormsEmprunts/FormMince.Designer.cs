namespace WinFormsEmprunts
{
    partial class FormMince
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMince));
            this.pictureBoxMince = new System.Windows.Forms.PictureBox();
            this.imageListMince = new System.Windows.Forms.ImageList(this.components);
            this.timerMince = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMince)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMince
            // 
            this.pictureBoxMince.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxMince.Name = "pictureBoxMince";
            this.pictureBoxMince.Size = new System.Drawing.Size(226, 254);
            this.pictureBoxMince.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMince.TabIndex = 0;
            this.pictureBoxMince.TabStop = false;
            // 
            // imageListMince
            // 
            this.imageListMince.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListMince.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMince.ImageStream")));
            this.imageListMince.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMince.Images.SetKeyName(0, "Emoji je pleure 2.jpg");
            // 
            // timerMince
            // 
            this.timerMince.Tick += new System.EventHandler(this.timerMince_Tick);
            // 
            // FormMince
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 276);
            this.Controls.Add(this.pictureBoxMince);
            this.Name = "FormMince";
            this.Text = "FormMince";
            this.Load += new System.EventHandler(this.FormMince_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMince)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBoxMince;
        private ImageList imageListMince;
        private System.Windows.Forms.Timer timerMince;
    }
}