﻿using ClassLibraryAdditionneur;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAdditionneur
{
    public partial class FormAdditionneur : Form
    {
        public FormAdditionneur()
        {
            InitializeComponent();
        }



        
        Additionneur sum = new Additionneur();
       
        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            this.textBoxAdditionneur.Text += b.Tag + "+";
            sum.Additionner(Int32.Parse((string)b.Tag));
        }
        

        /*
        public int sum = 0;
        private void button_Click(object sender, EventArgs e)
        {
            //caster le sender en Button b
            Button b = (Button)sender;
            this.textBoxAdditionneur.Text += b.Tag + "+";
            sum += int.Parse((string)b.Tag);
        }
       

        /*
        private void button0_Click(object sender, EventArgs e)
        {
            this.textBoxAdditionneur.Text += "0+";
            somme += 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBoxAdditionneur.Text += "1+";
            somme += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBoxAdditionneur.Text += "2+";
            somme += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBoxAdditionneur.Text += "3+";
            somme += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBoxAdditionneur.Text += "4+";
            somme += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBoxAdditionneur.Text += "5+";
            somme += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBoxAdditionneur.Text += "6+";
            somme += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBoxAdditionneur.Text += "7+";
            somme += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBoxAdditionneur.Text += "8+";
            somme += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBoxAdditionneur.Text += "9+";
            somme += 9;
        }
        */
        private void buttonCalculer_Click(object sender, EventArgs e)
        {
            this.textBoxAdditionneur.Text += " =" + sum + "+";
        }

        private void buttonVider_Click(object sender, EventArgs e)
        {
            Additionneur sum = new Additionneur();
            this.textBoxAdditionneur.Text = "";
        }
    }
}
