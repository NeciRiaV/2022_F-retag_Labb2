using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace _2022_Företag_Labb2.Models
{
    public class StaffRepository : IStaffRepository
    {
        private readonly AppDbContext _appContext;
        public StaffRepository(AppDbContext appContext)
        {
            _appContext = appContext;
        }

        //GET ALL STAFF
        public ICollection GetAllStaff()
        {
                var employee = (from sta in _appContext.Staffs
                                join dep in _appContext.Departments
                                on sta.DepartmentID equals dep.DepID
                                select new
                                {
                                    id = sta.ID,
                                    firstName = sta.FirstName,
                                    lastName = sta.LastName,
                                    email = sta.Email,
                                    phoneNumber = sta.PhoneNumber,
                                    adress = sta.Adress,
                                    city = sta.City,
                                    zipCode = sta.ZipCode,
                                    salary = sta.Salary,
                                    imageUrl = sta.ImageUrl,
                                    departmentId = sta.DepartmentID,
                                    departmentName = dep.DepartmentName,
                                }).ToList();
                return employee;


                //var department = (from dep in _appContext.Departments
                //                  join staff in _appContext.Staffs
                //                  on dep.DepID equals staff.DepartmentID
                //                  where dep.DepID == id
                //                  select new
                //                  {
                //                      depName = dep.DepartmentName,
                //                      staffFirst = staff.FirstName,
                //                      staffLast = staff.LastName,
                //                      staffMail = staff.Email

                //                  }).ToListAsync();
                //return await department;
        }

        //GET SINGLE EMPLOYEE
        public Staff GetStaffById(Guid id)
        {
            return _appContext.Staffs.FirstOrDefault(s => s.ID == id);
        }

        //ADD EMPLOYEE
        public async Task<Staff> Add(Staff staff)
        {
            staff.ID = Guid.NewGuid();
            var result = await _appContext.Staffs.AddAsync(staff);
            await _appContext.SaveChangesAsync();
            return result.Entity;
        }

        //EDIT / UPDATE EMPLOYEE
        public async Task<Staff> Update(Staff staff)
        {
            var emp = await _appContext.Staffs.FirstOrDefaultAsync(s => s.ID == staff.ID);
            if (emp != null)
            {
                emp.FirstName = staff.FirstName;
                emp.LastName = staff.LastName;
                emp.Email = staff.Email;
                emp.PhoneNumber = staff.PhoneNumber;
                emp.Adress = staff.Adress;
                emp.City = staff.City;
                emp.ZipCode = staff.ZipCode;
                emp.Salary = staff.Salary;
                emp.DepartmentID = staff.DepartmentID;

                await _appContext.SaveChangesAsync();
                return emp;
            }
            return null;
        }

        //DELETE EMPLOYEE
        public async Task<Staff> Delete(Guid id)
        {
            var deleteEmployee = await _appContext.Staffs.FindAsync(id);
            if (deleteEmployee != null)
            {
                _appContext.Staffs.Remove(deleteEmployee);
                await _appContext.SaveChangesAsync();
            }
            return null;
        }



    }
}
