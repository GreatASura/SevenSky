using Microsoft.EntityFrameworkCore.Migrations;

namespace RanobeLib.Migrations
{
    public partial class ChapterFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chapters_Books_BookIdId",
                table: "Chapters");

            migrationBuilder.DropIndex(
                name: "IX_Chapters_BookIdId",
                table: "Chapters");

            migrationBuilder.DropColumn(
                name: "BookIdId",
                table: "Chapters");

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Chapters",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Chapters");

            migrationBuilder.AddColumn<int>(
                name: "BookIdId",
                table: "Chapters",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Chapters_BookIdId",
                table: "Chapters",
                column: "BookIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chapters_Books_BookIdId",
                table: "Chapters",
                column: "BookIdId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
