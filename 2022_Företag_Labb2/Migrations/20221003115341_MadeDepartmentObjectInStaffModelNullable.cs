using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2022_Företag_Labb2.Migrations
{
    public partial class MadeDepartmentObjectInStaffModelNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: new Guid("10591a46-aa96-4bc1-98e8-5ae95c8362e5"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: new Guid("3e9c92bd-42fe-4ba7-80e4-6dc3f9991310"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: new Guid("6f1dc2e8-a60e-4e7f-81db-335082db1e93"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: new Guid("dad064f8-ef36-4bd6-9aa0-770f1d119fbd"));

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "ID", "Adress", "City", "DepartmentID", "Email", "FirstName", "LastName", "PhoneNumber", "Salary", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("17970383-aa4f-4a79-b9e5-a93a9c5da487"), "Drottninggatan 6", "Varberg", 3, "Winborgare@hotmail.com", "Markus", "Winborg", "0738426587", 30000.50m, "43286" },
                    { new Guid("1805f9e1-7633-488f-8605-f7059b5ca2dc"), "Skamman 4", "Varberg", 1, "HannahL@gmail.com", "Hannah", "Lahtinen", "0737776587", 25000.50m, "43286" },
                    { new Guid("53f5fc56-2509-4631-89d8-56d0f49219dc"), "Nösslingegatan 3", "Nösslinge", 2, "JenniferGergi@gmail.com", "Jennifer", "Gergi", "0737764537", 25750.50m, "43299" },
                    { new Guid("9172f46e-72b3-480d-b82e-5e17ca9d4327"), "Skamman 5", "Varberg", 4, "RobbanNilsson@outlook.com", "Robin", "Nilsson", "0728967546", 25750.75m, "43286" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: new Guid("17970383-aa4f-4a79-b9e5-a93a9c5da487"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: new Guid("1805f9e1-7633-488f-8605-f7059b5ca2dc"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: new Guid("53f5fc56-2509-4631-89d8-56d0f49219dc"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: new Guid("9172f46e-72b3-480d-b82e-5e17ca9d4327"));

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "ID", "Adress", "City", "DepartmentID", "Email", "FirstName", "LastName", "PhoneNumber", "Salary", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("10591a46-aa96-4bc1-98e8-5ae95c8362e5"), "Nösslingegatan 3", "Nösslinge", 2, "JenniferGergi@gmail.com", "Jennifer", "Gergi", "0737764537", 25750.50m, "43299" },
                    { new Guid("3e9c92bd-42fe-4ba7-80e4-6dc3f9991310"), "Skamman 5", "Varberg", 4, "RobbanNilsson@outlook.com", "Robin", "Nilsson", "0728967546", 25750.75m, "43286" },
                    { new Guid("6f1dc2e8-a60e-4e7f-81db-335082db1e93"), "Skamman 4", "Varberg", 1, "HannahL@gmail.com", "Hannah", "Lahtinen", "0737776587", 25000.50m, "43286" },
                    { new Guid("dad064f8-ef36-4bd6-9aa0-770f1d119fbd"), "Drottninggatan 6", "Varberg", 3, "Winborgare@hotmail.com", "Markus", "Winborg", "0738426587", 30000.50m, "43286" }
                });
        }
    }
}
