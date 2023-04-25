using CLEmployees;
using Google.Protobuf.WellKnownTypes;
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
            if
                (
                    CLEmployees.Control.Name(textBoxLastName.Text)
                    && CLEmployees.Control.Name(textBoxFirstName.Text)
                    && CLEmployees.Control.Salary(textBoxSalary.Text)
                    && CLEmployees.Control.HireDate(textBoxHireDate.Text)
                    && CLEmployees.Control.ManagerId(textBoxManagerId.Text)
                )
            {
                employee.EmpLastname = textBoxLastName.Text;
                employee.EmpFirstname = textBoxFirstName.Text;
                employee.EmpHiredate = DateTime.Parse(textBoxHireDate.Text);
                employee.EmpSalary = int.Parse(textBoxSalary.Text);
                if (textBoxManagerId.Text == String.Empty)
                {
                    employee.EmpManagerId = null;
                }
                else
                {
                    employee.EmpManagerId = int.Parse(textBoxManagerId.Text);
                }
                dbContext.Employees.Add(employee);
                dbContext.SaveChanges();
                Close();
            }
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

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            if (CLEmployees.Control.Name(textBoxLastName.Text) || textBoxLastName.Text == string.Empty)
            {
                errorProviderLastname.SetError(textBoxLastName, string.Empty);
            }
            else
            {
                errorProviderLastname.SetError(textBoxLastName, "Invalid Lastname");
            }
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            if (CLEmployees.Control.Name(textBoxFirstName.Text) || textBoxLastName.Text == string.Empty)
            {
                errorProviderFirstname.SetError(textBoxFirstName, string.Empty);
            }
            else
            {
                errorProviderFirstname.SetError(textBoxFirstName, "Invalid Firstname");
            }
        }

        private void textBoxSalary_TextChanged(object sender, EventArgs e)
        {
            if (CLEmployees.Control.Salary(textBoxSalary.Text) || textBoxSalary.Text == string.Empty)
            {
                errorProviderSalary.SetError(textBoxSalary, string.Empty);
            }
            else
            {
                errorProviderSalary.SetError(textBoxSalary, "Invalid Salary");
            }
        }

        private void textBoxHireDate_TextChanged(object sender, EventArgs e)
        {
            if (CLEmployees.Control.HireDate(textBoxHireDate.Text))
            {
                errorProviderHiredate.SetError(textBoxHireDate, string.Empty);
            }
            else
            {
                errorProviderHiredate.SetError(textBoxHireDate, "Invalid HireDate");
            }
        }

        private void textBoxManagerId_TextChanged(object sender, EventArgs e)
        {
            if (CLEmployees.Control.ManagerId(textBoxManagerId.Text))
            {
                errorProviderManagerId.SetError(textBoxManagerId, string.Empty);
            }
            else
            {
                errorProviderManagerId.SetError(textBoxManagerId, "Invalid Value");
            }
        }
    }
}
