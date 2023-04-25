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
using WFEmployees2.Data;
using WFEmployees2.Models;
using CLEmployees;

namespace WFEmployees2
{
    public partial class FormUpdateCreate : Form
    {
        private Db302EmployeesContext dbContext;
        private WorkEmployee workEmployee;
        private EnumUpdateCreate openingMode;

        public FormUpdateCreate()
        {
            InitializeComponent();
        }

        public FormUpdateCreate(EnumUpdateCreate _mode, Db302EmployeesContext _context, Employee? _employee)
        {
            InitializeComponent();
            openingMode = _mode;
            dbContext = _context;
            switch (_mode)
            {
                case EnumUpdateCreate.Create:
                    buttonValidate.Text = openingMode.ToString();
                    textBoxId.Visible = false;
                    labelId.Visible = false;
                    buttonClear.Visible = false;

                    break;
                case EnumUpdateCreate.Update:
                    buttonValidate.Text = openingMode.ToString();
                    workEmployee = new WorkEmployee
                        (
                            _employee.EmpId,
                            _employee.EmpLastname,
                            _employee.EmpFirstname,
                            _employee.EmpSalary,
                            _employee.EmpHiredate,
                            _employee.EmpManagerId
                        );
                    InitializeForm();
                    break;
            }
        }

        private void CreateEmployee()
        {
            Employee employee = new Employee();
            employee.EmpLastname = textBoxLastName.Text;
            employee.EmpFirstname = textBoxFirstName.Text;
            employee.EmpHiredate = DateTime.Parse(textBoxHireDate.Text);
            employee.EmpSalary = int.Parse(textBoxSalary.Text);
            employee.EmpManagerId = int.Parse(textBoxManagerId.Text);
            dbContext.Employees.Add(employee);
            dbContext.SaveChanges();
            Close();
        }

        private void UpdateEmployee()
        {
            Employee employee = new Employee();
            employee = dbContext.Employees.Find(workEmployee.Id);
            employee.EmpLastname = textBoxLastName.Text;
            employee.EmpFirstname = textBoxFirstName.Text;
            employee.EmpHiredate = DateTime.Parse(textBoxHireDate.Text);
            employee.EmpSalary = int.Parse(textBoxSalary.Text);
            employee.EmpManagerId = int.Parse(textBoxManagerId.Text);
            dbContext.Employees.Update(employee);
            dbContext.SaveChanges();
            Close();
        }

        private void InitializeForm()
        {
            textBoxId.Text = workEmployee.Id.ToString();
            textBoxLastName.Text = workEmployee.Lastname;
            textBoxFirstName.Text = workEmployee.Firstname;
            textBoxSalary.Text = workEmployee.Salary.ToString();
            textBoxHireDate.Text = workEmployee.Hiredate.ToString();
            textBoxManagerId.Text = workEmployee.ManagerId.ToString();
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            switch (openingMode)
            {
                case EnumUpdateCreate.Create:
                    CreateEmployee();
                    break;
                case EnumUpdateCreate.Update:
                    UpdateEmployee();
                    break;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxLastName.Clear();
            textBoxFirstName.Clear();
            textBoxSalary.Clear();
            textBoxHireDate.Clear();
            textBoxManagerId.Clear();
        }
    }
}
