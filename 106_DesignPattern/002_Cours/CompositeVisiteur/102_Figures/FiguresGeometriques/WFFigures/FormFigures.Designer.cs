namespace WFFigures
{
    partial class FormFigures
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
            panelFigures = new Panel();
            SuspendLayout();
            // 
            // panelFigures
            // 
            panelFigures.Location = new Point(6, 8);
            panelFigures.Name = "panelFigures";
            panelFigures.Size = new Size(786, 433);
            panelFigures.TabIndex = 0;
            panelFigures.Paint += panelFigures_Paint;
            // 
            // Figures
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelFigures);
            Name = "Figures";
            Text = "Figures";
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFigures;
    }
}