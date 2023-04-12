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
            components = new System.ComponentModel.Container();
            hScrollBarDuree = new HScrollBar();
            listBoxPeriodicite = new ListBox();
            labelCapitalEmprunte = new Label();
            textBoxRemboursements = new TextBox();
            labelRemboursements = new Label();
            textBoxNbRemboursements = new TextBox();
            labelPeriodicite = new Label();
            buttonAnnuler = new Button();
            buttonOk = new Button();
            groupBoxTaux = new GroupBox();
            radioButton9 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton7 = new RadioButton();
            textBoxDuree = new TextBox();
            labelDureeMois = new Label();
            textBoxCapitalEmprunte = new TextBox();
            textBoxNom = new TextBox();
            labelNom = new Label();
            errorProviderCapitalEmprunte = new ErrorProvider(components);
            errorProviderNom = new ErrorProvider(components);
            groupBoxTaux.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderCapitalEmprunte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderNom).BeginInit();
            SuspendLayout();
            // 
            // hScrollBarDuree
            // 
            hScrollBarDuree.LargeChange = 12;
            hScrollBarDuree.Location = new Point(293, 206);
            hScrollBarDuree.Maximum = 369;
            hScrollBarDuree.Minimum = 1;
            hScrollBarDuree.Name = "hScrollBarDuree";
            hScrollBarDuree.Size = new Size(165, 17);
            hScrollBarDuree.TabIndex = 44;
            hScrollBarDuree.Value = 1;
            hScrollBarDuree.Scroll += hScrollBar_Scroll;
            // 
            // listBoxPeriodicite
            // 
            listBoxPeriodicite.FormattingEnabled = true;
            listBoxPeriodicite.ItemHeight = 15;
            listBoxPeriodicite.Items.AddRange(new object[] { "Mensuelle", "Bimestrielle", "Trimestrielle", "Semestrielle", "Annuelle" });
            listBoxPeriodicite.Location = new Point(71, 280);
            listBoxPeriodicite.Name = "listBoxPeriodicite";
            listBoxPeriodicite.Size = new Size(261, 79);
            listBoxPeriodicite.TabIndex = 43;
            listBoxPeriodicite.SelectedIndexChanged += listBoxPeriodicite_SelectedIndexChanged;
            // 
            // labelCapitalEmprunte
            // 
            labelCapitalEmprunte.AutoSize = true;
            labelCapitalEmprunte.Location = new Point(71, 148);
            labelCapitalEmprunte.Name = "labelCapitalEmprunte";
            labelCapitalEmprunte.Size = new Size(99, 15);
            labelCapitalEmprunte.TabIndex = 42;
            labelCapitalEmprunte.Text = "Capital Emprunté";
            // 
            // textBoxRemboursements
            // 
            textBoxRemboursements.BackColor = SystemColors.Control;
            textBoxRemboursements.BorderStyle = BorderStyle.None;
            textBoxRemboursements.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRemboursements.ForeColor = Color.Red;
            textBoxRemboursements.Location = new Point(579, 332);
            textBoxRemboursements.Name = "textBoxRemboursements";
            textBoxRemboursements.Size = new Size(100, 20);
            textBoxRemboursements.TabIndex = 41;
            textBoxRemboursements.TextAlign = HorizontalAlignment.Center;
            // 
            // labelRemboursements
            // 
            labelRemboursements.AutoSize = true;
            labelRemboursements.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelRemboursements.Location = new Point(564, 280);
            labelRemboursements.Name = "labelRemboursements";
            labelRemboursements.Size = new Size(133, 20);
            labelRemboursements.TabIndex = 40;
            labelRemboursements.Text = "Remboursements";
            // 
            // textBoxNbRemboursements
            // 
            textBoxNbRemboursements.BackColor = SystemColors.Control;
            textBoxNbRemboursements.BorderStyle = BorderStyle.None;
            textBoxNbRemboursements.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNbRemboursements.ForeColor = Color.Red;
            textBoxNbRemboursements.Location = new Point(485, 280);
            textBoxNbRemboursements.Name = "textBoxNbRemboursements";
            textBoxNbRemboursements.Size = new Size(50, 20);
            textBoxNbRemboursements.TabIndex = 39;
            textBoxNbRemboursements.TextAlign = HorizontalAlignment.Center;
            // 
            // labelPeriodicite
            // 
            labelPeriodicite.AutoSize = true;
            labelPeriodicite.Location = new Point(71, 259);
            labelPeriodicite.Name = "labelPeriodicite";
            labelPeriodicite.Size = new Size(167, 15);
            labelPeriodicite.TabIndex = 38;
            labelPeriodicite.Text = "Périodicité de remboursement";
            // 
            // buttonAnnuler
            // 
            buttonAnnuler.Location = new Point(654, 140);
            buttonAnnuler.Name = "buttonAnnuler";
            buttonAnnuler.Size = new Size(75, 23);
            buttonAnnuler.TabIndex = 37;
            buttonAnnuler.Text = "Annuler";
            buttonAnnuler.UseVisualStyleBackColor = true;
            buttonAnnuler.Click += buttonAnnuler_Click;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(654, 95);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 36;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // groupBoxTaux
            // 
            groupBoxTaux.Controls.Add(radioButton9);
            groupBoxTaux.Controls.Add(radioButton8);
            groupBoxTaux.Controls.Add(radioButton7);
            groupBoxTaux.Location = new Point(504, 91);
            groupBoxTaux.Name = "groupBoxTaux";
            groupBoxTaux.Size = new Size(120, 170);
            groupBoxTaux.TabIndex = 35;
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
            radioButton9.CheckedChanged += radioButton9_CheckedChanged;
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
            radioButton8.CheckedChanged += radioButton8_CheckedChanged;
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
            radioButton7.CheckedChanged += radioButton7_CheckedChanged;
            // 
            // textBoxDuree
            // 
            textBoxDuree.BackColor = SystemColors.Control;
            textBoxDuree.BorderStyle = BorderStyle.None;
            textBoxDuree.Location = new Point(203, 206);
            textBoxDuree.Name = "textBoxDuree";
            textBoxDuree.Size = new Size(50, 16);
            textBoxDuree.TabIndex = 34;
            textBoxDuree.Tag = "";
            // 
            // labelDureeMois
            // 
            labelDureeMois.Location = new Point(71, 203);
            labelDureeMois.Name = "labelDureeMois";
            labelDureeMois.Size = new Size(109, 35);
            labelDureeMois.TabIndex = 33;
            labelDureeMois.Text = "Durée en mois du remboursement";
            // 
            // textBoxCapitalEmprunte
            // 
            textBoxCapitalEmprunte.Location = new Point(203, 140);
            textBoxCapitalEmprunte.Name = "textBoxCapitalEmprunte";
            textBoxCapitalEmprunte.Size = new Size(150, 23);
            textBoxCapitalEmprunte.TabIndex = 32;
            textBoxCapitalEmprunte.TextChanged += textBoxCapitalEmprunte_TextChanged;
            // 
            // textBoxNom
            // 
            textBoxNom.Location = new Point(203, 91);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(150, 23);
            textBoxNom.TabIndex = 31;
            textBoxNom.TextChanged += textBoxNom_TextChanged;
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(71, 99);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(34, 15);
            labelNom.TabIndex = 30;
            labelNom.Text = "Nom";
            // 
            // errorProviderCapitalEmprunte
            // 
            errorProviderCapitalEmprunte.ContainerControl = this;
            // 
            // errorProviderNom
            // 
            errorProviderNom.ContainerControl = this;
            // 
            // FormEmprunts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(hScrollBarDuree);
            Controls.Add(listBoxPeriodicite);
            Controls.Add(labelCapitalEmprunte);
            Controls.Add(textBoxRemboursements);
            Controls.Add(labelRemboursements);
            Controls.Add(textBoxNbRemboursements);
            Controls.Add(labelPeriodicite);
            Controls.Add(buttonAnnuler);
            Controls.Add(buttonOk);
            Controls.Add(groupBoxTaux);
            Controls.Add(textBoxDuree);
            Controls.Add(labelDureeMois);
            Controls.Add(textBoxCapitalEmprunte);
            Controls.Add(textBoxNom);
            Controls.Add(labelNom);
            Name = "FormEmprunts";
            Text = "FormEmprunts";
            FormClosing += FormEmprunts_FormClosing;
            groupBoxTaux.ResumeLayout(false);
            groupBoxTaux.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderCapitalEmprunte).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderNom).EndInit();
            ResumeLayout(false);
            PerformLayout();
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