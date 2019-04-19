using Microsoft.EntityFrameworkCore.Migrations;

namespace RanobeLib.Migrations
{
    public partial class ChapterNumberFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "ChapterNumber",
                table: "Chapters",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ChapterNumber",
                table: "Chapters",
                nullable: true,
                oldClrType: typeof(double));
        }
    }
}
