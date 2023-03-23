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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormulaireSaisie2));
            this.labelNom = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonEffacer = new System.Windows.Forms.Button();
            this.errorProviderNom = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.labelMontant = new System.Windows.Forms.Label();
            this.textBoxMontant = new System.Windows.Forms.TextBox();
            this.labelCP = new System.Windows.Forms.Label();
            this.textBoxCP = new System.Windows.Forms.TextBox();
            this.errorProviderDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMontant = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCP = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelCommentaire = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMontant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCP)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            resources.ApplyResources(this.labelNom, "labelNom");
            this.labelNom.Name = "labelNom";
            // 
            // textBoxNom
            // 
            resources.ApplyResources(this.textBoxNom, "textBoxNom");
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.TextChanged += new System.EventHandler(this.textBoxNom_TextChanged);
            // 
            // buttonValider
            // 
            resources.ApplyResources(this.buttonValider, "buttonValider");
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonEffacer
            // 
            resources.ApplyResources(this.buttonEffacer, "buttonEffacer");
            this.buttonEffacer.Name = "buttonEffacer";
            this.buttonEffacer.UseVisualStyleBackColor = true;
            this.buttonEffacer.Click += new System.EventHandler(this.buttonEffacer_Click);
            // 
            // errorProviderNom
            // 
            this.errorProviderNom.ContainerControl = this;
            // 
            // labelDate
            // 
            resources.ApplyResources(this.labelDate, "labelDate");
            this.labelDate.Name = "labelDate";
            // 
            // textBoxDate
            // 
            resources.ApplyResources(this.textBoxDate, "textBoxDate");
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.TextChanged += new System.EventHandler(this.textBoxDate_TextChanged);
            // 
            // labelMontant
            // 
            resources.ApplyResources(this.labelMontant, "labelMontant");
            this.labelMontant.Name = "labelMontant";
            // 
            // textBoxMontant
            // 
            resources.ApplyResources(this.textBoxMontant, "textBoxMontant");
            this.textBoxMontant.Name = "textBoxMontant";
            this.textBoxMontant.TextChanged += new System.EventHandler(this.textBoxMontant_TextChanged);
            // 
            // labelCP
            // 
            resources.ApplyResources(this.labelCP, "labelCP");
            this.labelCP.Name = "labelCP";
            // 
            // textBoxCP
            // 
            resources.ApplyResources(this.textBoxCP, "textBoxCP");
            this.textBoxCP.Name = "textBoxCP";
            this.textBoxCP.TextChanged += new System.EventHandler(this.textBoxCP_TextChanged);
            // 
            // errorProviderDate
            // 
            this.errorProviderDate.ContainerControl = this;
            // 
            // errorProviderMontant
            // 
            this.errorProviderMontant.ContainerControl = this;
            // 
            // errorProviderCP
            // 
            this.errorProviderCP.ContainerControl = this;
            // 
            // labelCommentaire
            // 
            resources.ApplyResources(this.labelCommentaire, "labelCommentaire");
            this.labelCommentaire.Name = "labelCommentaire";
            // 
            // FormulaireSaisie2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelCommentaire);
            this.Controls.Add(this.textBoxCP);
            this.Controls.Add(this.labelCP);
            this.Controls.Add(this.textBoxMontant);
            this.Controls.Add(this.labelMontant);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.buttonEffacer);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelNom);
            this.Name = "FormulaireSaisie2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormulaireSaisie2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMontant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNom;
        private TextBox textBoxNom;
        private Button buttonValider;
        private Button buttonEffacer;
        private ErrorProvider errorProviderNom;
        private Label labelDate;
        private TextBox textBoxCP;
        private Label labelCP;
        private TextBox textBoxMontant;
        private Label labelMontant;
        private TextBox textBoxDate;
        private ErrorProvider errorProviderDate;
        private ErrorProvider errorProviderMontant;
        private ErrorProvider errorProviderCP;
        private Label labelCommentaire;
    }
}