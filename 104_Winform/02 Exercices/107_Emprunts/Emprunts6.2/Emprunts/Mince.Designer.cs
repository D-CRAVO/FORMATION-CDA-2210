namespace Emprunts
{
    partial class Mince
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mince));
            imageListMince = new ImageList(components);
            pictureBoxMince = new PictureBox();
            timerMince = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxMince).BeginInit();
            SuspendLayout();
            // 
            // imageListMince
            // 
            imageListMince.ColorDepth = ColorDepth.Depth8Bit;
            imageListMince.ImageStream = (ImageListStreamer)resources.GetObject("imageListMince.ImageStream");
            imageListMince.TransparentColor = Color.Transparent;
            imageListMince.Images.SetKeyName(0, "Emoji Je désespère.jpg");
            imageListMince.Images.SetKeyName(1, "Emoji désespoir-gueule-bois-dépressive-ou-fatiguée.jpg");
            imageListMince.Images.SetKeyName(2, "Emoji Je désespère 2.jpg");
            imageListMince.Images.SetKeyName(3, "Emoji Je pleure.jpg");
            // 
            // pictureBoxMince
            // 
            pictureBoxMince.Location = new Point(12, 12);
            pictureBoxMince.Name = "pictureBoxMince";
            pictureBoxMince.Size = new Size(246, 221);
            pictureBoxMince.TabIndex = 0;
            pictureBoxMince.TabStop = false;
            // 
            // timerMince
            // 
            timerMince.Tick += timerMince_Tick;
            // 
            // Mince
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 245);
            Controls.Add(pictureBoxMince);
            Name = "Mince";
            Text = "Mince";
            Load += Mince_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxMince).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ImageList imageListMince;
        private PictureBox pictureBoxMince;
        private System.Windows.Forms.Timer timerMince;
    }
}