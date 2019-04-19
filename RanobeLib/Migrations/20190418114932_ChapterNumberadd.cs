using Microsoft.EntityFrameworkCore.Migrations;

namespace RanobeLib.Migrations
{
    public partial class ChapterNumberadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ChapterNumber",
                table: "Chapters",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChapterNumber",
                table: "Chapters");
        }
    }
}
