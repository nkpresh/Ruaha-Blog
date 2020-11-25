using Microsoft.EntityFrameworkCore.Migrations;

namespace RuahaBlog.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BlogComments",
                columns: new[] { "Id", "BlogPostId", "Body", "Name" },
                values: new object[] { 1, 2, "this post is crap, Dont't you have something meaningful to say? shut the fvck up  mehn", "Mum" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
