using ClassLibraryAdditionneur;
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

        /**** version 1 ****/

        //public int sum = 0;

        //private void button0_Click(object sender, EventArgs e)
        //{
        //    this.textBoxAdditionneur.Text += "0+";
        //    sum += 0;
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    this.textBoxAdditionneur.Text += "1+";
        //    sum += 1;
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    this.textBoxAdditionneur.Text += "2+";
        //    sum += 2;
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    this.textBoxAdditionneur.Text += "3+";
        //    sum += 3;
        //}

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    this.textBoxAdditionneur.Text += "4+";
        //    sum += 4;
        //}

        //private void button5_Click(object sender, EventArgs e)
        //{
        //    this.textBoxAdditionneur.Text += "5+";
        //    sum += 5;
        //}

        //private void button6_Click(object sender, EventArgs e)
        //{
        //    this.textBoxAdditionneur.Text += "6+";
        //    sum += 6;
        //}

        //private void button7_Click(object sender, EventArgs e)
        //{
        //    this.textBoxAdditionneur.Text += "7+";
        //    sum += 7;
        //}

        //private void button8_Click(object sender, EventArgs e)
        //{
        //    this.textBoxAdditionneur.Text += "8+";
        //    sum += 8;
        //}

        //private void button9_Click(object sender, EventArgs e)
        //{
        //    this.textBoxAdditionneur.Text += "9+";
        //    sum += 9;
        //}

        //private void buttonCalculer_Click(object sender, EventArgs e)
        //{
        //    this.textBoxAdditionneur.Text += "= " + sum + "+";
        //}

        //private void buttonVider_Click(object sender, EventArgs e)
        //{
        //    sum = 0;
        //    this.textBoxAdditionneur.Text = "";
        //}


        /**** Version 2 ****/

        //public int sum = 0;

        //private void button_Click(object sender, EventArgs e)
        //{
        //    //caster le sender en Button b
        //    Button b = (Button)sender;
        //    this.textBoxAdditionneur.Text += b.Tag + "+";
        //    sum += int.Parse((string)b.Tag);
        //}

        //private void buttonCalculer_Click(object sender, EventArgs e)
        //{
        //    this.textBoxAdditionneur.Text += "= " + sum + "+";
        //}

        //private void buttonVider_Click(object sender, EventArgs e)
        //{
        //    sum = 0;
        //    this.textBoxAdditionneur.Text = "";
        //}

        /**** Version 3 ****/

        Additionneur sum = new Additionneur();

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            this.textBoxAdditionneur.Text += b.Tag + "+";
            sum.Additionner(Int32.Parse((string)b.Tag));
        }
        private void buttonCalculer_Click(object sender, EventArgs e)
        {
            this.textBoxAdditionneur.Text += sum;
        }

        private void buttonVider_Click(object sender, EventArgs e)
        {
            Additionneur sum = new Additionneur();
            this.textBoxAdditionneur.Text = "";
        }
    }
}
