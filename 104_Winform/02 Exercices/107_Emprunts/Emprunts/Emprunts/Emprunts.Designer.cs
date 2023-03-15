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
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.textBoxDuree = new System.Windows.Forms.TextBox();
            this.labelDureeMois = new System.Windows.Forms.Label();
            this.textBoxCapitalEmprunte = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.labelPeriodicite = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelRemboursements = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.richTextBoxPeriodicite = new System.Windows.Forms.RichTextBox();
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
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(246, 159);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(150, 17);
            this.hScrollBar1.TabIndex = 14;
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
            this.textBoxDuree.Text = "120";
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
            this.textBoxCapitalEmprunte.Text = "150000";
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
            this.buttonOk.Location = new System.Drawing.Point(670, 52);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 16;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(670, 97);
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(458, 233);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "40";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(552, 285);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 22;
            this.textBox2.Text = "5483,36€";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richTextBoxPeriodicite
            // 
            this.richTextBoxPeriodicite.Location = new System.Drawing.Point(44, 234);
            this.richTextBoxPeriodicite.Name = "richTextBoxPeriodicite";
            this.richTextBoxPeriodicite.ReadOnly = true;
            this.richTextBoxPeriodicite.Size = new System.Drawing.Size(235, 88);
            this.richTextBoxPeriodicite.TabIndex = 24;
            this.richTextBoxPeriodicite.Text = "Mensuelle\nBimensuelle";
            // 
            // Emprunts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.richTextBoxPeriodicite);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelRemboursements);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelPeriodicite);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxTaux);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.textBoxDuree);
            this.Controls.Add(this.labelDureeMois);
            this.Controls.Add(this.textBoxCapitalEmprunte);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelNom);
            this.Name = "Emprunts";
            this.Text = "Emprunts";
            this.groupBoxTaux.ResumeLayout(false);
            this.groupBoxTaux.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBoxTaux;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private HScrollBar hScrollBar1;
        private TextBox textBoxDuree;
        private Label labelDureeMois;
        private TextBox textBoxCapitalEmprunte;
        private TextBox textBoxNom;
        private Label labelNom;
        private RadioButton radioButton9;
        private Button buttonOk;
        private Button buttonAnnuler;
        private Label labelPeriodicite;
        private TextBox textBox1;
        private Label labelRemboursements;
        private TextBox textBox2;
        private RichTextBox richTextBoxPeriodicite;
        
    }
}