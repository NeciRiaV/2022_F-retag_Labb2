using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration.EnvironmentVariables;
using System.Collections;

namespace _2022_Företag_Labb2.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _appContext;
        public DepartmentRepository(AppDbContext appContext)
        {
            _appContext = appContext;
        }
        public IEnumerable<Department> GetAllDepartments
        {
            get
            {
                return _appContext.Departments;
            }
        }
        public async Task<ICollection> GetDepartmentById(int id)
        {
            var department = (from dep in _appContext.Departments
                              join staff in _appContext.Staffs
                              on dep.DepID equals staff.DepartmentID
                              where dep.DepID == id
                              select new
                              {
                                  depName = dep.DepartmentName,
                                  staffFirst = staff.FirstName,
                                  staffLast = staff.LastName,
                                  staffMail = staff.Email
                                  
                              }).ToListAsync();
            return await department;
            //var department = _appContext.Departments.FirstOrDefault(d => d.DepID == id);
            //if (department != null)
            //{
            //    var departmentStaff = (from dep in _appContext.Departments
            //                           join sta in _appContext.Staffs on dep.DepID equals sta.DepartmentID
            //                           orderby sta.ID
            //                           select new
            //                           {
            //                               First = sta.FirstName,
            //                               Last = sta.LastName
            //                           });
            //    foreach (var item in departmentStaff)
            //    {
            //        Console.WriteLine(item.First + " " + item.Last);
            //    }
            //    return department;
            //}
            //return null;
        }
    }
}
