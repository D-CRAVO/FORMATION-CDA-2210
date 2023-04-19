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
            Employee employee = new Employee();
            int id;
            bool idOk = int.TryParse(textBoxId.Text, out id);
            if (idOk )
            {
                employee.EmpId = id;
            }
        }
    }
}
