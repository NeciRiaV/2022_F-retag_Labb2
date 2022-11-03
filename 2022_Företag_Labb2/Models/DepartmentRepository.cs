namespace _2022_Företag_Labb2.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _appDbContext;
        public DepartmentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Department> GetAllDepartments
        {
            get
            {
                return _appDbContext.Departments;
            }
        }
    }
}
