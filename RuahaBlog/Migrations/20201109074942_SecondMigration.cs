using Microsoft.EntityFrameworkCore.Migrations;

namespace RuahaBlog.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "BlogLikes");

            migrationBuilder.AddColumn<int>(
                name: "BlogId",
                table: "BlogLikes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "BlogLikes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlogId",
                table: "BlogLikes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "BlogLikes");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "BlogLikes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
