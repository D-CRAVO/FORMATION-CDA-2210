using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employees.Models
{
    [Table ("tbl_employees")]
    public class Employee
    {
        [Key]
        [Column ("id")]
        public int EmployeeId { get; set; }
        [Required]
        [Column ("employee_name")]
        public string Fullname { get; set; }
        [Required]
        [Column ("employee_salary")]
        public int Salary { get; set; }
        [Required]
        [Column ("employee_age")]
        public int Age { get; set; }  
        
    }
}
