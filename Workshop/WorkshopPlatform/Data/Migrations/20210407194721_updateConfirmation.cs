using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkshopPlatform.Migrations
{
    public partial class updateConfirmation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Confirmations_ConfirmationId",
                table: "Services");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkShops_Confirmations_ConfirmationId",
                table: "WorkShops");

            migrationBuilder.DropIndex(
                name: "IX_WorkShops_ConfirmationId",
                table: "WorkShops");

            migrationBuilder.DropIndex(
                name: "IX_Services_ConfirmationId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "ConfirmationId",
                table: "WorkShops");

            migrationBuilder.DropColumn(
                name: "ConfirmationId",
                table: "Services");

            migrationBuilder.AddColumn<int>(
                name: "ConfirmedEntityId",
                table: "Confirmations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmedEntityId",
                table: "Confirmations");

            migrationBuilder.AddColumn<int>(
                name: "ConfirmationId",
                table: "WorkShops",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConfirmationId",
                table: "Services",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_WorkShops_ConfirmationId",
                table: "WorkShops",
                column: "ConfirmationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Services_ConfirmationId",
                table: "Services",
                column: "ConfirmationId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Confirmations_ConfirmationId",
                table: "Services",
                column: "ConfirmationId",
                principalTable: "Confirmations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkShops_Confirmations_ConfirmationId",
                table: "WorkShops",
                column: "ConfirmationId",
                principalTable: "Confirmations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
