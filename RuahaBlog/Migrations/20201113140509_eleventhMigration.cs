using Microsoft.EntityFrameworkCore.Migrations;

namespace RuahaBlog.Migrations
{
    public partial class eleventhMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BogPostId",
                table: "BlogLikes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BlogLikes_BogPostId",
                table: "BlogLikes",
                column: "BogPostId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogLikes_BlogPosts_BogPostId",
                table: "BlogLikes",
                column: "BogPostId",
                principalTable: "BlogPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogLikes_BlogPosts_BogPostId",
                table: "BlogLikes");

            migrationBuilder.DropIndex(
                name: "IX_BlogLikes_BogPostId",
                table: "BlogLikes");

            migrationBuilder.DropColumn(
                name: "BogPostId",
                table: "BlogLikes");
        }
    }
}
