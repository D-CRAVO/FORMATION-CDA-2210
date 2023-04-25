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
    public partial class FormEmployees : Form
    {
        Db302EmployeesContext dbContext;

        public FormEmployees()
        {

            InitializeComponent();
            dbContext = new Db302EmployeesContext();
            dbContext.Employees.Load();

            dataGridViewEmployees.DataSource = dbContext.Employees.Local.ToBindingList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            if (dataGridViewEmployees.SelectedRows.Count > 0)
            {
                employee = dbContext.Employees.Find(int.Parse(dataGridViewEmployees[0, dataGridViewEmployees.CurrentRow.Index].Value.ToString()));
                dbContext.Employees.Remove(employee);
                dbContext.SaveChanges();
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            FormUpdateCreate form = new FormUpdateCreate(EnumUpdateCreate.Create, dbContext, null);
            form.ShowDialog();
            dataGridViewEmployees.Refresh();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            if (dataGridViewEmployees.SelectedRows.Count > 0)
            {
                employee = dbContext.Employees.Find(int.Parse(dataGridViewEmployees[0, dataGridViewEmployees.CurrentRow.Index].Value.ToString()));
                FormUpdateCreate form = new FormUpdateCreate(EnumUpdateCreate.Update, dbContext, employee);
                form.ShowDialog();
                dataGridViewEmployees.Refresh();
            }
        }
    }
}
