using _2022_Företag_Labb2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore;

namespace _2022_Företag_Labb2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StaffController : Controller
    {
        private readonly AppDbContext _appContext;

        public StaffController(AppDbContext appContext)
        {
            this._appContext = appContext;
        }

        //GET ALL STAFF
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var staff = await _appContext.Staffs.ToListAsync();
            return Ok(staff);
        }

        //GET SINGEL EMPLOYEE
        [HttpGet]
        [Route("{id:guid}")]
        [ActionName("GetSingleEmployee")]
        public async Task<IActionResult> GetSingelEmployee([FromRoute]Guid id)
        {
            var employee = await _appContext.Staffs.FirstOrDefaultAsync(emp => emp.ID == id);
            if (employee != null)
            {
                return Ok(employee);
            }
            return NotFound("Employee NotFound");
        }

        //ADD NEW EMPLOYEE
        [HttpPost]
        public async Task<IActionResult> AddEmployee([FromBody]Staff staff)
        {
            staff.ID = Guid.NewGuid();
            await _appContext.Staffs.AddAsync(staff);
            await _appContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSingelEmployee), new { id = staff.ID }, staff);
        }

        //UPDATE / EDIT EMPLOYEE
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> EditEmployee([FromRoute]Guid id, Staff staff)
        {
            var editEmployee = await _appContext.Staffs.FirstOrDefaultAsync(emp => emp.ID == id);
            if (editEmployee != null)
            {
                editEmployee.FirstName = staff.FirstName;
                editEmployee.LastName = staff.LastName;
                editEmployee.Email = staff.Email;
                editEmployee.PhoneNumber = staff.PhoneNumber;
                editEmployee.Adress = staff.Adress;
                editEmployee.City = staff.City;
                editEmployee.ZipCode = staff.ZipCode;
                editEmployee.Salary = staff.Salary;
                editEmployee.Department = staff.Department;

                await _appContext.SaveChangesAsync();
                return Ok(editEmployee);
            }
            return NotFound("Employee Not Found");
        }

        //DELETE EMPLOYEE
        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeleteEmployee([FromRoute]Guid id)
        {
            var deleteEmployee = await _appContext.Staffs.FirstOrDefaultAsync(emp => emp.ID == id);
            if (deleteEmployee != null)
            {
                _appContext.Staffs.Remove(deleteEmployee);
                await _appContext.SaveChangesAsync();
                return Ok(deleteEmployee);
            }
            return NotFound("Employee Not Found");
        }
    }
}
