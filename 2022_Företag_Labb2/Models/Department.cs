using System.ComponentModel.DataAnnotations;

namespace _2022_Företag_Labb2.Models
{
    public class Department
    {
        [Key]
        public int DepID { get; set; }
        [Required]
        public string DepartmentName { get; set; }

    }
}
