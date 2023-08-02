using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLEmployees
{
    public class EmployeeProxy : IEmployee
    {
        private IEmployee realEmployee;
        public EmployeeProxy(IEmployee realEmployee) 
        {
            this.realEmployee = realEmployee;
        }

        public void Accept(IVisitor visitor)
        {
            if (visitor is SalaryVisitor)
            {
                Console.WriteLine("You don't have access");
            }
            else
            {
                realEmployee.Accept(visitor);
            }
        }
    }
}
