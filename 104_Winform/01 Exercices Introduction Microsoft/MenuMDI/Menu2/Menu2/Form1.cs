using ValidationSaisie2;
using WinFormsAdditionneur;
using WinFormsApp3;

namespace Menu2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newMDIChild = new Form2();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected void MDIChildNew_Click(object sender, System.EventArgs e)
        {


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //Form3 newMDIChild = new Form3();
            //// Set the Parent Form of the Child window.
            //newMDIChild.MdiParent = this;
            //// Display the new form.
            //newMDIChild.Show();
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newMDIChild = new Form3();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void additionneurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdditionneur formAdditionneur = new FormAdditionneur();
            formAdditionneur.MdiParent = this;
            formAdditionneur.Show();
        }

        private void validationSaisieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormulaireSaisie2 formulaireSaisie2 = new FormulaireSaisie2();
            formulaireSaisie2.MdiParent = this;
            formulaireSaisie2.Show();
        }
    }
}