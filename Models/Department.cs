using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContainerProd.Models
{
    public class Department
    {
        [Required]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}