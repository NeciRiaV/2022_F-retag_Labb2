using System.ComponentModel.DataAnnotations;

namespace _2022_Företag_Labb2.Models
{
    public class Staff
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        [StringLength(15,MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Adress { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string ZipCode { get; set; }

        [Required]
        public decimal Salary { get; set; }
        public string? ImageUrl { get; set; }
        public int DepartmentID { get; set; }
        public Department? Department { get; set; }
    }
}
