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
using WFEmployees.Models;

namespace WFEmployees
{
    public partial class FormNewEmployee : Form
    {
        private WorkEmployee workEmployee;
        private Db302EmployeesContext dbContext;

        public FormNewEmployee()
        {
            InitializeComponent();
            dbContext = new Db302EmployeesContext();
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
            Employee employee = new Employee();
            workEmployee = new WorkEmployee
                (
                    textBoxLastName.Text,
                    textBoxFirstName.Text,
                    int.Parse(textBoxSalary.Text),
                    DateTime.Parse(textBoxHireDate.Text),
                    int.Parse(textBoxManagerId.Text)
                );

            employee.EmpFirstname = workEmployee.WorkEmpFirstName;
            employee.EmpLastname = workEmployee.WorkEmpLastName;
            employee.EmpSalary = workEmployee.WorkEmpSalary;
            employee.EmpHiredate = workEmployee.WorkEmpHireDate;
            employee.EmpManagerId = workEmployee.WorkEmpManagerId;

            dbContext.Add(employee);
            dbContext.SaveChanges();
            Close();
        }
    }
}
