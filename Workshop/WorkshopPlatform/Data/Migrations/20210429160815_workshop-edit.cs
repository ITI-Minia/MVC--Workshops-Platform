using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkshopPlatform.Migrations
{
    public partial class workshopedit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "JoinedIn",
                table: "WorkShops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JoinedIn",
                table: "WorkShops");
        }
    }
}
