namespace WFListBoxComboBox
{
    partial class FormListBoxComboBox
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
            labelSource = new Label();
            buttonAjouter = new Button();
            buttonToutSupprimer = new Button();
            buttonSupprimer = new Button();
            buttonAjouterTout = new Button();
            buttonDown = new Button();
            buttonUp = new Button();
            labelCible = new Label();
            listBoxCible = new ListBox();
            SuspendLayout();
            // 
            // comboBoxSource
            // 
            comboBoxSource.FormattingEnabled = true;
            comboBoxSource.Location = new Point(38, 64);
            comboBoxSource.Name = "comboBoxSource";
            comboBoxSource.Size = new Size(121, 23);
            comboBoxSource.TabIndex = 0;
            // 
            // labelSource
            // 
            labelSource.AutoSize = true;
            labelSource.Location = new Point(39, 38);
            labelSource.Name = "labelSource";
            labelSource.Size = new Size(43, 15);
            labelSource.TabIndex = 1;
            labelSource.Text = "Source";
            // 
            // buttonAjouter
            // 
            buttonAjouter.Location = new Point(180, 64);
            buttonAjouter.Name = "buttonAjouter";
            buttonAjouter.Size = new Size(75, 23);
            buttonAjouter.TabIndex = 2;
            buttonAjouter.Text = ">";
            buttonAjouter.UseVisualStyleBackColor = true;
            buttonAjouter.Click += buttonAjouter_Click;
            // 
            // buttonToutSupprimer
            // 
            buttonToutSupprimer.Location = new Point(180, 194);
            buttonToutSupprimer.Name = "buttonToutSupprimer";
            buttonToutSupprimer.Size = new Size(75, 23);
            buttonToutSupprimer.TabIndex = 3;
            buttonToutSupprimer.Text = "<<";
            buttonToutSupprimer.UseVisualStyleBackColor = true;
            buttonToutSupprimer.Click += buttonToutSupprimer_Click;
            // 
            // buttonSupprimer
            // 
            buttonSupprimer.Location = new Point(180, 165);
            buttonSupprimer.Name = "buttonSupprimer";
            buttonSupprimer.Size = new Size(75, 23);
            buttonSupprimer.TabIndex = 4;
            buttonSupprimer.Text = "<";
            buttonSupprimer.UseVisualStyleBackColor = true;
            buttonSupprimer.Click += buttonSupprimer_Click;
            // 
            // buttonAjouterTout
            // 
            buttonAjouterTout.Location = new Point(180, 93);
            buttonAjouterTout.Name = "buttonAjouterTout";
            buttonAjouterTout.Size = new Size(75, 23);
            buttonAjouterTout.TabIndex = 5;
            buttonAjouterTout.Text = ">>";
            buttonAjouterTout.UseVisualStyleBackColor = true;
            buttonAjouterTout.Click += buttonAjouterTout_Click;
            // 
            // buttonDown
            // 
            buttonDown.Location = new Point(365, 223);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(47, 40);
            buttonDown.TabIndex = 7;
            buttonDown.Text = "Down";
            buttonDown.UseVisualStyleBackColor = true;
            // 
            // buttonUp
            // 
            buttonUp.Location = new Point(277, 223);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(47, 40);
            buttonUp.TabIndex = 8;
            buttonUp.Text = "Up";
            buttonUp.UseVisualStyleBackColor = true;
            // 
            // labelCible
            // 
            labelCible.AutoSize = true;
            labelCible.Location = new Point(277, 38);
            labelCible.Name = "labelCible";
            labelCible.Size = new Size(34, 15);
            labelCible.TabIndex = 9;
            labelCible.Text = "Cible";
            // 
            // listBoxCible
            // 
            listBoxCible.FormattingEnabled = true;
            listBoxCible.ItemHeight = 15;
            listBoxCible.Location = new Point(277, 64);
            listBoxCible.Name = "listBoxCible";
            listBoxCible.Size = new Size(135, 154);
            listBoxCible.TabIndex = 10;
            // 
            // FormListBoxComboBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 295);
            Controls.Add(listBoxCible);
            Controls.Add(labelCible);
            Controls.Add(buttonUp);
            Controls.Add(buttonDown);
            Controls.Add(buttonAjouterTout);
            Controls.Add(buttonSupprimer);
            Controls.Add(buttonToutSupprimer);
            Controls.Add(buttonAjouter);
            Controls.Add(labelSource);
            Controls.Add(comboBoxSource);
            Name = "FormListBoxComboBox";
            Text = "FormListBoxComboBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxSource;
        private Label labelSource;
        private Button buttonAjouter;
        private Button buttonToutSupprimer;
        private Button buttonSupprimer;
        private Button buttonAjouterTout;
        private Button buttonDown;
        private Button buttonUp;
        private Label labelCible;
        private ListBox listBoxCible;
    }
}