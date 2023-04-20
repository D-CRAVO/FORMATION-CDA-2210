using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLEmployees;
using Microsoft.EntityFrameworkCore;
using WFEmployees.Data;

namespace WFEmployees
{
    public partial class FormNewEmployee : Form
    {
        private WorkEmployee workEmployee;

        public FormNewEmployee()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxLastName.Clear();
            textBoxFirstName.Clear();
            textBoxSalary.Clear();
            textBoxHireDate.Clear();
            textBoxManagerId.Clear();
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            workEmployee = new WorkEmployee
                (
                    textBoxLastName.Text,
                    textBoxFirstName.Text,
                    int.Parse(textBoxSalary.Text),
                    DateOnly.Parse(textBoxHireDate.Text),
                    int.Parse(textBoxManagerId.Text)
                );
        }
    }
}
