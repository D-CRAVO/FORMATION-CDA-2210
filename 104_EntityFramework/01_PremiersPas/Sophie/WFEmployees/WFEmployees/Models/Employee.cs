using System;
using System.Collections.Generic;

namespace WFEmployees.Models;

public partial class Employee
{
    public int EmpId { get; set; }

    public string EmpLastname { get; set; } = null!;

    public string EmpFirstname { get; set; } = null!;

    public int EmpSalary { get; set; }

    public DateTime EmpHiredate { get; set; }

    public int? EmpManagerId { get; set; }

    public virtual Employee? EmpManager { get; set; }

    public virtual ICollection<Employee> InverseEmpManager { get; set; } = new List<Employee>();
}
