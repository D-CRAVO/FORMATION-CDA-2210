namespace CLEmployees
{
    public class Employee : IEmployee
    {
        private string name;
        private decimal salary;
        public string Name { get => name; }
        public decimal Salary { get => salary; }
        public Employee(string name, decimal salary) 
        { 
            this.name = name;
            this.salary = salary;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}