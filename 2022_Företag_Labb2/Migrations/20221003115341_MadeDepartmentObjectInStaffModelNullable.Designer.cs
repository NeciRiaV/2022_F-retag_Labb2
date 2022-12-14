// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _2022_Företag_Labb2.Models;

#nullable disable

namespace _2022_Företag_Labb2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221003115341_MadeDepartmentObjectInStaffModelNullable")]
    partial class MadeDepartmentObjectInStaffModelNullable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_2022_Företag_Labb2.Models.Department", b =>
                {
                    b.Property<int>("DepID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepID"), 1L, 1);

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepID");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepID = 1,
                            DepartmentName = "HR"
                        },
                        new
                        {
                            DepID = 2,
                            DepartmentName = "IT"
                        },
                        new
                        {
                            DepID = 3,
                            DepartmentName = "Sales"
                        },
                        new
                        {
                            DepID = 4,
                            DepartmentName = "Finance"
                        });
                });

            modelBuilder.Entity("_2022_Företag_Labb2.Models.Staff", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Staffs");

                    b.HasData(
                        new
                        {
                            ID = new Guid("1805f9e1-7633-488f-8605-f7059b5ca2dc"),
                            Adress = "Skamman 4",
                            City = "Varberg",
                            DepartmentID = 1,
                            Email = "HannahL@gmail.com",
                            FirstName = "Hannah",
                            LastName = "Lahtinen",
                            PhoneNumber = "0737776587",
                            Salary = 25000.50m,
                            ZipCode = "43286"
                        },
                        new
                        {
                            ID = new Guid("53f5fc56-2509-4631-89d8-56d0f49219dc"),
                            Adress = "Nösslingegatan 3",
                            City = "Nösslinge",
                            DepartmentID = 2,
                            Email = "JenniferGergi@gmail.com",
                            FirstName = "Jennifer",
                            LastName = "Gergi",
                            PhoneNumber = "0737764537",
                            Salary = 25750.50m,
                            ZipCode = "43299"
                        },
                        new
                        {
                            ID = new Guid("17970383-aa4f-4a79-b9e5-a93a9c5da487"),
                            Adress = "Drottninggatan 6",
                            City = "Varberg",
                            DepartmentID = 3,
                            Email = "Winborgare@hotmail.com",
                            FirstName = "Markus",
                            LastName = "Winborg",
                            PhoneNumber = "0738426587",
                            Salary = 30000.50m,
                            ZipCode = "43286"
                        },
                        new
                        {
                            ID = new Guid("9172f46e-72b3-480d-b82e-5e17ca9d4327"),
                            Adress = "Skamman 5",
                            City = "Varberg",
                            DepartmentID = 4,
                            Email = "RobbanNilsson@outlook.com",
                            FirstName = "Robin",
                            LastName = "Nilsson",
                            PhoneNumber = "0728967546",
                            Salary = 25750.75m,
                            ZipCode = "43286"
                        });
                });

            modelBuilder.Entity("_2022_Företag_Labb2.Models.Staff", b =>
                {
                    b.HasOne("_2022_Företag_Labb2.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });
#pragma warning restore 612, 618
        }
    }
}
