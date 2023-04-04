namespace WFCoursUsersControles
{
    partial class FormProgressBar
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
            ucProgressBar1 = new CLUsersControls.UCProgressBar();
            SuspendLayout();
            // 
            // ucProgressBar1
            // 
            ucProgressBar1.Location = new Point(12, 12);
            ucProgressBar1.Name = "ucProgressBar1";
            ucProgressBar1.Size = new Size(596, 40);
            ucProgressBar1.TabIndex = 0;
            ucProgressBar1.TextButton = "Stop";
            ucProgressBar1.Value = 0;
            ucProgressBar1.MaximumProgressReached += ucProgressBar1_MaximumProgressReached;
            // 
            // FormProgressBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 314);
            Controls.Add(ucProgressBar1);
            Name = "FormProgressBar";
            Text = "FormProgressBar";
            ResumeLayout(false);
        }

        #endregion

        private CLUsersControls.UCProgressBar ucProgressBar1;
    }
}