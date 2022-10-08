using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2022_Företag_Labb2.Migrations
{
    public partial class AddedDepIDPropInStaffModelAndSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_Departments_DepartmentDepID",
                table: "Staffs");

            migrationBuilder.RenameColumn(
                name: "DepartmentDepID",
                table: "Staffs",
                newName: "DepartmentID");

            migrationBuilder.RenameIndex(
                name: "IX_Staffs_DepartmentDepID",
                table: "Staffs",
                newName: "IX_Staffs_DepartmentID");

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "ID", "Adress", "City", "DepartmentID", "Email", "FirstName", "LastName", "PhoneNumber", "Salary", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("09351153-0f86-44af-b3ee-b863cf656151"), "Skamman 4", "Varberg", 1, "HannahL@gmail.com", "Hannah", "Lahtinen", "0737776587", 25000.50m, "43286" },
                    { new Guid("0bbb5983-02c9-4915-bd6c-01fa83640478"), "Drottninggatan 6", "Varberg", 3, "Winborgare@hotmail.com", "Markus", "Winborg", "0738426587", 30000.50m, "43286" },
                    { new Guid("4bc8e90d-5446-4304-8b5b-761430cffb4f"), "Skamman 5", "Varberg", 4, "RobbanNilsson@outlook.com", "Robin", "Nilsson", "0728967546", 25750.75m, "43286" },
                    { new Guid("eec533f0-e065-405d-aea3-c9704e68174a"), "Nösslingegatan 3", "Nösslinge", 2, "JenniferGergi@gmail.com", "Jennifer", "Gergi", "0737764537", 25750.50m, "43299" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_Departments_DepartmentID",
                table: "Staffs",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "DepID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_Departments_DepartmentID",
                table: "Staffs");

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: new Guid("09351153-0f86-44af-b3ee-b863cf656151"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: new Guid("0bbb5983-02c9-4915-bd6c-01fa83640478"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: new Guid("4bc8e90d-5446-4304-8b5b-761430cffb4f"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: new Guid("eec533f0-e065-405d-aea3-c9704e68174a"));

            migrationBuilder.RenameColumn(
                name: "DepartmentID",
                table: "Staffs",
                newName: "DepartmentDepID");

            migrationBuilder.RenameIndex(
                name: "IX_Staffs_DepartmentID",
                table: "Staffs",
                newName: "IX_Staffs_DepartmentDepID");

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_Departments_DepartmentDepID",
                table: "Staffs",
                column: "DepartmentDepID",
                principalTable: "Departments",
                principalColumn: "DepID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
