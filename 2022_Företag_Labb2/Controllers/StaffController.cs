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
        private readonly IStaffRepository _staffRepository;
        private readonly AppDbContext _appContext;

        public StaffController(AppDbContext appContext, IStaffRepository staffRepository)
        {
            this._appContext = appContext;
            _staffRepository = staffRepository;
        }


        //GET ALL STAFF
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var staff = _staffRepository.GetAllStaff();
            return Ok(staff);
        }

        //GET SINGEL EMPLOYEE
        [HttpGet]
        [Route("{id:guid}")]
        [ActionName("GetSingleEmployee")]
        public IActionResult GetSingelEmployee([FromRoute] Guid id)
        {
            try
            {
            var employee = _staffRepository.GetStaffById(id);
            if (employee != null)
            {
                return Ok(employee);
            }
            return NotFound("Employee NotFound");

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Data couldn't be retrieved...");
            }
        }

        //ADD NEW EMPLOYEE
        [HttpPost]
        public async Task<ActionResult<Staff>> AddEmployee([FromBody] Staff staff)
        {
            try
            {
                var newEmployee = await _staffRepository.Add(staff);
                CreatedAtAction(nameof(GetSingelEmployee), new { id = newEmployee.ID }, newEmployee);
                return Ok(newEmployee);

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Data couldn't be retrieved...");
            }

        }

        //UPDATE EMPLOYEE
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<ActionResult<Staff>> UpdateEmployee([FromRoute] Guid id, [FromBody] Staff staff)
        {
            try
            {
                var employee = _staffRepository.GetStaffById(id);
                if (employee == null)
                {
                    return NotFound("Employee Not Found");
                }
                return await _staffRepository.Update(staff);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Data couldn't be retrieved...");
            }
        }

        //DELETE EMPLOYEE
        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeleteEmployee([FromRoute] Guid id)
        {
            try
            {
            await _staffRepository.Delete(id);
            return Ok();

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Data couldn't be retrieved...");
            }
        }
    }
}
