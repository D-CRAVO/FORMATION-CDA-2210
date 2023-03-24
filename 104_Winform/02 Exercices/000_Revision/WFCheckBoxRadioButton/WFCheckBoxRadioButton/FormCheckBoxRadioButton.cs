using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCheckBoxRadioButton
{
    public partial class FormCheckBoxRadioButton : Form
    {
        public FormCheckBoxRadioButton()
        {
            InitializeComponent();
        }

        public FormCheckBoxRadioButton(string _texte)
        {
            InitializeComponent();
            InitializeComponent2(_texte);
        }

        public void InitializeComponent2(string _texte)
        {
            textBoxTexteOrigine.Text = _texte;  
        }

        private void textBoxTexteOrigine_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxTexteOrigine.Text))
            {
                groupBoxChoix.Enabled = true;
                if (radioButtonMinuscules.Checked)
                {
                    labelTexteModifie.Text = textBoxTexteOrigine.Text.ToLower();
                }
                else if (radioButtonMajuscules.Checked) 
                {
                    labelTexteModifie.Text = textBoxTexteOrigine.Text.ToUpper();
                }
                else
                {
                    labelTexteModifie.Text = textBoxTexteOrigine.Text;
                }
            }
            else
            {
                groupBoxChoix.Enabled = false;

            }
        }

        private void initialisationGroupBoxFond()
        {
            radioButtonFondRouge.Checked = false;
            radioButtonFondVert.Checked = false;
            radioButtonFondBleu.Checked = false;
            labelTexteModifie.BackColor = Color.Empty;
        }

        private void checkBoxCouleurFond_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCouleurFond.Checked)
            {
                groupBoxFond.Visible = true;
            }
            else
            {
                groupBoxFond.Visible = false;
                radioButtonFondRouge.Checked = false;
                radioButtonFondVert.Checked = false;
                radioButtonFondBleu.Checked = false;
            }
        }

        private void checkBoxCouleurCaracteres_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCouleurCaracteres.Checked)
            {
                groupBoxCaracteres.Visible = true;
            }
            else
            {
                groupBoxCaracteres.Visible = false;
                radioButtonCaracteresRouge.Checked = false;
                radioButtonCaracteresBlanc.Checked = false;
                radioButtonCaracteresNoir.Checked = false;
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
                radioButtonMinuscules.Checked = false;
                radioButtonMajuscules.Checked = false;
            }
        }

        #region Couleur de fond

        private void radioButtonFondRouge_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFondRouge.Checked)
            {
                labelTexteModifie.BackColor = Color.Red;
            }
            else
            {
                labelTexteModifie.BackColor = Color.Empty;
            }
        }

        private void radioButtonFondVert_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFondVert.Checked)
            {
                labelTexteModifie.BackColor = Color.Green;
            }
            else
            {
                labelTexteModifie.BackColor = Color.Empty;
            }
        }

        private void radioButtonFondBleu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFondBleu.Checked)
            {
                labelTexteModifie.BackColor = Color.Blue;
            }
            else
            {
                labelTexteModifie.BackColor = Color.Empty;
            }
        }
        #endregion

        #region Couleur des caractères

        private void radioButtonCaracteresRouge_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCaracteresRouge.Checked)
            {
                labelTexteModifie.ForeColor = Color.Red;
            }
            else
            {
                labelTexteModifie.ForeColor = Color.Empty;
            }
        }

        private void radioButtonCaracteresBlanc_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCaracteresBlanc.Checked)
            {
                labelTexteModifie.ForeColor = Color.White;
            }
            else
            {
                labelTexteModifie.ForeColor = Color.Empty;
            }
        }

        private void radioButtonCaracteresNoir_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCasse.Checked)
            {
                labelTexteModifie.ForeColor = Color.Black;
            }
            else
            {
                labelTexteModifie.ForeColor = Color.Empty;
            }
        }

        #endregion

        #region Casse

        private void radioButtonMinuscules_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMinuscules.Checked)
            {
                labelTexteModifie.Text = textBoxTexteOrigine.Text.ToLower();
            }
            else
            {
                labelTexteModifie.Text = textBoxTexteOrigine.Text;
            }
        }

        private void radioButtonMajuscules_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMajuscules.Checked)
            {
                labelTexteModifie.Text = textBoxTexteOrigine.Text.ToUpper();
            }
            else
            {
                labelTexteModifie.Text = textBoxTexteOrigine.Text;
            }
        }
        #endregion
    }
}
