using Microsoft.EntityFrameworkCore.Migrations;

namespace RuahaBlog.Migrations
{
    public partial class fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "timeOfPost",
                table: "BlogComments",
                newName: "TimeOfPost");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TimeOfPost",
                table: "BlogComments",
                newName: "timeOfPost");
        }
    }
}
