using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLEmployees
{
    internal class SalaryVisitor : IVisitor
    {
        private decimal totalSalary = 0;
        public void Visit(Employee employee)
        {
            totalSalary += employee.Salary;
        }

        public void Visit(Manager manager)
        {
            totalSalary += manager.Salary;
        }

        public decimal GetTotalSalary()
        {
            return totalSalary;
        }
    }
}
