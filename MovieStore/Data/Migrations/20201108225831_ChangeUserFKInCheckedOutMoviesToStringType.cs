using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieStore.Data.Migrations
{
    public partial class ChangeUserFKInCheckedOutMoviesToStringType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckedOutMovies_AspNetUsers_UserId1",
                table: "CheckedOutMovies");

            migrationBuilder.DropIndex(
                name: "IX_CheckedOutMovies_UserId1",
                table: "CheckedOutMovies");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "CheckedOutMovies");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "CheckedOutMovies",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_CheckedOutMovies_UserId",
                table: "CheckedOutMovies",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckedOutMovies_AspNetUsers_UserId",
                table: "CheckedOutMovies",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckedOutMovies_AspNetUsers_UserId",
                table: "CheckedOutMovies");

            migrationBuilder.DropIndex(
                name: "IX_CheckedOutMovies_UserId",
                table: "CheckedOutMovies");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "CheckedOutMovies",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "CheckedOutMovies",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CheckedOutMovies_UserId1",
                table: "CheckedOutMovies",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckedOutMovies_AspNetUsers_UserId1",
                table: "CheckedOutMovies",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
