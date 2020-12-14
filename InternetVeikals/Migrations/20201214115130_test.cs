using Microsoft.EntityFrameworkCore.Migrations;

namespace InternetVeikals.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "role",
                table: "Customer",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "role",
                table: "Admin",
                newName: "Role");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Customer",
                newName: "role");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Admin",
                newName: "role");
        }
    }
}
