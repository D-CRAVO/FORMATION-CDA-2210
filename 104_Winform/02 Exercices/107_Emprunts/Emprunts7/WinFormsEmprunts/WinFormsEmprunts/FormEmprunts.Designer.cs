namespace WinFormsEmprunts
{
    partial class FormEmprunts
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
            this.hScrollBarDuree = new System.Windows.Forms.HScrollBar();
            this.listBoxPeriodicite = new System.Windows.Forms.ListBox();
            this.labelCapitalEmprunte = new System.Windows.Forms.Label();
            this.textBoxRemboursements = new System.Windows.Forms.TextBox();
            this.labelRemboursements = new System.Windows.Forms.Label();
            this.textBoxNbRemboursements = new System.Windows.Forms.TextBox();
            this.labelPeriodicite = new System.Windows.Forms.Label();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBoxTaux = new System.Windows.Forms.GroupBox();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.textBoxDuree = new System.Windows.Forms.TextBox();
            this.labelDureeMois = new System.Windows.Forms.Label();
            this.textBoxCapitalEmprunte = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.errorProviderCapitalEmprunte = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNom = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxTaux.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCapitalEmprunte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNom)).BeginInit();
            this.SuspendLayout();
            // 
            // hScrollBarDuree
            // 
            this.hScrollBarDuree.LargeChange = 12;
            this.hScrollBarDuree.Location = new System.Drawing.Point(293, 206);
            this.hScrollBarDuree.Maximum = 369;
            this.hScrollBarDuree.Name = "hScrollBarDuree";
            this.hScrollBarDuree.Size = new System.Drawing.Size(165, 17);
            this.hScrollBarDuree.TabIndex = 44;
            this.hScrollBarDuree.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_Scroll);
            // 
            // listBoxPeriodicite
            // 
            this.listBoxPeriodicite.FormattingEnabled = true;
            this.listBoxPeriodicite.ItemHeight = 15;
            this.listBoxPeriodicite.Items.AddRange(new object[] {
            "Mensuelle",
            "Bimestrielle",
            "Trimestrielle",
            "Semestrielle",
            "Annuelle"});
            this.listBoxPeriodicite.Location = new System.Drawing.Point(71, 280);
            this.listBoxPeriodicite.Name = "listBoxPeriodicite";
            this.listBoxPeriodicite.Size = new System.Drawing.Size(261, 79);
            this.listBoxPeriodicite.TabIndex = 43;
            this.listBoxPeriodicite.SelectedIndexChanged += new System.EventHandler(this.listBoxPeriodicite_SelectedIndexChanged);
            // 
            // labelCapitalEmprunte
            // 
            this.labelCapitalEmprunte.AutoSize = true;
            this.labelCapitalEmprunte.Location = new System.Drawing.Point(71, 148);
            this.labelCapitalEmprunte.Name = "labelCapitalEmprunte";
            this.labelCapitalEmprunte.Size = new System.Drawing.Size(99, 15);
            this.labelCapitalEmprunte.TabIndex = 42;
            this.labelCapitalEmprunte.Text = "Capital Emprunté";
            // 
            // textBoxRemboursements
            // 
            this.textBoxRemboursements.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxRemboursements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRemboursements.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxRemboursements.ForeColor = System.Drawing.Color.Red;
            this.textBoxRemboursements.Location = new System.Drawing.Point(579, 332);
            this.textBoxRemboursements.Name = "textBoxRemboursements";
            this.textBoxRemboursements.Size = new System.Drawing.Size(100, 20);
            this.textBoxRemboursements.TabIndex = 41;
            this.textBoxRemboursements.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelRemboursements
            // 
            this.labelRemboursements.AutoSize = true;
            this.labelRemboursements.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRemboursements.Location = new System.Drawing.Point(564, 280);
            this.labelRemboursements.Name = "labelRemboursements";
            this.labelRemboursements.Size = new System.Drawing.Size(133, 20);
            this.labelRemboursements.TabIndex = 40;
            this.labelRemboursements.Text = "Remboursements";
            // 
            // textBoxNbRemboursements
            // 
            this.textBoxNbRemboursements.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNbRemboursements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNbRemboursements.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNbRemboursements.ForeColor = System.Drawing.Color.Red;
            this.textBoxNbRemboursements.Location = new System.Drawing.Point(485, 280);
            this.textBoxNbRemboursements.Name = "textBoxNbRemboursements";
            this.textBoxNbRemboursements.Size = new System.Drawing.Size(50, 20);
            this.textBoxNbRemboursements.TabIndex = 39;
            this.textBoxNbRemboursements.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPeriodicite
            // 
            this.labelPeriodicite.AutoSize = true;
            this.labelPeriodicite.Location = new System.Drawing.Point(71, 259);
            this.labelPeriodicite.Name = "labelPeriodicite";
            this.labelPeriodicite.Size = new System.Drawing.Size(167, 15);
            this.labelPeriodicite.TabIndex = 38;
            this.labelPeriodicite.Text = "Périodicité de remboursement";
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(654, 140);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 37;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(654, 95);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 36;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // groupBoxTaux
            // 
            this.groupBoxTaux.Controls.Add(this.radioButton9);
            this.groupBoxTaux.Controls.Add(this.radioButton8);
            this.groupBoxTaux.Controls.Add(this.radioButton7);
            this.groupBoxTaux.Location = new System.Drawing.Point(504, 91);
            this.groupBoxTaux.Name = "groupBoxTaux";
            this.groupBoxTaux.Size = new System.Drawing.Size(120, 170);
            this.groupBoxTaux.TabIndex = 35;
            this.groupBoxTaux.TabStop = false;
            this.groupBoxTaux.Text = "Taux d(\'intérêt";
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(37, 112);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(44, 19);
            this.radioButton9.TabIndex = 2;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "9 %";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(37, 75);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(44, 19);
            this.radioButton8.TabIndex = 1;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "8 %";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(37, 39);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(44, 19);
            this.radioButton7.TabIndex = 0;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "7 %";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // textBoxDuree
            // 
            this.textBoxDuree.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxDuree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDuree.Location = new System.Drawing.Point(203, 206);
            this.textBoxDuree.Name = "textBoxDuree";
            this.textBoxDuree.Size = new System.Drawing.Size(50, 16);
            this.textBoxDuree.TabIndex = 34;
            this.textBoxDuree.Tag = "";
            // 
            // labelDureeMois
            // 
            this.labelDureeMois.Location = new System.Drawing.Point(71, 203);
            this.labelDureeMois.Name = "labelDureeMois";
            this.labelDureeMois.Size = new System.Drawing.Size(109, 35);
            this.labelDureeMois.TabIndex = 33;
            this.labelDureeMois.Text = "Durée en mois du remboursement";
            // 
            // textBoxCapitalEmprunte
            // 
            this.textBoxCapitalEmprunte.Location = new System.Drawing.Point(203, 140);
            this.textBoxCapitalEmprunte.Name = "textBoxCapitalEmprunte";
            this.textBoxCapitalEmprunte.Size = new System.Drawing.Size(150, 23);
            this.textBoxCapitalEmprunte.TabIndex = 32;
            this.textBoxCapitalEmprunte.TextChanged += new System.EventHandler(this.textBoxCapitalEmprunte_TextChanged);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(203, 91);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(150, 23);
            this.textBoxNom.TabIndex = 31;
            this.textBoxNom.TextChanged += new System.EventHandler(this.textBoxNom_TextChanged);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(71, 99);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(34, 15);
            this.labelNom.TabIndex = 30;
            this.labelNom.Text = "Nom";
            // 
            // errorProviderCapitalEmprunte
            // 
            this.errorProviderCapitalEmprunte.ContainerControl = this;
            // 
            // errorProviderNom
            // 
            this.errorProviderNom.ContainerControl = this;
            // 
            // FormEmprunts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hScrollBarDuree);
            this.Controls.Add(this.listBoxPeriodicite);
            this.Controls.Add(this.labelCapitalEmprunte);
            this.Controls.Add(this.textBoxRemboursements);
            this.Controls.Add(this.labelRemboursements);
            this.Controls.Add(this.textBoxNbRemboursements);
            this.Controls.Add(this.labelPeriodicite);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxTaux);
            this.Controls.Add(this.textBoxDuree);
            this.Controls.Add(this.labelDureeMois);
            this.Controls.Add(this.textBoxCapitalEmprunte);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelNom);
            this.Name = "FormEmprunts";
            this.Text = "FormEmprunts";
            this.groupBoxTaux.ResumeLayout(false);
            this.groupBoxTaux.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCapitalEmprunte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HScrollBar hScrollBarDuree;
        private ListBox listBoxPeriodicite;
        private Label labelCapitalEmprunte;
        private TextBox textBoxRemboursements;
        private Label labelRemboursements;
        private TextBox textBoxNbRemboursements;
        private Label labelPeriodicite;
        private Button buttonAnnuler;
        private Button buttonOk;
        private GroupBox groupBoxTaux;
        private RadioButton radioButton9;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private TextBox textBoxDuree;
        private Label labelDureeMois;
        private TextBox textBoxCapitalEmprunte;
        private TextBox textBoxNom;
        private Label labelNom;
        private ErrorProvider errorProviderCapitalEmprunte;
        private ErrorProvider errorProviderNom;
    }
}