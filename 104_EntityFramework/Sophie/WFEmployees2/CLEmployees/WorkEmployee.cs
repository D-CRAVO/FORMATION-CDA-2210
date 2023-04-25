using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLEmployees
{
    public class WorkEmployee
    {
        private int? id;
        private string lastname;
        private string firstname;
        private int salary;
        private DateTime hiredate;
        private int? managerId;

        public int? Id { get { return id; } set { id = value; } }
        public string Lastname { get {  return lastname; } set {  lastname = value; } }
        public string Firstname { get { return firstname; } set {  firstname = value; } }
        public int Salary { get {  return salary; } set {  salary = value; } }
        public DateTime Hiredate { get {  return hiredate; } set {  hiredate = value; } }
        public int? ManagerId { get {  return managerId; } set {  managerId = value; } }

        public WorkEmployee(string _lastname, string _firstname, int _salary, DateTime _hiredate, int? _managerId)
        {
            lastname = _lastname;
            firstname = _firstname;
            salary = _salary;
            hiredate = _hiredate;
            managerId = _managerId;
        }

        public WorkEmployee(int _id, string _lastname, string _firstname, int _salary, DateTime _hiredate, int? _managerId) 
        {
            id = _id;
            lastname = _lastname;
            firstname = _firstname;
            salary = _salary;
            hiredate = _hiredate;
            managerId = _managerId;
        }
    }
}
