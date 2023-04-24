using CLEmployees;
using Microsoft.EntityFrameworkCore;
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
using WFEmployees.Models;

namespace WFEmployees
{
    public partial class FormModifyEmployee : Form
    {
        Db302EmployeesContext dbContext;
        public FormModifyEmployee()
        {
            InitializeComponent();
        }

        public FormModifyEmployee(Employee _employee, Db302EmployeesContext _dbContext)
        {
            InitializeComponent();
            InitializeForm(_employee);
            //dbContext = new Db302EmployeesContext();
            dbContext = _dbContext;
            dbContext.Employees.Load();
        }

        private void InitializeForm(Employee _employee)
        {
            textBoxId.Text = _employee.EmpId.ToString();
            textBoxLastName.Text = _employee.EmpLastname.ToString();
            textBoxFirstName.Text = _employee.EmpFirstname.ToString();
            textBoxSalary.Text = _employee.EmpSalary.ToString();
            textBoxHireDate.Text = _employee.EmpHiredate.ToString();
            textBoxManagerId.Text = _employee.EmpManagerId.ToString();
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            WorkEmployee workEmployee = new WorkEmployee
                (
                    //int.Parse(textBoxId.Text),
                    textBoxLastName.Text,
                    textBoxFirstName.Text,
                    int.Parse(textBoxSalary.Text),
                    DateTime.Parse(textBoxHireDate.Text),
                    int.Parse(textBoxManagerId.Text)
                );

            employee = dbContext.Employees.Find(int.Parse(textBoxId.Text));

            employee.EmpFirstname = workEmployee.WorkEmpFirstName;
            employee.EmpLastname = workEmployee.WorkEmpLastName;
            employee.EmpSalary = workEmployee.WorkEmpSalary;
            employee.EmpHiredate = workEmployee.WorkEmpHireDate;
            employee.EmpManagerId = workEmployee.WorkEmpManagerId;

            dbContext.Update(employee);
            dbContext.SaveChanges();
            //FormEmployees.dataGridViewEmployees.Refresh();
            Close();

        }
    }
}
