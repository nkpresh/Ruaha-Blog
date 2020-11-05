using Microsoft.EntityFrameworkCore.Migrations;

namespace RuahaBlog.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "blogPosts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Visible = table.Column<bool>(nullable: false),
                    Headline = table.Column<string>(nullable: false),
                    WriteUp = table.Column<string>(nullable: false),
                    PhotoPaths = table.Column<string>(nullable: true),
                    category = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogPosts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "blogPosts",
                columns: new[] { "Id", "Email", "Headline", "Name", "PhotoPaths", "Visible", "WriteUp", "category" },
                values: new object[] { 1, "nathan@tech.com", "The New Ride is Mind Blowing", "Nathan", null, true, "The new 2020 Chevrolete Camaro is so cute; It actually came late because of the corona virus pandemic and #Endsars protest  but,hey!, thank goodness; it's here and it's not disappointing. The features are madd but yet not everybody likes it.", 4 });

            migrationBuilder.InsertData(
                table: "blogPosts",
                columns: new[] { "Id", "Email", "Headline", "Name", "PhotoPaths", "Visible", "WriteUp", "category" },
                values: new object[] { 2, "goody@tech.com", "Some people have real problems", "GoodLuck", null, true, "The popular musician who goes by the name Sia Fura, used to be a drug addict who was so messed up, she almost commited suicide when she lost her boy friend, but was saved by a phone call, but guess what; now she's a celebrity who has nothing to dowith drugs and she's living her best life. Her music has inspired me a lot of times and that's why I chose to write about her.In life, sometimes we face some matture problems that try to weigh us down, some of those times we don't even recieve that one phone that is supposed to save us; maybe God want's us to be our own heros to save our own lives, don't let yourself down, keep pushing#Real problems", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "blogPosts");
        }
    }
}
