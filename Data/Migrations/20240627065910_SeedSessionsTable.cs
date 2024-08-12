using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp_FA_BSD_Training.Data.Migrations
{
    public partial class SeedSessionsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "Date", "Duration", "Knowledge_Base", "Link_IT_help_ticket", "Title" },
                values: new object[] { 1, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, null, null, "Intro to Web FA BSD training" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
