using Microsoft.EntityFrameworkCore.Migrations;

namespace RuahaBlog.Migrations
{
    public partial class fifthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "blogPosts",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "blogPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Peter");

            migrationBuilder.UpdateData(
                table: "blogPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Mum");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "blogPosts");
        }
    }
}
