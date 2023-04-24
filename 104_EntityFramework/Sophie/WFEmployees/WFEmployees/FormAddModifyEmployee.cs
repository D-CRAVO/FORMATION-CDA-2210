using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFEmployees.Data;
using CLEmployees;
using Microsoft.EntityFrameworkCore;

namespace WFEmployees
{
    public partial class FormAddModifyEmployee : Form
    {
        Db302EmployeesContext dbContext;
        EnumOpeningMode openingMode;
        public FormAddModifyEmployee()
        {
            InitializeComponent();
        }

        public FormAddModifyEmployee(Db302EmployeesContext _dbContext, EnumOpeningMode mode)
        {
            InitializeComponent();
            dbContext = _dbContext;
            openingMode = mode;

            //dbContext.Employees.Load();
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

        }
    }
}
