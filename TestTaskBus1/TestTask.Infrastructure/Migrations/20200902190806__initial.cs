using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestTask.Infrastructure.Migrations
{
    public partial class _initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "Main",
                table => new
                {
                    Id = table.Column<Guid>(),
                    LongUrl = table.Column<string>(nullable: true),
                    EditableUrl = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(),
                    Count = table.Column<int>()
                },
                constraints: table => { table.PrimaryKey("PK_Main", x => x.Id); });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "Main");
        }
    }
}