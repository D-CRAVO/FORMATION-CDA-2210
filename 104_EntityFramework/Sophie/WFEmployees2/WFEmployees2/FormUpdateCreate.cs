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

namespace WFEmployees2
{
    public partial class FormUpdateCreate : Form
    {
        Db302EmployeesContext dbContext;
        
        public FormUpdateCreate()
        {
            InitializeComponent();
        }

        public FormUpdateCreate(EnumUpdateCreate _mode, Db302EmployeesContext _context)
        {
            InitializeComponent();
            if (_mode == EnumUpdateCreate.Create)
            {
                buttonValidate.Text = _mode.ToString();
                dbContext = _context;
                CreateEmployee();
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
    }
}
