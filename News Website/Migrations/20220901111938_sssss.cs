using Microsoft.EntityFrameworkCore.Migrations;

namespace News_Website.Migrations
{
    public partial class sssss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "logo",
                table: "Categories",
                newName: "Logo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Logo",
                table: "Categories",
                newName: "logo");
        }
    }
}
