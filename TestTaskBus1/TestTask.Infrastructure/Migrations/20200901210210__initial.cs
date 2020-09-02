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
                    LongUrl = table.Column<string>(maxLength: 1024),
                    EditableUrl = table.Column<string>(maxLength: 500),
                    Date = table.Column<DateTime>("date"),
                    Count = table.Column<int>("int")
                },
                constraints: table => { table.PrimaryKey("PK_Main", x => x.Id); });

            migrationBuilder.InsertData(
                "Main",
                new[] {"Id", "Count", "Date", "EditableUrl", "LongUrl"},
                new object[]
                {
                    new Guid("716c2e99-6f6c-4472-81a5-43c56e11637c"), 0,
                    new DateTime(2020, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), "https://bit.ly/3b2lFle",
                    "https://www.instagram.com/zab.91/"
                });

            migrationBuilder.InsertData(
                "Main",
                new[] {"Id", "Count", "Date", "EditableUrl", "LongUrl"},
                new object[]
                {
                    new Guid("bfcbbec9-0023-4a6f-b466-a099f11f3b09"), 0,
                    new DateTime(2020, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), "https://cutt.ly/dfzomFL",
                    "https://github.com/Vadim918"
                });

            migrationBuilder.InsertData(
                "Main",
                new[] {"Id", "Count", "Date", "EditableUrl", "LongUrl"},
                new object[]
                {
                    new Guid("f7e42b20-9f4f-44ff-a7e3-c65c4772b308"), 0,
                    new DateTime(2020, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), "https://cutt.ly/7fzoZjB",
                    "https://metanit.com/sharp/aspnet5/1.1.php"
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "Main");
        }
    }
}