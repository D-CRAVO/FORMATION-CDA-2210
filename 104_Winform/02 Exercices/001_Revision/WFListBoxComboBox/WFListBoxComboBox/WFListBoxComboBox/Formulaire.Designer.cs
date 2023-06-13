namespace WFListBoxComboBox
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
            listBoxDestination = new ListBox();
            comboBoxSource = new ComboBox();
            buttonAdd = new Button();
            buttonAddAll = new Button();
            buttonRemoveAll = new Button();
            buttonRemove = new Button();
            buttonUp = new Button();
            buttonDown = new Button();
            SuspendLayout();
            // 
            // listBoxDestination
            // 
            listBoxDestination.FormattingEnabled = true;
            listBoxDestination.ItemHeight = 15;
            listBoxDestination.Location = new Point(308, 12);
            listBoxDestination.Name = "listBoxDestination";
            listBoxDestination.Size = new Size(120, 139);
            listBoxDestination.TabIndex = 0;
            // 
            // comboBoxSource
            // 
            comboBoxSource.FormattingEnabled = true;
            comboBoxSource.Location = new Point(12, 12);
            comboBoxSource.Name = "comboBoxSource";
            comboBoxSource.Size = new Size(150, 23);
            comboBoxSource.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(202, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonAddAll
            // 
            buttonAddAll.Location = new Point(202, 41);
            buttonAddAll.Name = "buttonAddAll";
            buttonAddAll.Size = new Size(75, 23);
            buttonAddAll.TabIndex = 3;
            buttonAddAll.Text = "Add All";
            buttonAddAll.UseVisualStyleBackColor = true;
            buttonAddAll.Click += buttonAddAll_Click;
            // 
            // buttonRemoveAll
            // 
            buttonRemoveAll.Location = new Point(202, 128);
            buttonRemoveAll.Name = "buttonRemoveAll";
            buttonRemoveAll.Size = new Size(75, 23);
            buttonRemoveAll.TabIndex = 4;
            buttonRemoveAll.Text = "Remove All";
            buttonRemoveAll.UseVisualStyleBackColor = true;
            buttonRemoveAll.Click += buttonRemoveAll_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(202, 99);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(75, 23);
            buttonRemove.TabIndex = 5;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonUp
            // 
            buttonUp.Location = new Point(308, 172);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(50, 25);
            buttonUp.TabIndex = 6;
            buttonUp.Text = "Up";
            buttonUp.UseVisualStyleBackColor = true;
            // 
            // buttonDown
            // 
            buttonDown.Location = new Point(378, 172);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(50, 25);
            buttonDown.TabIndex = 7;
            buttonDown.Text = "Down";
            buttonDown.UseVisualStyleBackColor = true;
            // 
            // Formulaire
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 213);
            Controls.Add(buttonDown);
            Controls.Add(buttonUp);
            Controls.Add(buttonRemove);
            Controls.Add(buttonRemoveAll);
            Controls.Add(buttonAddAll);
            Controls.Add(buttonAdd);
            Controls.Add(comboBoxSource);
            Controls.Add(listBoxDestination);
            Name = "Formulaire";
            Text = "Formulaire";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxDestination;
        private ComboBox comboBoxSource;
        private Button buttonAdd;
        private Button buttonAddAll;
        private Button buttonRemoveAll;
        private Button buttonRemove;
        private Button buttonUp;
        private Button buttonDown;
    }
}