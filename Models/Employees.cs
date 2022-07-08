using System.ComponentModel.DataAnnotations;

namespace AppFactoryEmployees.Models
{
    public class Employees
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        [StringLength(50)]

        public string EmployeeFullName { get; set; }
        [Required]
        public int EmployeeNumber { get; set; }

        [Required]
        public int EmployeeAge { get; set; }
        [Required]

        public DateTime CreatedDate { get; set; }
        [Required]
        [StringLength(500)]

        public string Address { get; set; }




        
    }
}
