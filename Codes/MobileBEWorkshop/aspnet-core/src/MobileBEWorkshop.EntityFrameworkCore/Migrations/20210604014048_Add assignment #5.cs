using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileBEWorkshop.Migrations
{
    public partial class Addassignment5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Workshop_Assignments",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Workshop_Assignments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Workshop_Assignments");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Workshop_Assignments");
        }
    }
}
