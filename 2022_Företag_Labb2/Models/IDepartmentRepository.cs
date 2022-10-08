using System.Collections;

namespace _2022_Företag_Labb2.Models
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments { get; }
        Task<ICollection> GetDepartmentById(int id);
    }
}
