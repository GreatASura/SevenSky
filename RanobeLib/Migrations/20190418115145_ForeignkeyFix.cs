using Microsoft.EntityFrameworkCore.Migrations;

namespace RanobeLib.Migrations
{
    public partial class ForeignkeyFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
               name: "FK_Chapters_Books_BookId",
               table: "Chapters",
               column: "BookId",
               principalTable: "Books",
               principalColumn: "Id",
               onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
