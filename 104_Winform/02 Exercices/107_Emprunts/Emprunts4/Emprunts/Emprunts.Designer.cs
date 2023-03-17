namespace Emprunts
{
    partial class Emprunts
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
            this.groupBoxTaux = new System.Windows.Forms.GroupBox();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.textBoxDuree = new System.Windows.Forms.TextBox();
            this.labelDureeMois = new System.Windows.Forms.Label();
            this.textBoxCapitalEmprunte = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.labelPeriodicite = new System.Windows.Forms.Label();
            this.textBoxNbRemboursements = new System.Windows.Forms.TextBox();
            this.labelRemboursements = new System.Windows.Forms.Label();
            this.textBoxRemboursements = new System.Windows.Forms.TextBox();
            this.labelCapitalEmprunte = new System.Windows.Forms.Label();
            this.listBoxPeriodicite = new System.Windows.Forms.ListBox();
            this.hScrollBarDuree = new System.Windows.Forms.HScrollBar();
            this.groupBoxTaux.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTaux
            // 
            this.groupBoxTaux.Controls.Add(this.radioButton9);
            this.groupBoxTaux.Controls.Add(this.radioButton8);
            this.groupBoxTaux.Controls.Add(this.radioButton7);
            this.groupBoxTaux.Location = new System.Drawing.Point(477, 44);
            this.groupBoxTaux.Name = "groupBoxTaux";
            this.groupBoxTaux.Size = new System.Drawing.Size(120, 170);
            this.groupBoxTaux.TabIndex = 15;
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
            this.textBoxDuree.Location = new System.Drawing.Point(176, 159);
            this.textBoxDuree.Name = "textBoxDuree";
            this.textBoxDuree.Size = new System.Drawing.Size(50, 16);
            this.textBoxDuree.TabIndex = 13;
            this.textBoxDuree.Tag = "";
            // 
            // labelDureeMois
            // 
            this.labelDureeMois.Location = new System.Drawing.Point(44, 156);
            this.labelDureeMois.Name = "labelDureeMois";
            this.labelDureeMois.Size = new System.Drawing.Size(109, 35);
            this.labelDureeMois.TabIndex = 12;
            this.labelDureeMois.Text = "Durée en mois du remboursement";
            // 
            // textBoxCapitalEmprunte
            // 
            this.textBoxCapitalEmprunte.Location = new System.Drawing.Point(176, 93);
            this.textBoxCapitalEmprunte.Name = "textBoxCapitalEmprunte";
            this.textBoxCapitalEmprunte.Size = new System.Drawing.Size(150, 23);
            this.textBoxCapitalEmprunte.TabIndex = 11;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(176, 44);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(150, 23);
            this.textBoxNom.TabIndex = 10;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(44, 52);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(34, 15);
            this.labelNom.TabIndex = 8;
            this.labelNom.Text = "Nom";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(627, 48);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 16;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(627, 93);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 17;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // labelPeriodicite
            // 
            this.labelPeriodicite.AutoSize = true;
            this.labelPeriodicite.Location = new System.Drawing.Point(44, 212);
            this.labelPeriodicite.Name = "labelPeriodicite";
            this.labelPeriodicite.Size = new System.Drawing.Size(167, 15);
            this.labelPeriodicite.TabIndex = 18;
            this.labelPeriodicite.Text = "Périodicité de remboursement";
            // 
            // textBoxNbRemboursements
            // 
            this.textBoxNbRemboursements.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNbRemboursements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNbRemboursements.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNbRemboursements.ForeColor = System.Drawing.Color.Red;
            this.textBoxNbRemboursements.Location = new System.Drawing.Point(458, 233);
            this.textBoxNbRemboursements.Name = "textBoxNbRemboursements";
            this.textBoxNbRemboursements.Size = new System.Drawing.Size(50, 20);
            this.textBoxNbRemboursements.TabIndex = 20;
            this.textBoxNbRemboursements.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelRemboursements
            // 
            this.labelRemboursements.AutoSize = true;
            this.labelRemboursements.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRemboursements.Location = new System.Drawing.Point(537, 233);
            this.labelRemboursements.Name = "labelRemboursements";
            this.labelRemboursements.Size = new System.Drawing.Size(133, 20);
            this.labelRemboursements.TabIndex = 21;
            this.labelRemboursements.Text = "Remboursements";
            // 
            // textBoxRemboursements
            // 
            this.textBoxRemboursements.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxRemboursements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRemboursements.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxRemboursements.ForeColor = System.Drawing.Color.Red;
            this.textBoxRemboursements.Location = new System.Drawing.Point(552, 285);
            this.textBoxRemboursements.Name = "textBoxRemboursements";
            this.textBoxRemboursements.Size = new System.Drawing.Size(100, 20);
            this.textBoxRemboursements.TabIndex = 22;
            this.textBoxRemboursements.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelCapitalEmprunte
            // 
            this.labelCapitalEmprunte.AutoSize = true;
            this.labelCapitalEmprunte.Location = new System.Drawing.Point(44, 101);
            this.labelCapitalEmprunte.Name = "labelCapitalEmprunte";
            this.labelCapitalEmprunte.Size = new System.Drawing.Size(99, 15);
            this.labelCapitalEmprunte.TabIndex = 25;
            this.labelCapitalEmprunte.Text = "Capital Emprunté";
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
            this.listBoxPeriodicite.Location = new System.Drawing.Point(44, 233);
            this.listBoxPeriodicite.Name = "listBoxPeriodicite";
            this.listBoxPeriodicite.Size = new System.Drawing.Size(261, 79);
            this.listBoxPeriodicite.TabIndex = 26;
            // 
            // hScrollBarDuree
            // 
            this.hScrollBarDuree.Location = new System.Drawing.Point(229, 156);
            this.hScrollBarDuree.Maximum = 360;
            this.hScrollBarDuree.Name = "hScrollBarDuree";
            this.hScrollBarDuree.Size = new System.Drawing.Size(152, 19);
            this.hScrollBarDuree.TabIndex = 27;
            // 
            // Emprunts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 327);
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
            this.Name = "Emprunts";
            this.Text = "Emprunts";
            this.groupBoxTaux.ResumeLayout(false);
            this.groupBoxTaux.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBoxTaux;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private TextBox textBoxDuree;
        private Label labelDureeMois;
        private TextBox textBoxCapitalEmprunte;
        private TextBox textBoxNom;
        private Label labelNom;
        private RadioButton radioButton9;
        private Button buttonOk;
        private Button buttonAnnuler;
        private Label labelPeriodicite;
        private TextBox textBoxNbRemboursements;
        private Label labelRemboursements;
        private TextBox textBoxRemboursements;
        private Label labelCapitalEmprunte;
        private ListBox listBoxPeriodicite;
        private HScrollBar hScrollBarDuree;
    }
}