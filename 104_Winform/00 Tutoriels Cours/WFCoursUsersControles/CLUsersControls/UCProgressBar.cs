using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLUsersControls
{
    public partial class UCProgressBar : UserControl
    {
        public event EventHandler<EventArgs> MaximumProgressReached;
        public int Value { get => this.progressBar1.Value; set => this.progressBar1.Value = value; }
        public string TextButton
        {
            get { return button1.Text; }
            set { button1.Text = value; }
        }
        public UCProgressBar()
        {
            InitializeComponent();
            progressBar1.Value = 75;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.progressBar1.Value < this.progressBar1.Maximum)
            {
                this.progressBar1.Value++;
            }
            else
            {
                this.timer1.Enabled = false;
                if (MaximumProgressReached != null)
                {
                    MaximumProgressReached(this, new EventArgs());
                }
            }
        }
    }
}
