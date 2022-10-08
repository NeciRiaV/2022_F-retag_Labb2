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


            //Seed data for Staffs
            modelBuilder.Entity<Staff>().HasData(new Staff
            {
                ID = Guid.NewGuid(),
                FirstName = "Hannah",
                LastName = "Lahtinen",
                Email = "HannahL@gmail.com",
                PhoneNumber = "0737776587",
                Adress = "Skamman 4",
                City = "Varberg",
                ZipCode = "43286",
                Salary = 25000.50M,
                DepartmentID = 1 
            });
            modelBuilder.Entity<Staff>().HasData(new Staff
            {
                ID = Guid.NewGuid(),
                FirstName = "Jennifer",
                LastName = "Gergi",
                Email = "JenniferGergi@gmail.com",
                PhoneNumber = "0737764537",
                Adress = "Nösslingegatan 3",
                City = "Nösslinge",
                ZipCode = "43299",
                Salary = 25750.50M,
                DepartmentID = 2
            });
            modelBuilder.Entity<Staff>().HasData(new Staff
            {
                ID = Guid.NewGuid(),
                FirstName = "Markus",
                LastName = "Winborg",
                Email = "Winborgare@hotmail.com",
                PhoneNumber = "0738426587",
                Adress = "Drottninggatan 6",
                City = "Varberg",
                ZipCode = "43286",
                Salary = 30000.50M,
                DepartmentID = 3
            });
            modelBuilder.Entity<Staff>().HasData(new Staff
            {
                ID = Guid.NewGuid(),
                FirstName = "Robin",
                LastName = "Nilsson",
                Email = "RobbanNilsson@outlook.com",
                PhoneNumber = "0728967546",
                Adress = "Skamman 5",
                City = "Varberg",
                ZipCode = "43286",
                Salary = 25750.75M,
                DepartmentID = 4
            });
        }

    }
}
