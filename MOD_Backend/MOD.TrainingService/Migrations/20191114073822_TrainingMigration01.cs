using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MOD.TrainingService.Migrations
{
    public partial class TrainingMigration01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Training",
                columns: table => new
                {
                    TrainingId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(nullable: false),
                    MentorId = table.Column<long>(nullable: false),
                    SkillId = table.Column<long>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    TimeSlot = table.Column<string>(maxLength: 20, nullable: true),
                    Status = table.Column<string>(maxLength: 20, nullable: true),
                    Progress = table.Column<long>(nullable: false),
                    Rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Training", x => x.TrainingId);
                });

            migrationBuilder.InsertData(
                table: "Training",
                columns: new[] { "TrainingId", "EndDate", "MentorId", "Progress", "Rating", "SkillId", "StartDate", "Status", "TimeSlot", "UserId" },
                values: new object[] { 12L, new DateTime(2020, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 201L, 4L, 3, 47890L, new DateTime(2019, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "almost done", "evening", 101L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Training");
        }
    }
}
