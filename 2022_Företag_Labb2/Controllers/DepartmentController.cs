using _2022_Företag_Labb2.Models;
using Microsoft.AspNetCore.Mvc;

namespace _2022_Företag_Labb2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _depRepository;
        private readonly AppDbContext _appContext;

        public DepartmentController(AppDbContext appContext, IDepartmentRepository depRepository)
        {
            this._appContext = appContext;
            _depRepository = depRepository;
        }


        //GET ALL STAFF
        [HttpGet]
        public IActionResult GetAllDepartments()
        {
            var dep = _depRepository;
            return Ok(dep);
        }
    }
}
