using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkshopPlatform.Migrations
{
    public partial class userservices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_workshopServices",
                table: "workshopServices");

            migrationBuilder.RenameTable(
                name: "workshopServices",
                newName: "WorkshopServices");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkshopServices",
                table: "WorkshopServices",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Governments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Governments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Finished = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserServices_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserServices_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GovernmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Governments_GovernmentId",
                        column: x => x.GovernmentId,
                        principalTable: "Governments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_GovernmentId",
                table: "Cities",
                column: "GovernmentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserServices_ServiceId_UserId",
                table: "UserServices",
                columns: new[] { "ServiceId", "UserId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserServices_UserId",
                table: "UserServices",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "UserServices");

            migrationBuilder.DropTable(
                name: "Governments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkshopServices",
                table: "WorkshopServices");

            migrationBuilder.RenameTable(
                name: "WorkshopServices",
                newName: "workshopServices");

            migrationBuilder.AddPrimaryKey(
                name: "PK_workshopServices",
                table: "workshopServices",
                column: "Id");
        }
    }
}
