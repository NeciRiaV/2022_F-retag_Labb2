using Microsoft.EntityFrameworkCore;

namespace _2022_Företag_Labb2.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        //Tabeller
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed data for Departments
            modelBuilder.Entity<Department>().HasData(new Department { DepID = 1, DepartmentName = "HR" });
            modelBuilder.Entity<Department>().HasData(new Department { DepID = 2, DepartmentName = "IT" });
            modelBuilder.Entity<Department>().HasData(new Department { DepID = 3, DepartmentName = "Sales" });
            modelBuilder.Entity<Department>().HasData(new Department { DepID = 4, DepartmentName = "Finance" });
        }
    }
}
