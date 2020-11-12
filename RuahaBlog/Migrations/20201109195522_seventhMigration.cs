using Microsoft.EntityFrameworkCore.Migrations;

namespace RuahaBlog.Migrations
{
    public partial class seventhMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_blogPosts",
                table: "blogPosts");

            migrationBuilder.RenameTable(
                name: "blogPosts",
                newName: "BlogPosts");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "BlogLikes",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogPosts",
                table: "BlogPosts",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogPosts",
                table: "BlogPosts");

            migrationBuilder.RenameTable(
                name: "BlogPosts",
                newName: "blogPosts");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "BlogLikes",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_blogPosts",
                table: "blogPosts",
                column: "Id");
        }
    }
}
