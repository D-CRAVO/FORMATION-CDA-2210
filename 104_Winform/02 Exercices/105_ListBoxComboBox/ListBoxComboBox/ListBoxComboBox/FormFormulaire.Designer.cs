namespace ListBoxComboBox
{
    partial class FormFormulaire
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
            comboBoxSource = new ComboBox();
            label1 = new Label();
            listBoxSource = new ListBox();
            buttonAjouter = new Button();
            buttonAjouterTout = new Button();
            buttonSupprimer = new Button();
            buttonSupprimerTout = new Button();
            listBoxCible = new ListBox();
            buttonUp = new Button();
            buttonDown = new Button();
            labelCible = new Label();
            SuspendLayout();
            // 
            // comboBoxSource
            // 
            comboBoxSource.FormattingEnabled = true;
            comboBoxSource.Location = new Point(12, 38);
            comboBoxSource.Name = "comboBoxSource";
            comboBoxSource.Size = new Size(125, 23);
            comboBoxSource.TabIndex = 0;
            comboBoxSource.SelectedIndexChanged += comboBoxSource_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Location = new Point(16, 12);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 1;
            label1.Text = "Source";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listBoxSource
            // 
            listBoxSource.FormattingEnabled = true;
            listBoxSource.ItemHeight = 15;
            listBoxSource.Location = new Point(12, 67);
            listBoxSource.Name = "listBoxSource";
            listBoxSource.Size = new Size(125, 94);
            listBoxSource.TabIndex = 2;
            listBoxSource.SelectedIndexChanged += listBoxSource_SelectedIndexChanged;
            // 
            // buttonAjouter
            // 
            buttonAjouter.Location = new Point(143, 38);
            buttonAjouter.Name = "buttonAjouter";
            buttonAjouter.Size = new Size(75, 23);
            buttonAjouter.TabIndex = 3;
            buttonAjouter.Text = ">";
            buttonAjouter.UseVisualStyleBackColor = true;
            buttonAjouter.Click += buttonAjouter_Click;
            // 
            // buttonAjouterTout
            // 
            buttonAjouterTout.Location = new Point(143, 67);
            buttonAjouterTout.Name = "buttonAjouterTout";
            buttonAjouterTout.Size = new Size(75, 23);
            buttonAjouterTout.TabIndex = 4;
            buttonAjouterTout.Text = ">>";
            buttonAjouterTout.UseVisualStyleBackColor = true;
            buttonAjouterTout.Click += buttonAjouterTout_Click;
            // 
            // buttonSupprimer
            // 
            buttonSupprimer.Location = new Point(143, 160);
            buttonSupprimer.Name = "buttonSupprimer";
            buttonSupprimer.Size = new Size(75, 23);
            buttonSupprimer.TabIndex = 5;
            buttonSupprimer.Text = "<";
            buttonSupprimer.UseVisualStyleBackColor = true;
            buttonSupprimer.Click += buttonSupprimer_Click;
            // 
            // buttonSupprimerTout
            // 
            buttonSupprimerTout.Location = new Point(143, 189);
            buttonSupprimerTout.Name = "buttonSupprimerTout";
            buttonSupprimerTout.Size = new Size(75, 23);
            buttonSupprimerTout.TabIndex = 6;
            buttonSupprimerTout.Text = "<<";
            buttonSupprimerTout.UseVisualStyleBackColor = true;
            buttonSupprimerTout.Click += buttonSupprimerTout_Click;
            // 
            // listBoxCible
            // 
            listBoxCible.FormattingEnabled = true;
            listBoxCible.ItemHeight = 15;
            listBoxCible.Location = new Point(224, 38);
            listBoxCible.Name = "listBoxCible";
            listBoxCible.Size = new Size(125, 169);
            listBoxCible.TabIndex = 7;
            listBoxCible.SelectedIndexChanged += listBoxCible_SelectedIndexChanged;
            // 
            // buttonUp
            // 
            buttonUp.Location = new Point(228, 213);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(50, 23);
            buttonUp.TabIndex = 8;
            buttonUp.Text = "Up";
            buttonUp.UseVisualStyleBackColor = true;
            buttonUp.Click += buttonUp_Click;
            // 
            // buttonDown
            // 
            buttonDown.Location = new Point(284, 213);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(50, 23);
            buttonDown.TabIndex = 9;
            buttonDown.Text = "Down";
            buttonDown.UseVisualStyleBackColor = true;
            buttonDown.Click += buttonDown_Click;
            // 
            // labelCible
            // 
            labelCible.Location = new Point(224, 12);
            labelCible.Name = "labelCible";
            labelCible.Size = new Size(125, 15);
            labelCible.TabIndex = 10;
            labelCible.Text = "Cible";
            labelCible.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormFormulaire
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(labelCible);
            Controls.Add(buttonDown);
            Controls.Add(buttonUp);
            Controls.Add(listBoxCible);
            Controls.Add(buttonSupprimerTout);
            Controls.Add(buttonSupprimer);
            Controls.Add(buttonAjouterTout);
            Controls.Add(buttonAjouter);
            Controls.Add(listBoxSource);
            Controls.Add(label1);
            Controls.Add(comboBoxSource);
            Name = "FormFormulaire";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Les Listes";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxSource;
        private Label label1;
        private ListBox listBoxSource;
        private Button buttonAjouter;
        private Button buttonAjouterTout;
        private Button buttonSupprimer;
        private Button buttonSupprimerTout;
        private ListBox listBoxCible;
        private Button buttonUp;
        private Button buttonDown;
        private Label labelCible;
    }
}