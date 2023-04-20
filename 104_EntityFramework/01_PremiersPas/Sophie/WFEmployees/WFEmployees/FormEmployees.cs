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
using CLEmployees;
using static WFEmployees.FormNewEmployee;

namespace WFEmployees
{
    public partial class FormEmployees : Form
    {
        Db302EmployeesContext dbContext;
        public FormEmployees()
        {
            InitializeComponent();
            dbContext = new Db302EmployeesContext();
            dbContext.Employees.Load<Employee>();

            dataGridViewEmployees.DataSource = dbContext.Employees.Local.ToBindingList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormNewEmployee form = new FormNewEmployee();
            Employee employee = new Employee();

            //Employee employee = new Employee();
            //if (textBoxFirstName != null && textBoxLastName != null)
            //{
            //    employee.EmpLastname = textBoxLastName.Text;
            //    employee.EmpFirstname = textBoxFirstName.Text;

            //    if (textBoxManagerId != null)
            //    {
            //        int id;
            //        bool idOk = int.TryParse(textBoxManagerId.Text, out id);
            //        if (idOk)
            //        {
            //            if (IdVerification(id))
            //            {
            //                employee.EmpManagerId = id;
            //            }
            //        }
            //    }
            //    dbContext.Employees.Add(employee);
            //}
        }

        private bool IdVerification(int _id)
        {
            foreach (var item in dbContext.Employees) 
            {
                if (item.EmpId == _id)
                { return true; }
            }
            return false;
        }
    }
}
