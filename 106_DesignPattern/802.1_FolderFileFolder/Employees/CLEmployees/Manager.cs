using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLEmployees
{
    public class Manager : IEmployee
    {
        private string name;
        private decimal salary;
        private List<IEmployee> employees;

        public string Name { get => name; }
        public decimal Salary { get => salary; }

        public Manager(string name, decimal salary) 
        {
            this.name = name;
            this.salary = salary;  
            employees = new List<IEmployee>();
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void Add(Employee employee) 
        {
            employees.Add(employee);
        }
    }
}
