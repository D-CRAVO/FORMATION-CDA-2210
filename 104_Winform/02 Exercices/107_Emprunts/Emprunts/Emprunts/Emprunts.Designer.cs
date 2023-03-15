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
            groupBoxTaux = new GroupBox();
            radioButton9 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton7 = new RadioButton();
            textBoxDuree = new TextBox();
            labelDureeMois = new Label();
            textBoxCapitalEmprunte = new TextBox();
            textBoxNom = new TextBox();
            labelNom = new Label();
            buttonOk = new Button();
            buttonAnnuler = new Button();
            labelPeriodicite = new Label();
            textBox1 = new TextBox();
            labelRemboursements = new Label();
            textBox2 = new TextBox();
            labelCapitalEmprunte = new Label();
            listBox1 = new ListBox();
            hScrollBarDuree = new HScrollBar();
            groupBoxTaux.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTaux
            // 
            groupBoxTaux.Controls.Add(radioButton9);
            groupBoxTaux.Controls.Add(radioButton8);
            groupBoxTaux.Controls.Add(radioButton7);
            groupBoxTaux.Location = new Point(477, 44);
            groupBoxTaux.Name = "groupBoxTaux";
            groupBoxTaux.Size = new Size(120, 170);
            groupBoxTaux.TabIndex = 15;
            groupBoxTaux.TabStop = false;
            groupBoxTaux.Text = "Taux d('intérêt";
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(37, 112);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(44, 19);
            radioButton9.TabIndex = 2;
            radioButton9.TabStop = true;
            radioButton9.Text = "9 %";
            radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(37, 75);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(44, 19);
            radioButton8.TabIndex = 1;
            radioButton8.TabStop = true;
            radioButton8.Text = "8 %";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(37, 39);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(44, 19);
            radioButton7.TabIndex = 0;
            radioButton7.TabStop = true;
            radioButton7.Text = "7 %";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // textBoxDuree
            // 
            textBoxDuree.BackColor = SystemColors.Control;
            textBoxDuree.BorderStyle = BorderStyle.None;
            textBoxDuree.Location = new Point(176, 159);
            textBoxDuree.Name = "textBoxDuree";
            textBoxDuree.Size = new Size(50, 16);
            textBoxDuree.TabIndex = 13;
            textBoxDuree.Tag = "";
            textBoxDuree.Text = "120";
            // 
            // labelDureeMois
            // 
            labelDureeMois.Location = new Point(44, 156);
            labelDureeMois.Name = "labelDureeMois";
            labelDureeMois.Size = new Size(109, 35);
            labelDureeMois.TabIndex = 12;
            labelDureeMois.Text = "Durée en mois du remboursement";
            // 
            // textBoxCapitalEmprunte
            // 
            textBoxCapitalEmprunte.Location = new Point(176, 93);
            textBoxCapitalEmprunte.Name = "textBoxCapitalEmprunte";
            textBoxCapitalEmprunte.Size = new Size(150, 23);
            textBoxCapitalEmprunte.TabIndex = 11;
            textBoxCapitalEmprunte.Text = "150000";
            // 
            // textBoxNom
            // 
            textBoxNom.Location = new Point(176, 44);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(150, 23);
            textBoxNom.TabIndex = 10;
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(44, 52);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(34, 15);
            labelNom.TabIndex = 8;
            labelNom.Text = "Nom";
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(627, 48);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 16;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonAnnuler
            // 
            buttonAnnuler.Location = new Point(627, 93);
            buttonAnnuler.Name = "buttonAnnuler";
            buttonAnnuler.Size = new Size(75, 23);
            buttonAnnuler.TabIndex = 17;
            buttonAnnuler.Text = "Annuler";
            buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // labelPeriodicite
            // 
            labelPeriodicite.AutoSize = true;
            labelPeriodicite.Location = new Point(44, 212);
            labelPeriodicite.Name = "labelPeriodicite";
            labelPeriodicite.Size = new Size(167, 15);
            labelPeriodicite.TabIndex = 18;
            labelPeriodicite.Text = "Périodicité de remboursement";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Red;
            textBox1.Location = new Point(458, 233);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(50, 20);
            textBox1.TabIndex = 20;
            textBox1.Text = "40";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // labelRemboursements
            // 
            labelRemboursements.AutoSize = true;
            labelRemboursements.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelRemboursements.Location = new Point(537, 233);
            labelRemboursements.Name = "labelRemboursements";
            labelRemboursements.Size = new Size(133, 20);
            labelRemboursements.TabIndex = 21;
            labelRemboursements.Text = "Remboursements";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Red;
            textBox2.Location = new Point(552, 285);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 20);
            textBox2.TabIndex = 22;
            textBox2.Text = "5483,36€";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // labelCapitalEmprunte
            // 
            labelCapitalEmprunte.AutoSize = true;
            labelCapitalEmprunte.Location = new Point(44, 101);
            labelCapitalEmprunte.Name = "labelCapitalEmprunte";
            labelCapitalEmprunte.Size = new Size(99, 15);
            labelCapitalEmprunte.TabIndex = 25;
            labelCapitalEmprunte.Text = "Capital Emprunté";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Mensuelle", "Bimensuelle", "Trimestrielle", "Semestrielle", "Annuelle" });
            listBox1.Location = new Point(44, 233);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(261, 79);
            listBox1.TabIndex = 26;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // hScrollBarDuree
            // 
            hScrollBarDuree.Location = new Point(229, 156);
            hScrollBarDuree.Name = "hScrollBarDuree";
            hScrollBarDuree.Size = new Size(152, 19);
            hScrollBarDuree.TabIndex = 27;
            // 
            // Emprunts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 327);
            Controls.Add(hScrollBarDuree);
            Controls.Add(listBox1);
            Controls.Add(labelCapitalEmprunte);
            Controls.Add(textBox2);
            Controls.Add(labelRemboursements);
            Controls.Add(textBox1);
            Controls.Add(labelPeriodicite);
            Controls.Add(buttonAnnuler);
            Controls.Add(buttonOk);
            Controls.Add(groupBoxTaux);
            Controls.Add(textBoxDuree);
            Controls.Add(labelDureeMois);
            Controls.Add(textBoxCapitalEmprunte);
            Controls.Add(textBoxNom);
            Controls.Add(labelNom);
            Name = "Emprunts";
            Text = "Emprunts";
            groupBoxTaux.ResumeLayout(false);
            groupBoxTaux.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox textBox1;
        private Label labelRemboursements;
        private TextBox textBox2;
        private Label labelCapitalEmprunte;
        private ListBox listBox1;
        private HScrollBar hScrollBarDuree;
    }
}