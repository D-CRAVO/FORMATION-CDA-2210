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
        Db302EmployeesContext dbContext;
        WorkEmployee workEmployee;
        
        public FormUpdateCreate()
        {
            InitializeComponent();
        }

        public FormUpdateCreate(EnumUpdateCreate _mode, Db302EmployeesContext _context, Employee? _employee)
        {
            InitializeComponent();
            dbContext = _context;
            switch (_mode)
            {
                case EnumUpdateCreate.Create:
                    buttonValidate.Text = _mode.ToString();
                    CreateEmployee();
                    break;
                case EnumUpdateCreate.Update:
                    buttonValidate.Text = _mode.ToString();
                    UpdateEmployee(_employee);
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
        }

        private void UpdateEmployee(Employee _employee)
        {
            Employee employee = new Employee();
            employee = dbContext.Employees.Find(_employee.EmpId);
            employee.EmpLastname = textBoxLastName.Text;
            employee.EmpFirstname = textBoxFirstName.Text;
            employee.EmpHiredate = DateTime.Parse(textBoxHireDate.Text);
            employee.EmpSalary = int.Parse(textBoxSalary.Text);
            employee.EmpManagerId = int.Parse(textBoxManagerId.Text);
            dbContext.Employees.Update(employee);
            dbContext.SaveChanges();

        }
    }
}
