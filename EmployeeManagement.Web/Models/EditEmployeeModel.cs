using EmployeeManagement.Models;
using EmployeeManagement.Models.CustomValidators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Models
{
    public class EditEmployeeModel
    {
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        public string FirstName { get; set; }

        public string LastName { get; set; }
        [EmailValidator(AllowedDomain = "gmail.com", ErrorMessage = "Domain should be gmail.com")]
      [Required]
        public string Email { get; set; }
        [CompareProperty("Email",ErrorMessage = "Mail adresses not same")]
        public string ConfirmEmail { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
       
        public Department Department { get; set; } = new Department() { };
        public int DepartmentId { get; set; }
        public string PhotoPath { get; set; }
    }
}
