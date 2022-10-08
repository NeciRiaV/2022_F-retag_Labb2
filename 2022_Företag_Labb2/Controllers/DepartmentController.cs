using _2022_Företag_Labb2.Models;
using Microsoft.AspNetCore.Mvc;

namespace _2022_Företag_Labb2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _departmentRepo;
        public DepartmentController(IDepartmentRepository departmentRepo)
        {
            _departmentRepo = departmentRepo;
        }


        //GET ALL DEPARTMENTS
        [HttpGet]
        public IActionResult GetAllDepartments()
        {
            try
            {
                var departments = _departmentRepo.GetAllDepartments.ToList();
                return Ok(departments);

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Couldn't retrieve data from database...");
            }
        }

        //GET SINGEL DEPARTMENT WITH ALL IT'S STAFF
        [HttpGet]
        [Route("{id:int}")]
        [ActionName("GetSingelDepartmentWithStaff")]
        public async Task<IActionResult> GetSingelDepartmentWithStaff([FromRoute] int id)
        {
            try
            {
                return Ok(await _departmentRepo.GetDepartmentById(id));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Couldn't retrieve data from database...");
            }
        }
    }
}
