using Microsoft.EntityFrameworkCore.Migrations;

namespace MOD.UserService.Migrations
{
    public partial class UserMigration03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Mentor",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Mentor",
                keyColumn: "MentorId",
                keyValue: 201L,
                column: "Password",
                value: "123");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Mentor");
        }
    }
}
