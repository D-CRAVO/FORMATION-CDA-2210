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
            //dbContext.Employees.

            dataGridViewEmployees.DataSource = dbContext.Employees.Local.ToBindingList();
        }
    }
}
