using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DemoBlazorServerApp.Models
{
    public class EmployeeModel
    {
        [Required(ErrorMessage = "Required feild")]
        [MinLength(2, ErrorMessage = "Minimum 2 characters")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Required feild")]
        [MinLength(2, ErrorMessage = "Minimum 2 characters")]
        public string LastName { get; set; }
        public string Image { get; set; }
        [Required(ErrorMessage = "Required feild")]
        [EmailAddress]
        public string Email { get; set; }
        public int id { get; set; }
        [Required(ErrorMessage = "Required feild")]
        public string PhoneNumber { get; set; }
        public int Departmentid { get; set; }
        [Required(ErrorMessage = "Required feild")]
        public Gender Gender { get; set; }
        [Required]
        public DepartmentModel Department { get; set; }
        [Required(ErrorMessage = "Required feild")]
        public DateTime DateOfBirth { get; set; }

    }

    public enum Gender
    {
        Male,
        Female,
        Other
    }
}
