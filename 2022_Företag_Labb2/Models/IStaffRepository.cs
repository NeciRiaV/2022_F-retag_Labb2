using System.Collections;

namespace _2022_Företag_Labb2.Models
{
    public interface IStaffRepository
    {
        ICollection GetAllStaff();
        Staff GetStaffById(Guid id);
        Task<Staff> Add(Staff staff);
        Task<Staff> Update(Staff staff);
        Task<Staff> Delete(Guid id);
    }
}
