using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistracijosPozymiai.Migrations
{
    public partial class remodelingFilledRegistrationtablecorrectingdesignmistakes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FormedRegistrations_RegAttributes_RegAttributeId",
                table: "FormedRegistrations");

            migrationBuilder.DropForeignKey(
                name: "FK_FormedRegistrations_RegValues_RegValueId",
                table: "FormedRegistrations");

            migrationBuilder.DropIndex(
                name: "IX_FormedRegistrations_RegAttributeId",
                table: "FormedRegistrations");

            migrationBuilder.DropIndex(
                name: "IX_FormedRegistrations_RegValueId",
                table: "FormedRegistrations");

            migrationBuilder.DropColumn(
                name: "RegAttributeId",
                table: "FormedRegistrations");

            migrationBuilder.DropColumn(
                name: "RegValueId",
                table: "FormedRegistrations");

            migrationBuilder.AddColumn<int>(
                name: "FormedRegistrationId",
                table: "RegValues",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RegValues_FormedRegistrationId",
                table: "RegValues",
                column: "FormedRegistrationId");

            migrationBuilder.AddForeignKey(
                name: "FK_RegValues_FormedRegistrations_FormedRegistrationId",
                table: "RegValues",
                column: "FormedRegistrationId",
                principalTable: "FormedRegistrations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegValues_FormedRegistrations_FormedRegistrationId",
                table: "RegValues");

            migrationBuilder.DropIndex(
                name: "IX_RegValues_FormedRegistrationId",
                table: "RegValues");

            migrationBuilder.DropColumn(
                name: "FormedRegistrationId",
                table: "RegValues");

            migrationBuilder.AddColumn<int>(
                name: "RegAttributeId",
                table: "FormedRegistrations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RegValueId",
                table: "FormedRegistrations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FormedRegistrations_RegAttributeId",
                table: "FormedRegistrations",
                column: "RegAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_FormedRegistrations_RegValueId",
                table: "FormedRegistrations",
                column: "RegValueId");

            migrationBuilder.AddForeignKey(
                name: "FK_FormedRegistrations_RegAttributes_RegAttributeId",
                table: "FormedRegistrations",
                column: "RegAttributeId",
                principalTable: "RegAttributes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FormedRegistrations_RegValues_RegValueId",
                table: "FormedRegistrations",
                column: "RegValueId",
                principalTable: "RegValues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
