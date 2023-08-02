using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLEmployees
{
    public class DetailsVisitor : IVisitor
    {
        public void Visit(Employee employee)
        {
            Console.WriteLine($"Employee: {employee.Name}, Salary: {employee.Salary}");
        }

        public void Visit(Manager manager)
        {
            Console.WriteLine($"Employee: {manager.Name}, Salary: {manager.Salary}");
        }
    }
}
