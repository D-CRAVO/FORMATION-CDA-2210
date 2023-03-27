namespace WFToutEmbal
{
    partial class FormToutEmbal
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
            tabControl1 = new TabControl();
            tabPageTypeA = new TabPage();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            labelNombreA = new Label();
            labelTauxHeureA = new Label();
            labelTauxDemarrageA = new Label();
            tabPageTypeB = new TabPage();
            textBoxTauxDefautDemarrageB = new TextBox();
            textBoxTauxDefautHeureB = new TextBox();
            textBoxNombreDemarrageB = new TextBox();
            labelNombreDemarrageB = new Label();
            labelTauxDefautHeureB = new Label();
            labelTauxDefautDemarrageB = new Label();
            tabPageTypeC = new TabPage();
            textBoxTauxDefautDemarrageC = new TextBox();
            textBoxTauxDefautHeureC = new TextBox();
            textBoxNombreDemarrageC = new TextBox();
            labelNombreDemarrageC = new Label();
            labelTauxHeureC = new Label();
            labelTauxDemarrageC = new Label();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            progressBar3 = new ProgressBar();
            labelProductionA = new Label();
            labelProductionB = new Label();
            labelProductionC = new Label();
            menuStrip1 = new MenuStrip();
            fichierToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            productionToolStripMenuItem = new ToolStripMenuItem();
            démarrerToolStripMenuItem = new ToolStripMenuItem();
            arrêterToolStripMenuItem = new ToolStripMenuItem();
            continuerToolStripMenuItem = new ToolStripMenuItem();
            aToolStripMenuItem = new ToolStripMenuItem();
            bToolStripMenuItem = new ToolStripMenuItem();
            cToolStripMenuItem = new ToolStripMenuItem();
            aToolStripMenuItem1 = new ToolStripMenuItem();
            bToolStripMenuItem1 = new ToolStripMenuItem();
            cToolStripMenuItem1 = new ToolStripMenuItem();
            aToolStripMenuItem2 = new ToolStripMenuItem();
            bToolStripMenuItem2 = new ToolStripMenuItem();
            cToolStripMenuItem2 = new ToolStripMenuItem();
            tabControl1.SuspendLayout();
            tabPageTypeA.SuspendLayout();
            tabPageTypeB.SuspendLayout();
            tabPageTypeC.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageTypeA);
            tabControl1.Controls.Add(tabPageTypeB);
            tabControl1.Controls.Add(tabPageTypeC);
            tabControl1.Location = new Point(278, 55);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(449, 295);
            tabControl1.TabIndex = 2;
            // 
            // tabPageTypeA
            // 
            tabPageTypeA.Controls.Add(textBox3);
            tabPageTypeA.Controls.Add(textBox2);
            tabPageTypeA.Controls.Add(textBox1);
            tabPageTypeA.Controls.Add(labelNombreA);
            tabPageTypeA.Controls.Add(labelTauxHeureA);
            tabPageTypeA.Controls.Add(labelTauxDemarrageA);
            tabPageTypeA.Location = new Point(4, 24);
            tabPageTypeA.Name = "tabPageTypeA";
            tabPageTypeA.Padding = new Padding(3);
            tabPageTypeA.Size = new Size(441, 267);
            tabPageTypeA.TabIndex = 0;
            tabPageTypeA.Text = "Type A";
            tabPageTypeA.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(316, 186);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(316, 122);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(316, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 10;
            // 
            // labelNombreA
            // 
            labelNombreA.AutoSize = true;
            labelNombreA.Location = new Point(27, 68);
            labelNombreA.Name = "labelNombreA";
            labelNombreA.Size = new Size(269, 15);
            labelNombreA.TabIndex = 7;
            labelNombreA.Text = "Nombre de caisses produites depuis le démarrage";
            // 
            // labelTauxHeureA
            // 
            labelTauxHeureA.AutoSize = true;
            labelTauxHeureA.Location = new Point(27, 133);
            labelTauxHeureA.Name = "labelTauxHeureA";
            labelTauxHeureA.Size = new Size(101, 15);
            labelTauxHeureA.TabIndex = 8;
            labelTauxHeureA.Text = "Taux defaut heure";
            // 
            // labelTauxDemarrageA
            // 
            labelTauxDemarrageA.AutoSize = true;
            labelTauxDemarrageA.Location = new Point(27, 197);
            labelTauxDemarrageA.Name = "labelTauxDemarrageA";
            labelTauxDemarrageA.Size = new Size(166, 15);
            labelTauxDemarrageA.TabIndex = 9;
            labelTauxDemarrageA.Text = "Taux défaut depuis démarrage";
            // 
            // tabPageTypeB
            // 
            tabPageTypeB.Controls.Add(textBoxTauxDefautDemarrageB);
            tabPageTypeB.Controls.Add(textBoxTauxDefautHeureB);
            tabPageTypeB.Controls.Add(textBoxNombreDemarrageB);
            tabPageTypeB.Controls.Add(labelNombreDemarrageB);
            tabPageTypeB.Controls.Add(labelTauxDefautHeureB);
            tabPageTypeB.Controls.Add(labelTauxDefautDemarrageB);
            tabPageTypeB.Location = new Point(4, 24);
            tabPageTypeB.Name = "tabPageTypeB";
            tabPageTypeB.Padding = new Padding(3);
            tabPageTypeB.Size = new Size(441, 267);
            tabPageTypeB.TabIndex = 1;
            tabPageTypeB.Text = "Type B";
            tabPageTypeB.UseVisualStyleBackColor = true;
            // 
            // textBoxTauxDefautDemarrageB
            // 
            textBoxTauxDefautDemarrageB.Location = new Point(316, 186);
            textBoxTauxDefautDemarrageB.Name = "textBoxTauxDefautDemarrageB";
            textBoxTauxDefautDemarrageB.Size = new Size(100, 23);
            textBoxTauxDefautDemarrageB.TabIndex = 12;
            // 
            // textBoxTauxDefautHeureB
            // 
            textBoxTauxDefautHeureB.Location = new Point(316, 122);
            textBoxTauxDefautHeureB.Name = "textBoxTauxDefautHeureB";
            textBoxTauxDefautHeureB.Size = new Size(100, 23);
            textBoxTauxDefautHeureB.TabIndex = 11;
            // 
            // textBoxNombreDemarrageB
            // 
            textBoxNombreDemarrageB.Location = new Point(316, 57);
            textBoxNombreDemarrageB.Name = "textBoxNombreDemarrageB";
            textBoxNombreDemarrageB.Size = new Size(100, 23);
            textBoxNombreDemarrageB.TabIndex = 10;
            // 
            // labelNombreDemarrageB
            // 
            labelNombreDemarrageB.AutoSize = true;
            labelNombreDemarrageB.Location = new Point(27, 68);
            labelNombreDemarrageB.Name = "labelNombreDemarrageB";
            labelNombreDemarrageB.Size = new Size(269, 15);
            labelNombreDemarrageB.TabIndex = 7;
            labelNombreDemarrageB.Text = "Nombre de caisses produites depuis le démarrage";
            // 
            // labelTauxDefautHeureB
            // 
            labelTauxDefautHeureB.AutoSize = true;
            labelTauxDefautHeureB.Location = new Point(27, 133);
            labelTauxDefautHeureB.Name = "labelTauxDefautHeureB";
            labelTauxDefautHeureB.Size = new Size(101, 15);
            labelTauxDefautHeureB.TabIndex = 8;
            labelTauxDefautHeureB.Text = "Taux defaut heure";
            // 
            // labelTauxDefautDemarrageB
            // 
            labelTauxDefautDemarrageB.AutoSize = true;
            labelTauxDefautDemarrageB.Location = new Point(27, 197);
            labelTauxDefautDemarrageB.Name = "labelTauxDefautDemarrageB";
            labelTauxDefautDemarrageB.Size = new Size(166, 15);
            labelTauxDefautDemarrageB.TabIndex = 9;
            labelTauxDefautDemarrageB.Text = "Taux défaut depuis démarrage";
            // 
            // tabPageTypeC
            // 
            tabPageTypeC.Controls.Add(textBoxTauxDefautDemarrageC);
            tabPageTypeC.Controls.Add(textBoxTauxDefautHeureC);
            tabPageTypeC.Controls.Add(textBoxNombreDemarrageC);
            tabPageTypeC.Controls.Add(labelNombreDemarrageC);
            tabPageTypeC.Controls.Add(labelTauxHeureC);
            tabPageTypeC.Controls.Add(labelTauxDemarrageC);
            tabPageTypeC.Location = new Point(4, 24);
            tabPageTypeC.Name = "tabPageTypeC";
            tabPageTypeC.Padding = new Padding(3);
            tabPageTypeC.Size = new Size(441, 267);
            tabPageTypeC.TabIndex = 2;
            tabPageTypeC.Text = "Type C";
            tabPageTypeC.UseVisualStyleBackColor = true;
            // 
            // textBoxTauxDefautDemarrageC
            // 
            textBoxTauxDefautDemarrageC.Location = new Point(316, 186);
            textBoxTauxDefautDemarrageC.Name = "textBoxTauxDefautDemarrageC";
            textBoxTauxDefautDemarrageC.Size = new Size(100, 23);
            textBoxTauxDefautDemarrageC.TabIndex = 12;
            // 
            // textBoxTauxDefautHeureC
            // 
            textBoxTauxDefautHeureC.Location = new Point(316, 122);
            textBoxTauxDefautHeureC.Name = "textBoxTauxDefautHeureC";
            textBoxTauxDefautHeureC.Size = new Size(100, 23);
            textBoxTauxDefautHeureC.TabIndex = 11;
            // 
            // textBoxNombreDemarrageC
            // 
            textBoxNombreDemarrageC.Location = new Point(316, 57);
            textBoxNombreDemarrageC.Name = "textBoxNombreDemarrageC";
            textBoxNombreDemarrageC.Size = new Size(100, 23);
            textBoxNombreDemarrageC.TabIndex = 10;
            // 
            // labelNombreDemarrageC
            // 
            labelNombreDemarrageC.AutoSize = true;
            labelNombreDemarrageC.Location = new Point(27, 68);
            labelNombreDemarrageC.Name = "labelNombreDemarrageC";
            labelNombreDemarrageC.Size = new Size(269, 15);
            labelNombreDemarrageC.TabIndex = 7;
            labelNombreDemarrageC.Text = "Nombre de caisses produites depuis le démarrage";
            // 
            // labelTauxHeureC
            // 
            labelTauxHeureC.AutoSize = true;
            labelTauxHeureC.Location = new Point(27, 133);
            labelTauxHeureC.Name = "labelTauxHeureC";
            labelTauxHeureC.Size = new Size(101, 15);
            labelTauxHeureC.TabIndex = 8;
            labelTauxHeureC.Text = "Taux defaut heure";
            // 
            // labelTauxDemarrageC
            // 
            labelTauxDemarrageC.AutoSize = true;
            labelTauxDemarrageC.Location = new Point(27, 197);
            labelTauxDemarrageC.Name = "labelTauxDemarrageC";
            labelTauxDemarrageC.Size = new Size(166, 15);
            labelTauxDemarrageC.TabIndex = 9;
            labelTauxDemarrageC.Text = "Taux défaut depuis démarrage";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(278, 370);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(445, 23);
            progressBar1.TabIndex = 3;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(278, 399);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(445, 23);
            progressBar2.TabIndex = 4;
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(278, 428);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(445, 23);
            progressBar3.TabIndex = 5;
            // 
            // labelProductionA
            // 
            labelProductionA.AutoSize = true;
            labelProductionA.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelProductionA.Location = new Point(86, 373);
            labelProductionA.Name = "labelProductionA";
            labelProductionA.Size = new Size(101, 20);
            labelProductionA.TabIndex = 6;
            labelProductionA.Text = "Production A";
            // 
            // labelProductionB
            // 
            labelProductionB.AutoSize = true;
            labelProductionB.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelProductionB.Location = new Point(86, 402);
            labelProductionB.Name = "labelProductionB";
            labelProductionB.Size = new Size(100, 20);
            labelProductionB.TabIndex = 7;
            labelProductionB.Text = "Production B";
            // 
            // labelProductionC
            // 
            labelProductionC.AutoSize = true;
            labelProductionC.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelProductionC.Location = new Point(86, 431);
            labelProductionC.Name = "labelProductionC";
            labelProductionC.Size = new Size(99, 20);
            labelProductionC.TabIndex = 8;
            labelProductionC.Text = "Production C";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem, productionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(727, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quitterToolStripMenuItem });
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(54, 20);
            fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(180, 22);
            quitterToolStripMenuItem.Text = "Quitter";
            // 
            // productionToolStripMenuItem
            // 
            productionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { démarrerToolStripMenuItem, arrêterToolStripMenuItem, continuerToolStripMenuItem });
            productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            productionToolStripMenuItem.Size = new Size(78, 20);
            productionToolStripMenuItem.Text = "Production";
            // 
            // démarrerToolStripMenuItem
            // 
            démarrerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aToolStripMenuItem, bToolStripMenuItem, cToolStripMenuItem });
            démarrerToolStripMenuItem.Name = "démarrerToolStripMenuItem";
            démarrerToolStripMenuItem.Size = new Size(127, 22);
            démarrerToolStripMenuItem.Text = "Démarrer";
            // 
            // arrêterToolStripMenuItem
            // 
            arrêterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aToolStripMenuItem1, bToolStripMenuItem1, cToolStripMenuItem1 });
            arrêterToolStripMenuItem.Name = "arrêterToolStripMenuItem";
            arrêterToolStripMenuItem.Size = new Size(127, 22);
            arrêterToolStripMenuItem.Text = "Arrêter";
            // 
            // continuerToolStripMenuItem
            // 
            continuerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aToolStripMenuItem2, bToolStripMenuItem2, cToolStripMenuItem2 });
            continuerToolStripMenuItem.Name = "continuerToolStripMenuItem";
            continuerToolStripMenuItem.Size = new Size(127, 22);
            continuerToolStripMenuItem.Text = "Continuer";
            // 
            // aToolStripMenuItem
            // 
            aToolStripMenuItem.Name = "aToolStripMenuItem";
            aToolStripMenuItem.Size = new Size(180, 22);
            aToolStripMenuItem.Text = "A";
            // 
            // bToolStripMenuItem
            // 
            bToolStripMenuItem.Name = "bToolStripMenuItem";
            bToolStripMenuItem.Size = new Size(180, 22);
            bToolStripMenuItem.Text = "B";
            // 
            // cToolStripMenuItem
            // 
            cToolStripMenuItem.Name = "cToolStripMenuItem";
            cToolStripMenuItem.Size = new Size(180, 22);
            cToolStripMenuItem.Text = "C";
            // 
            // aToolStripMenuItem1
            // 
            aToolStripMenuItem1.Name = "aToolStripMenuItem1";
            aToolStripMenuItem1.Size = new Size(180, 22);
            aToolStripMenuItem1.Text = "A";
            // 
            // bToolStripMenuItem1
            // 
            bToolStripMenuItem1.Name = "bToolStripMenuItem1";
            bToolStripMenuItem1.Size = new Size(180, 22);
            bToolStripMenuItem1.Text = "B";
            // 
            // cToolStripMenuItem1
            // 
            cToolStripMenuItem1.Name = "cToolStripMenuItem1";
            cToolStripMenuItem1.Size = new Size(180, 22);
            cToolStripMenuItem1.Text = "C";
            // 
            // aToolStripMenuItem2
            // 
            aToolStripMenuItem2.Name = "aToolStripMenuItem2";
            aToolStripMenuItem2.Size = new Size(180, 22);
            aToolStripMenuItem2.Text = "A";
            // 
            // bToolStripMenuItem2
            // 
            bToolStripMenuItem2.Name = "bToolStripMenuItem2";
            bToolStripMenuItem2.Size = new Size(180, 22);
            bToolStripMenuItem2.Text = "B";
            // 
            // cToolStripMenuItem2
            // 
            cToolStripMenuItem2.Name = "cToolStripMenuItem2";
            cToolStripMenuItem2.Size = new Size(180, 22);
            cToolStripMenuItem2.Text = "C";
            // 
            // FormToutEmbal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 461);
            Controls.Add(labelProductionC);
            Controls.Add(labelProductionB);
            Controls.Add(labelProductionA);
            Controls.Add(progressBar3);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormToutEmbal";
            Text = "FormToutEmbal";
            tabControl1.ResumeLayout(false);
            tabPageTypeA.ResumeLayout(false);
            tabPageTypeA.PerformLayout();
            tabPageTypeB.ResumeLayout(false);
            tabPageTypeB.PerformLayout();
            tabPageTypeC.ResumeLayout(false);
            tabPageTypeC.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageTypeA;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label labelNombreA;
        private Label labelTauxHeureA;
        private Label labelTauxDemarrageA;
        private TabPage tabPageTypeB;
        private TextBox textBoxTauxDefautDemarrageB;
        private TextBox textBoxTauxDefautHeureB;
        private TextBox textBoxNombreDemarrageB;
        private Label labelNombreDemarrageB;
        private Label labelTauxDefautHeureB;
        private Label labelTauxDefautDemarrageB;
        private TabPage tabPageTypeC;
        private TextBox textBoxTauxDefautDemarrageC;
        private TextBox textBoxTauxDefautHeureC;
        private TextBox textBoxNombreDemarrageC;
        private Label labelNombreDemarrageC;
        private Label labelTauxHeureC;
        private Label labelTauxDemarrageC;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private ProgressBar progressBar3;
        private Label labelProductionA;
        private Label labelProductionB;
        private Label labelProductionC;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem productionToolStripMenuItem;
        private ToolStripMenuItem démarrerToolStripMenuItem;
        private ToolStripMenuItem aToolStripMenuItem;
        private ToolStripMenuItem bToolStripMenuItem;
        private ToolStripMenuItem cToolStripMenuItem;
        private ToolStripMenuItem arrêterToolStripMenuItem;
        private ToolStripMenuItem aToolStripMenuItem1;
        private ToolStripMenuItem bToolStripMenuItem1;
        private ToolStripMenuItem cToolStripMenuItem1;
        private ToolStripMenuItem continuerToolStripMenuItem;
        private ToolStripMenuItem aToolStripMenuItem2;
        private ToolStripMenuItem bToolStripMenuItem2;
        private ToolStripMenuItem cToolStripMenuItem2;
    }
}