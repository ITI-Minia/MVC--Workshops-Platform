using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkshopPlatform.Migrations
{
    public partial class editUserServices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserServices_ServiceId_UserId",
                table: "UserServices");

            migrationBuilder.CreateIndex(
                name: "IX_UserServices_ServiceId",
                table: "UserServices",
                column: "ServiceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserServices_ServiceId",
                table: "UserServices");

            migrationBuilder.CreateIndex(
                name: "IX_UserServices_ServiceId_UserId",
                table: "UserServices",
                columns: new[] { "ServiceId", "UserId" },
                unique: true);
        }
    }
}
