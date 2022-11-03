using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2022_Företag_Labb2.Migrations
{
    public partial class AddedImageUrlPropertyToStaff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "ID", "Adress", "City", "DepartmentID", "Email", "FirstName", "ImageUrl", "LastName", "PhoneNumber", "Salary", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("1441852f-8096-4cc3-8676-fc3e0220f171"), "Skamman 4", "Varberg", 1, "HannahL@gmail.com", "Hannah", null, "Lahtinen", "0737776587", 25000.50m, "43286" },
                    { new Guid("6bf26605-ee00-47a6-82e2-be9dbdf36957"), "Nösslingegatan 3", "Nösslinge", 2, "JenniferGergi@gmail.com", "Jennifer", null, "Gergi", "0737764537", 25750.50m, "43299" },
                    { new Guid("a7293d05-5807-4d27-a858-47eabedbba9d"), "Skamman 5", "Varberg", 4, "RobbanNilsson@outlook.com", "Robin", null, "Nilsson", "0728967546", 25750.75m, "43286" },
                    { new Guid("f096a05e-2111-4fb2-9232-862fcd949c21"), "Drottninggatan 6", "Varberg", 3, "Winborgare@hotmail.com", "Markus", null, "Winborg", "0738426587", 30000.50m, "43286" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: new Guid("1441852f-8096-4cc3-8676-fc3e0220f171"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: new Guid("6bf26605-ee00-47a6-82e2-be9dbdf36957"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: new Guid("a7293d05-5807-4d27-a858-47eabedbba9d"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: new Guid("f096a05e-2111-4fb2-9232-862fcd949c21"));

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Staffs");

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
    }
}
