using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2022_Företag_Labb2.Migrations
{
    public partial class AddedForgottenRepositoryPattern : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("09351153-0f86-44af-b3ee-b863cf656151"), "Skamman 4", "Varberg", 1, "HannahL@gmail.com", "Hannah", "Lahtinen", "0737776587", 25000.50m, "43286" },
                    { new Guid("0bbb5983-02c9-4915-bd6c-01fa83640478"), "Drottninggatan 6", "Varberg", 3, "Winborgare@hotmail.com", "Markus", "Winborg", "0738426587", 30000.50m, "43286" },
                    { new Guid("4bc8e90d-5446-4304-8b5b-761430cffb4f"), "Skamman 5", "Varberg", 4, "RobbanNilsson@outlook.com", "Robin", "Nilsson", "0728967546", 25750.75m, "43286" },
                    { new Guid("eec533f0-e065-405d-aea3-c9704e68174a"), "Nösslingegatan 3", "Nösslinge", 2, "JenniferGergi@gmail.com", "Jennifer", "Gergi", "0737764537", 25750.50m, "43299" }
                });
        }
    }
}
