using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkshopPlatform.Migrations
{
    public partial class workshopLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "WorkShops");

            migrationBuilder.DropColumn(
                name: "Government",
                table: "WorkShops");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "WorkShops",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Governments",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cities",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_WorkShops_CityId",
                table: "WorkShops",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Governments_Name",
                table: "Governments",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cities_Name_GovernmentId",
                table: "Cities",
                columns: new[] { "Name", "GovernmentId" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkShops_Cities_CityId",
                table: "WorkShops",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkShops_Cities_CityId",
                table: "WorkShops");

            migrationBuilder.DropIndex(
                name: "IX_WorkShops_CityId",
                table: "WorkShops");

            migrationBuilder.DropIndex(
                name: "IX_Governments_Name",
                table: "Governments");

            migrationBuilder.DropIndex(
                name: "IX_Cities_Name_GovernmentId",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "WorkShops");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "WorkShops",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Government",
                table: "WorkShops",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Governments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
