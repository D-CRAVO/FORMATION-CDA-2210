namespace ValidationSaisie2
{
    partial class FormulaireSaisie2
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
            labelNom = new Label();
            textBoxNom = new TextBox();
            buttonValider = new Button();
            buttonEffacer = new Button();
            errorProviderNom = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderNom).BeginInit();
            SuspendLayout();
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(125, 149);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(34, 15);
            labelNom.TabIndex = 0;
            labelNom.Text = "Nom";
            // 
            // textBoxNom
            // 
            textBoxNom.Location = new Point(190, 141);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(100, 23);
            textBoxNom.TabIndex = 1;
            textBoxNom.TextChanged += textBoxNom_TextChanged;
            this.buttonEffacer.Click += new System.EventHandler(this.buttonEffacer_Click);
            // 
            // buttonValider
            // 
            buttonValider.Location = new Point(659, 333);
            buttonValider.Name = "buttonValider";
            buttonValider.Size = new Size(75, 23);
            buttonValider.TabIndex = 2;
            buttonValider.Text = "Valider";
            buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonEffacer
            // 
            buttonEffacer.Location = new Point(659, 362);
            buttonEffacer.Name = "buttonEffacer";
            buttonEffacer.Size = new Size(75, 23);
            buttonEffacer.TabIndex = 3;
            buttonEffacer.Text = "Effacer";
            buttonEffacer.UseVisualStyleBackColor = true;
            // 
            // errorProviderNom
            // 
            errorProviderNom.ContainerControl = this;
            // 
            // FormulaireSaisie2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonEffacer);
            Controls.Add(buttonValider);
            Controls.Add(textBoxNom);
            Controls.Add(labelNom);
            Name = "FormulaireSaisie2";
            Text = "FormulaireSaisie2";
            ((System.ComponentModel.ISupportInitialize)errorProviderNom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNom;
        private TextBox textBoxNom;
        private Button buttonValider;
        private Button buttonEffacer;
        private ErrorProvider errorProviderNom;
    }
}