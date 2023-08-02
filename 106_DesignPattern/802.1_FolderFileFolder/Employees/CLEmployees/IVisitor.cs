using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLEmployees
{
    public interface IVisitor
    {
        void Visit(Employee employee);
        void Visit(Manager manager);
    }
}
