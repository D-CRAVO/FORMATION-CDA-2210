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
        
        Addition monAddition;

        public FormAdditionneur()
        {
            InitializeComponent();
            monAddition = new Addition();
        }

        #region version1

        /**** version 1 ****/

        //public int result = 0;

        //private void button0_Click(object sender, EventArgs e)
        //{
        //    this.textBoxAdditionneur.Text += "0+";
        //    result += 0;
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    this.textBoxAdditionneur.Text += "1+";
        //    result += 1;
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    this.textBoxAdditionneur.Text += "2+";
        //    result += 2;
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    this.textBoxAdditionneur.Text += "3+";
        //    result += 3;
        //}

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    this.textBoxAdditionneur.Text += "4+";
        //    result += 4;
        //}

        //private void button5_Click(object sender, EventArgs e)
        //{
        //    this.textBoxAdditionneur.Text += "5+";
        //    result += 5;
        //}

        //private void button6_Click(object sender, EventArgs e)
        //{
        //    this.textBoxAdditionneur.Text += "6+";
        //    result += 6;
        //}

        //private void button7_Click(object sender, EventArgs e)
        //{
        //    this.textBoxAdditionneur.Text += "7+";
        //    result += 7;
        //}

        //private void button8_Click(object sender, EventArgs e)
        //{
        //    this.textBoxAdditionneur.Text += "8+";
        //    result += 8;
        //}

        //private void button9_Click(object sender, EventArgs e)
        //{
        //    this.textBoxAdditionneur.Text += "9+";
        //    result += 9;
        //}

        //private void buttonCalculer_Click(object sender, EventArgs e)
        //{
        //    this.textBoxAdditionneur.Text += "= " + result + "+";
        //}

        //private void buttonVider_Click(object sender, EventArgs e)
        //{
        //    result = 0;
        //    this.textBoxAdditionneur.Text = "";
        //}
        #endregion

        #region version2
        /**** Version 2 ****/

        //public int result = 0;

        //private void button_Click(object sender, EventArgs e)
        //{
        //    //caster le sender en Button b
        //    Button b = (Button)sender;
        //    this.textBoxAdditionneur.Text += b.Tag + "+";
        //    result += int.Parse((string)b.Tag);
        //}

        //private void buttonCalculer_Click(object sender, EventArgs e)
        //{
        //    this.textBoxAdditionneur.Text += "= " + result + "+";
        //}

        //private void buttonVider_Click(object sender, EventArgs e)
        //{
        //    result = 0;
        //    this.textBoxAdditionneur.Text = "";
        //}
        #endregion

        /**** Version 3 ****/

        /// <summary>
        /// Récupère le tag du bouton sur lequel on a cliqué.
        /// Enregitre ce tag sous forme d'entier dans l'objet result.
        /// </summary>
        /// <param name="sender">Le bouton cliqué</param>
        /// <param name="e"></param>
        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            this.textBoxAdditionneur.Text += $"{b.Tag} + ";
            monAddition.Enregister(Int32.Parse((string)b.Tag));
        }

        /// <summary>
        /// Affiche le résultat de l'addition dans la textBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalculer_Click(object sender, EventArgs e)
        {
            this.textBoxAdditionneur.Text += $" = {monAddition.GetResultat()} + ";
        }

        /// <summary>
        /// Initialise l'objet.
        /// Nettoie la textBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVider_Click(object sender, EventArgs e)
        {
            monAddition = new Addition();
            this.textBoxAdditionneur.Text = "";
        }
    }
}
