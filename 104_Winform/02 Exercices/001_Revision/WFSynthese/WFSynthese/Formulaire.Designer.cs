namespace WFSynthese
{
    partial class Formulaire
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
            labelNom = new Label();
            labelCapital = new Label();
            labelDuree = new Label();
            textBoxNom = new TextBox();
            textBoxCapital = new TextBox();
            textBoxDuree = new TextBox();
            hScrollBarDuree = new HScrollBar();
            groupBoxTaux = new GroupBox();
            radioButton9 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton7 = new RadioButton();
            buttonOk = new Button();
            buttonAnnuler = new Button();
            listBoxPeriodicite = new ListBox();
            labelPeriodicite = new Label();
            textBoxNbRemboursements = new TextBox();
            labelRemboursements = new Label();
            textBoxMontantRemboursements = new TextBox();
            groupBoxTaux.SuspendLayout();
            SuspendLayout();
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(35, 48);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(34, 15);
            labelNom.TabIndex = 0;
            labelNom.Text = "Nom";
            // 
            // labelCapital
            // 
            labelCapital.AutoSize = true;
            labelCapital.Location = new Point(35, 89);
            labelCapital.Name = "labelCapital";
            labelCapital.Size = new Size(99, 15);
            labelCapital.TabIndex = 1;
            labelCapital.Text = "Capital Emprunté";
            // 
            // labelDuree
            // 
            labelDuree.Location = new Point(35, 133);
            labelDuree.Name = "labelDuree";
            labelDuree.Size = new Size(111, 31);
            labelDuree.TabIndex = 2;
            labelDuree.Text = "Durée en mois du remboursement";
            // 
            // textBoxNom
            // 
            textBoxNom.Location = new Point(163, 45);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(100, 23);
            textBoxNom.TabIndex = 3;
            // 
            // textBoxCapital
            // 
            textBoxCapital.Location = new Point(163, 81);
            textBoxCapital.Name = "textBoxCapital";
            textBoxCapital.Size = new Size(100, 23);
            textBoxCapital.TabIndex = 4;
            // 
            // textBoxDuree
            // 
            textBoxDuree.Location = new Point(163, 141);
            textBoxDuree.Name = "textBoxDuree";
            textBoxDuree.Size = new Size(45, 23);
            textBoxDuree.TabIndex = 5;
            // 
            // hScrollBarDuree
            // 
            hScrollBarDuree.Location = new Point(225, 141);
            hScrollBarDuree.Maximum = 420;
            hScrollBarDuree.Minimum = 1;
            hScrollBarDuree.Name = "hScrollBarDuree";
            hScrollBarDuree.Size = new Size(118, 23);
            hScrollBarDuree.TabIndex = 6;
            hScrollBarDuree.Value = 1;
            hScrollBarDuree.Scroll += hScrollBarDuree_Scroll;
            // 
            // groupBoxTaux
            // 
            groupBoxTaux.Controls.Add(radioButton9);
            groupBoxTaux.Controls.Add(radioButton8);
            groupBoxTaux.Controls.Add(radioButton7);
            groupBoxTaux.Location = new Point(406, 45);
            groupBoxTaux.Name = "groupBoxTaux";
            groupBoxTaux.Size = new Size(157, 183);
            groupBoxTaux.TabIndex = 7;
            groupBoxTaux.TabStop = false;
            groupBoxTaux.Text = "Taux d'intérêt";
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(18, 132);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(41, 19);
            radioButton9.TabIndex = 2;
            radioButton9.Text = "9%";
            radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(17, 83);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(41, 19);
            radioButton8.TabIndex = 1;
            radioButton8.Text = "8%";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(18, 39);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(41, 19);
            radioButton7.TabIndex = 0;
            radioButton7.Text = "7%";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(642, 48);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 8;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonAnnuler
            // 
            buttonAnnuler.Location = new Point(642, 85);
            buttonAnnuler.Name = "buttonAnnuler";
            buttonAnnuler.Size = new Size(75, 23);
            buttonAnnuler.TabIndex = 9;
            buttonAnnuler.Text = "Annuler";
            buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // listBoxPeriodicite
            // 
            listBoxPeriodicite.FormattingEnabled = true;
            listBoxPeriodicite.ItemHeight = 15;
            listBoxPeriodicite.Items.AddRange(new object[] { "Mensuelle", "Bimestrielle", "Trimestrielle", "Semestrielle", "Annuelle" });
            listBoxPeriodicite.Location = new Point(35, 260);
            listBoxPeriodicite.Name = "listBoxPeriodicite";
            listBoxPeriodicite.Size = new Size(170, 79);
            listBoxPeriodicite.TabIndex = 10;
            listBoxPeriodicite.SelectedIndexChanged += listBoxPeriodicite_SelectedIndexChanged;
            // 
            // labelPeriodicite
            // 
            labelPeriodicite.AutoSize = true;
            labelPeriodicite.Location = new Point(38, 230);
            labelPeriodicite.Name = "labelPeriodicite";
            labelPeriodicite.Size = new Size(167, 15);
            labelPeriodicite.TabIndex = 11;
            labelPeriodicite.Text = "Periodicité de remboursement";
            // 
            // textBoxNbRemboursements
            // 
            textBoxNbRemboursements.Location = new Point(333, 263);
            textBoxNbRemboursements.Name = "textBoxNbRemboursements";
            textBoxNbRemboursements.Size = new Size(42, 23);
            textBoxNbRemboursements.TabIndex = 12;
            // 
            // labelRemboursements
            // 
            labelRemboursements.AutoSize = true;
            labelRemboursements.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelRemboursements.Location = new Point(406, 266);
            labelRemboursements.Name = "labelRemboursements";
            labelRemboursements.Size = new Size(133, 20);
            labelRemboursements.TabIndex = 13;
            labelRemboursements.Text = "Remboursements";
            // 
            // textBoxMontantRemboursements
            // 
            textBoxMontantRemboursements.Location = new Point(406, 316);
            textBoxMontantRemboursements.Name = "textBoxMontantRemboursements";
            textBoxMontantRemboursements.Size = new Size(133, 23);
            textBoxMontantRemboursements.TabIndex = 14;
            textBoxMontantRemboursements.TextAlign = HorizontalAlignment.Center;
            // 
            // Formulaire
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxMontantRemboursements);
            Controls.Add(labelRemboursements);
            Controls.Add(textBoxNbRemboursements);
            Controls.Add(labelPeriodicite);
            Controls.Add(listBoxPeriodicite);
            Controls.Add(buttonAnnuler);
            Controls.Add(buttonOk);
            Controls.Add(groupBoxTaux);
            Controls.Add(hScrollBarDuree);
            Controls.Add(textBoxDuree);
            Controls.Add(textBoxCapital);
            Controls.Add(textBoxNom);
            Controls.Add(labelDuree);
            Controls.Add(labelCapital);
            Controls.Add(labelNom);
            Name = "Formulaire";
            Text = "Formulaire";
            Load += Formulaire_Load;
            groupBoxTaux.ResumeLayout(false);
            groupBoxTaux.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNom;
        private Label labelCapital;
        private Label labelDuree;
        private TextBox textBoxNom;
        private TextBox textBoxCapital;
        private TextBox textBoxDuree;
        private HScrollBar hScrollBarDuree;
        private GroupBox groupBoxTaux;
        private RadioButton radioButton9;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private Button buttonOk;
        private Button buttonAnnuler;
        private ListBox listBoxPeriodicite;
        private Label labelPeriodicite;
        private TextBox textBoxNbRemboursements;
        private Label labelRemboursements;
        private TextBox textBoxMontantRemboursements;
    }
}