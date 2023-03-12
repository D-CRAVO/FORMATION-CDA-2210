using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxBoutonsRadio
{
    public partial class FormCheckBoxRadioButton : Form
    {
        public FormCheckBoxRadioButton()
        {
            InitializeComponent();
        }

        private void textBoxOrigine_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxOrigine.Text))
            {
                groupBoxChoix.Enabled = true;
                textBoxModifie.Text = textBoxOrigine.Text;
            }
            else
            {
                groupBoxChoix.Enabled = false;
                textBoxModifie.Clear();
                groupBoxFondInitialiser();
                groupBoxCaracteresInitialiser();
                groupBoxCasseInitialiser();
            }
        }

        private void checkBoxFond_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFond.Checked)
            {
                groupBoxFond.Visible = true;
            }
            else
            {
                groupBoxFond.Visible = false;
                groupBoxFondInitialiser();
            }
        }

        private void checkBoxCaracteres_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCaracteres.Checked)
            {
                groupBoxCaracteres.Visible = true;
            }
            else
            {
                groupBoxCaracteres.Visible = false;
                groupBoxCaracteresInitialiser();
            }
        }

        private void checkBoxCasse_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCasse.Checked)
            {
                groupBoxCasse.Visible = true;
            }
            else
            {
                groupBoxCasse.Visible = false;
                groupBoxCasseInitialiser();
            }
        }

        private void radioButtonFondRouge_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFondRouge.Checked)
            {
                textBoxModifie.BackColor = Color.Red;
            }

        }

        private void radioButtonFondVert_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFondVert.Checked)
            {
                textBoxModifie.BackColor = Color.Green;
            }
        }

        private void radioButtonFondBleu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFondBleu.Checked)
            {
                textBoxModifie.BackColor = Color.Blue;
            }
        }
        private void groupBoxFondInitialiser()
        {
            checkBoxFond.Checked = false;
            radioButtonCaracteresRouge.Checked = false;
            radioButtonFondVert.Checked = false;
            radioButtonFondBleu.Checked = false;
            textBoxModifie.BackColor = Color.Empty;
        }

        private void radioButtonCaracteresRouge_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCaracteresRouge.Checked)
            {
                textBoxModifie.ForeColor = Color.Red;
            }
        }

        private void radioButtonCaracteresBlanc_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCaracteresBlanc.Checked)
            {
                textBoxModifie.ForeColor = Color.White;
            }
        }

        private void radioButtonCaracteresNoir_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCaracteresNoir.Checked)
            {
                textBoxModifie.ForeColor = Color.Black;
            }
        }

        private void groupBoxCaracteresInitialiser()
        {
            checkBoxCaracteres.Checked = false;
            textBoxModifie.ForeColor = Color.Empty;
            radioButtonCaracteresRouge.Checked = false;
            radioButtonCaracteresBlanc.Checked = false;
            radioButtonCaracteresNoir.Checked = false;
        }

        private void radioButtonMinuscules_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMinuscules.Checked)
            {
                textBoxModifie.Text = textBoxOrigine.Text.ToLower();
            }
        }

        private void radioButtonMajuscules_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMajuscules.Checked)
            {
                textBoxModifie.Text = textBoxOrigine.Text.ToUpper();
            }
        }

        private void groupBoxCasseInitialiser()
        {
            checkBoxCasse.Checked = false;
            textBoxModifie.Text = textBoxOrigine.Text;
        }
    }
}
