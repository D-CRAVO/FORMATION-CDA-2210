namespace CLEmployees
{
    public class WorkEmployee
    {
        private int workEmpId;
        private string workEmpLastName;
        private string workEmpFirstName;
        private int workEmpSalary;
        private DateTime workEmpHireDate;
        private int workEmpManagerId;

        public int WorkEmpId { get { return workEmpId; } }
        public string WorkEmpLastName { get { return workEmpLastName; } set { workEmpLastName = value; } }
        public string WorkEmpFirstName { get { return workEmpFirstName; } set { workEmpFirstName = value; } }
        public int WorkEmpSalary { get { return workEmpSalary; } set { workEmpSalary = value; } }
        public DateTime WorkEmpHireDate { get { return workEmpHireDate; } set { workEmpHireDate = value; } }
        public int WorkEmpManagerId { get { return workEmpManagerId; } set { workEmpManagerId = value; } }  

        public WorkEmployee(/*int _empId,*/ string _empLastName, string _empFirstName, int _empSalary, DateTime _empHireDate, int _empManagerId) 
        {
            //workEmpId = _empId;
            workEmpLastName = _empLastName;
            workEmpFirstName = _empFirstName;
            workEmpSalary = _empSalary;
            workEmpHireDate = _empHireDate;
            workEmpManagerId = _empManagerId;
        }
    }
}