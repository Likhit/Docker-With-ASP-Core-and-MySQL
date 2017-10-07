using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContainerProd.Models
{
    public class Student
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public int DepartmentID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set;}

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public Department Department { get; set; }
    }
}