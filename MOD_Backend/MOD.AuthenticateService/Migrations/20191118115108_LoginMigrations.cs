using Microsoft.EntityFrameworkCore.Migrations;

namespace MOD.AuthenticateService.Migrations
{
    public partial class LoginMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mentor",
                columns: table => new
                {
                    MentorId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MentorName = table.Column<string>(maxLength: 20, nullable: true),
                    Email = table.Column<string>(nullable: true),
                    MobileNo = table.Column<double>(nullable: false),
                    Experience = table.Column<int>(nullable: false),
                    MentorSkills = table.Column<string>(nullable: true),
                    TimeSlot = table.Column<string>(nullable: true),
                    Availability = table.Column<bool>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Password = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentor", x => x.MentorId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 20, nullable: true),
                    Email = table.Column<string>(maxLength: 20, nullable: true),
                    Password = table.Column<string>(maxLength: 20, nullable: true),
                    Active = table.Column<bool>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mentor");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
