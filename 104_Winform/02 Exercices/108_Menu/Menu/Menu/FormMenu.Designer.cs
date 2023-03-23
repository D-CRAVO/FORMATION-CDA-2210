namespace Menu
{
    partial class FormMenu
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
            menuStrip1 = new MenuStrip();
            connectionToolStripMenuItem = new ToolStripMenuItem();
            sidentifierToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            phase1 = new ToolStripMenuItem();
            additionneurToolStripMenuItem = new ToolStripMenuItem();
            phase2 = new ToolStripMenuItem();
            validationSaisieToolStripMenuItem = new ToolStripMenuItem();
            phase3 = new ToolStripMenuItem();
            checkBoxRadioButtonToolStripMenuItem = new ToolStripMenuItem();
            listBoxToolStripMenuItem = new ToolStripMenuItem();
            listBoxComboBoxToolStripMenuItem = new ToolStripMenuItem();
            defilementCouleursToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            empruntsToolStripMenuItem = new ToolStripMenuItem();
            fenetres = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            horizontalToolStripMenuItem = new ToolStripMenuItem();
            verticalToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelDate = new ToolStripStatusLabel();
            toolStripStatusLabelIdentification = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            toolStripLabelIdentification = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripLabelPhase3 = new ToolStripSplitButton();
            toolStripSeparator3 = new ToolStripSeparator();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { connectionToolStripMenuItem, phase1, phase2, phase3, fenetres });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MdiWindowListItem = fenetres;
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // connectionToolStripMenuItem
            // 
            connectionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sidentifierToolStripMenuItem, quitterToolStripMenuItem });
            connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            connectionToolStripMenuItem.Size = new Size(81, 20);
            connectionToolStripMenuItem.Text = "Connection";
            // 
            // sidentifierToolStripMenuItem
            // 
            sidentifierToolStripMenuItem.Name = "sidentifierToolStripMenuItem";
            sidentifierToolStripMenuItem.Size = new Size(130, 22);
            sidentifierToolStripMenuItem.Text = "S'identifier";
            sidentifierToolStripMenuItem.Click += sidentifierToolStripMenuItem_Click;
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(130, 22);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // phase1
            // 
            phase1.DropDownItems.AddRange(new ToolStripItem[] { additionneurToolStripMenuItem });
            phase1.Enabled = false;
            phase1.Name = "phase1";
            phase1.Size = new Size(59, 20);
            phase1.Text = "Phase 1";
            // 
            // additionneurToolStripMenuItem
            // 
            additionneurToolStripMenuItem.Name = "additionneurToolStripMenuItem";
            additionneurToolStripMenuItem.Size = new Size(144, 22);
            additionneurToolStripMenuItem.Text = "Additionneur";
            additionneurToolStripMenuItem.Click += additionneurToolStripMenuItem_Click;
            // 
            // phase2
            // 
            phase2.DropDownItems.AddRange(new ToolStripItem[] { validationSaisieToolStripMenuItem });
            phase2.Enabled = false;
            phase2.Name = "phase2";
            phase2.Size = new Size(59, 20);
            phase2.Text = "Phase 2";
            // 
            // validationSaisieToolStripMenuItem
            // 
            validationSaisieToolStripMenuItem.Name = "validationSaisieToolStripMenuItem";
            validationSaisieToolStripMenuItem.Size = new Size(158, 22);
            validationSaisieToolStripMenuItem.Text = "Validation Saisie";
            validationSaisieToolStripMenuItem.Click += validationSaisieToolStripMenuItem_Click;
            // 
            // phase3
            // 
            phase3.DropDownItems.AddRange(new ToolStripItem[] { checkBoxRadioButtonToolStripMenuItem, listBoxToolStripMenuItem, listBoxComboBoxToolStripMenuItem, defilementCouleursToolStripMenuItem, toolStripSeparator1, empruntsToolStripMenuItem });
            phase3.Enabled = false;
            phase3.Name = "phase3";
            phase3.Size = new Size(59, 20);
            phase3.Text = "Phase 3";
            // 
            // checkBoxRadioButtonToolStripMenuItem
            // 
            checkBoxRadioButtonToolStripMenuItem.Name = "checkBoxRadioButtonToolStripMenuItem";
            checkBoxRadioButtonToolStripMenuItem.Size = new Size(196, 22);
            checkBoxRadioButtonToolStripMenuItem.Text = "CheckBox RadioButton";
            checkBoxRadioButtonToolStripMenuItem.Click += checkBoxRadioButtonToolStripMenuItem_Click;
            // 
            // listBoxToolStripMenuItem
            // 
            listBoxToolStripMenuItem.Name = "listBoxToolStripMenuItem";
            listBoxToolStripMenuItem.Size = new Size(196, 22);
            listBoxToolStripMenuItem.Text = "ListBox";
            listBoxToolStripMenuItem.Click += listBoxToolStripMenuItem_Click;
            // 
            // listBoxComboBoxToolStripMenuItem
            // 
            listBoxComboBoxToolStripMenuItem.Name = "listBoxComboBoxToolStripMenuItem";
            listBoxComboBoxToolStripMenuItem.Size = new Size(196, 22);
            listBoxComboBoxToolStripMenuItem.Text = "ListBoxComboBox";
            listBoxComboBoxToolStripMenuItem.Click += listBoxComboBoxToolStripMenuItem_Click;
            // 
            // defilementCouleursToolStripMenuItem
            // 
            defilementCouleursToolStripMenuItem.Name = "defilementCouleursToolStripMenuItem";
            defilementCouleursToolStripMenuItem.Size = new Size(196, 22);
            defilementCouleursToolStripMenuItem.Text = "DefilementCouleurs";
            defilementCouleursToolStripMenuItem.Click += defilementCouleursToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(193, 6);
            // 
            // empruntsToolStripMenuItem
            // 
            empruntsToolStripMenuItem.Name = "empruntsToolStripMenuItem";
            empruntsToolStripMenuItem.Size = new Size(196, 22);
            empruntsToolStripMenuItem.Text = "Emprunts";
            // 
            // fenetres
            // 
            fenetres.DropDownItems.AddRange(new ToolStripItem[] { cascadeToolStripMenuItem, horizontalToolStripMenuItem, verticalToolStripMenuItem });
            fenetres.Enabled = false;
            fenetres.Name = "fenetres";
            fenetres.Size = new Size(63, 20);
            fenetres.Text = "Fenêtres";
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(180, 22);
            cascadeToolStripMenuItem.Text = "Cascade";
            cascadeToolStripMenuItem.Click += cascadeToolStripMenuItem_Click;
            // 
            // horizontalToolStripMenuItem
            // 
            horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            horizontalToolStripMenuItem.Size = new Size(180, 22);
            horizontalToolStripMenuItem.Text = "Horizontal";
            horizontalToolStripMenuItem.Click += horizontalToolStripMenuItem_Click;
            // 
            // verticalToolStripMenuItem
            // 
            verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            verticalToolStripMenuItem.Size = new Size(180, 22);
            verticalToolStripMenuItem.Text = "Vertical";
            verticalToolStripMenuItem.Click += verticalToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelDate, toolStripStatusLabelIdentification });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelDate
            // 
            toolStripStatusLabelDate.Name = "toolStripStatusLabelDate";
            toolStripStatusLabelDate.Size = new Size(31, 17);
            toolStripStatusLabelDate.Text = "Date";
            // 
            // toolStripStatusLabelIdentification
            // 
            toolStripStatusLabelIdentification.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            toolStripStatusLabelIdentification.LinkVisited = true;
            toolStripStatusLabelIdentification.Name = "toolStripStatusLabelIdentification";
            toolStripStatusLabelIdentification.Size = new Size(87, 17);
            toolStripStatusLabelIdentification.Text = "Dernière action";
            toolStripStatusLabelIdentification.Click += toolStripStatusLabelIdentification_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabelIdentification, toolStripSeparator2, toolStripLabelPhase3, toolStripSeparator3 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // toolStripLabelIdentification
            // 
            toolStripLabelIdentification.AccessibleDescription = "Description";
            toolStripLabelIdentification.AccessibleName = "Name";
            toolStripLabelIdentification.Name = "toolStripLabelIdentification";
            toolStripLabelIdentification.Size = new Size(63, 22);
            toolStripLabelIdentification.Text = "S'identifier";
            toolStripLabelIdentification.Click += toolStripLabel1_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripLabelPhase3
            // 
            toolStripLabelPhase3.Name = "toolStripLabelPhase3";
            toolStripLabelPhase3.Size = new Size(60, 22);
            toolStripLabelPhase3.Text = "Phase3";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormMenu";
            Text = "FormMenu";
            WindowState = FormWindowState.Maximized;
            Load += FormMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem connectionToolStripMenuItem;
        private ToolStripMenuItem sidentifierToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem phase1;
        private ToolStripMenuItem additionneurToolStripMenuItem;
        private ToolStripMenuItem phase2;
        private ToolStripMenuItem validationSaisieToolStripMenuItem;
        private ToolStripMenuItem phase3;
        private ToolStripMenuItem checkBoxRadioButtonToolStripMenuItem;
        private ToolStripMenuItem listBoxToolStripMenuItem;
        private ToolStripMenuItem listBoxComboBoxToolStripMenuItem;
        private ToolStripMenuItem defilementCouleursToolStripMenuItem;
        private ToolStripMenuItem empruntsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem fenetres;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripMenuItem horizontalToolStripMenuItem;
        private ToolStripMenuItem verticalToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelDate;
        private ToolStrip toolStrip1;
        private ToolStripStatusLabel toolStripStatusLabelIdentification;
        private ToolStripLabel toolStripLabelIdentification;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSplitButton toolStripLabelPhase3;
        private ToolStripSeparator toolStripSeparator3;
    }
}