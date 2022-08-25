using EmployeeManagement.Models.CustomValidators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
         [EmailValidator(AllowedDomain = "gmail.com",ErrorMessage ="Domain should be gmail.com")]
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
     
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public string PhotoPath { get; set; }
        
    }
}
