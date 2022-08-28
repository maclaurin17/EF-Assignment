using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFCoreFirst.Models
{
    
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public int Salary { get; set; }
       
        public Department? Department { get; set; }
    }

    public class Department
    {
        
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }
        public ICollection<Employee>? Employees { get; set; }

    }
}

