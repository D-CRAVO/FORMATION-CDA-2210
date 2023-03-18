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
            components = new System.ComponentModel.Container();
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
            textBoxNbRemboursements = new TextBox();
            labelRemboursements = new Label();
            textBoxRemboursements = new TextBox();
            labelCapitalEmprunte = new Label();
            listBoxPeriodicite = new ListBox();
            hScrollBarDuree = new HScrollBar();
            errorProviderCapitalEmprunte = new ErrorProvider(components);
            errorProviderNom = new ErrorProvider(components);
            groupBoxTaux.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderCapitalEmprunte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderNom).BeginInit();
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
            textBoxDuree.Location = new Point(176, 159);
            textBoxDuree.Name = "textBoxDuree";
            textBoxDuree.Size = new Size(50, 16);
            textBoxDuree.TabIndex = 13;
            textBoxDuree.Tag = "";
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
            textBoxCapitalEmprunte.TextChanged += textBoxCapitalEmprunte_TextChanged;
            // 
            // textBoxNom
            // 
            textBoxNom.Location = new Point(176, 44);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(150, 23);
            textBoxNom.TabIndex = 10;
            textBoxNom.TextChanged += textBoxNom_TextChanged;
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
            buttonAnnuler.Click += buttonAnnuler_Click;
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
            // textBoxNbRemboursements
            // 
            textBoxNbRemboursements.BackColor = SystemColors.Control;
            textBoxNbRemboursements.BorderStyle = BorderStyle.None;
            textBoxNbRemboursements.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNbRemboursements.ForeColor = Color.Red;
            textBoxNbRemboursements.Location = new Point(458, 233);
            textBoxNbRemboursements.Name = "textBoxNbRemboursements";
            textBoxNbRemboursements.Size = new Size(50, 20);
            textBoxNbRemboursements.TabIndex = 20;
            textBoxNbRemboursements.TextAlign = HorizontalAlignment.Center;
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
            // textBoxRemboursements
            // 
            textBoxRemboursements.BackColor = SystemColors.Control;
            textBoxRemboursements.BorderStyle = BorderStyle.None;
            textBoxRemboursements.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRemboursements.ForeColor = Color.Red;
            textBoxRemboursements.Location = new Point(552, 285);
            textBoxRemboursements.Name = "textBoxRemboursements";
            textBoxRemboursements.Size = new Size(100, 20);
            textBoxRemboursements.TabIndex = 22;
            textBoxRemboursements.TextAlign = HorizontalAlignment.Center;
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
            // listBoxPeriodicite
            // 
            listBoxPeriodicite.FormattingEnabled = true;
            listBoxPeriodicite.ItemHeight = 15;
            listBoxPeriodicite.Items.AddRange(new object[] { "Mensuelle", "Bimestrielle", "Trimestrielle", "Semestrielle", "Annuelle" });
            listBoxPeriodicite.Location = new Point(44, 233);
            listBoxPeriodicite.Name = "listBoxPeriodicite";
            listBoxPeriodicite.Size = new Size(261, 79);
            listBoxPeriodicite.TabIndex = 26;
            listBoxPeriodicite.SelectedIndexChanged += listBoxPeriodicite_SelectedIndexChanged;
            // 
            // hScrollBarDuree
            // 
            hScrollBarDuree.Location = new Point(266, 159);
            hScrollBarDuree.Maximum = 369;
            hScrollBarDuree.Name = "hScrollBarDuree";
            hScrollBarDuree.Size = new Size(165, 17);
            hScrollBarDuree.TabIndex = 29;
            hScrollBarDuree.Scroll += hScrollBar_Scroll;
            // 
            // errorProviderCapitalEmprunte
            // 
            errorProviderCapitalEmprunte.ContainerControl = this;
            // 
            // errorProviderNom
            // 
            errorProviderNom.ContainerControl = this;
            // 
            // Emprunts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 327);
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
            Name = "Emprunts";
            Text = "Emprunts";
            groupBoxTaux.ResumeLayout(false);
            groupBoxTaux.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderCapitalEmprunte).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderNom).EndInit();
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
        private TextBox textBoxNbRemboursements;
        private Label labelRemboursements;
        private TextBox textBoxRemboursements;
        private Label labelCapitalEmprunte;
        private ListBox listBoxPeriodicite;
        private HScrollBar hScrollBarDuree;
        private ErrorProvider errorProviderCapitalEmprunte;
        private ErrorProvider errorProviderNom;
    }
}