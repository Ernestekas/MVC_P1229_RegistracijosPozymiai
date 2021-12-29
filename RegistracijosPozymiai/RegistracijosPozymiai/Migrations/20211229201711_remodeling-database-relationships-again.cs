using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistracijosPozymiai.Migrations
{
    public partial class remodelingdatabaserelationshipsagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegValues_FormedRegistrations_FormedRegistrationId",
                table: "RegValues");

            migrationBuilder.DropForeignKey(
                name: "FK_RegValues_RegAttributes_RegistrationAttributeId",
                table: "RegValues");

            migrationBuilder.DropIndex(
                name: "IX_RegValues_FormedRegistrationId",
                table: "RegValues");

            migrationBuilder.DropColumn(
                name: "FormedRegistrationId",
                table: "RegValues");

            migrationBuilder.AlterColumn<int>(
                name: "RegistrationAttributeId",
                table: "RegValues",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ValueRegistrations",
                columns: table => new
                {
                    RegValueId = table.Column<int>(type: "int", nullable: false),
                    FormedRegistrationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValueRegistrations", x => new { x.FormedRegistrationId, x.RegValueId });
                    table.ForeignKey(
                        name: "FK_ValueRegistrations_FormedRegistrations_FormedRegistrationId",
                        column: x => x.FormedRegistrationId,
                        principalTable: "FormedRegistrations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ValueRegistrations_RegValues_RegValueId",
                        column: x => x.RegValueId,
                        principalTable: "RegValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ValueRegistrations_RegValueId",
                table: "ValueRegistrations",
                column: "RegValueId");

            migrationBuilder.AddForeignKey(
                name: "FK_RegValues_RegAttributes_RegistrationAttributeId",
                table: "RegValues",
                column: "RegistrationAttributeId",
                principalTable: "RegAttributes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegValues_RegAttributes_RegistrationAttributeId",
                table: "RegValues");

            migrationBuilder.DropTable(
                name: "ValueRegistrations");

            migrationBuilder.AlterColumn<int>(
                name: "RegistrationAttributeId",
                table: "RegValues",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_RegValues_RegAttributes_RegistrationAttributeId",
                table: "RegValues",
                column: "RegistrationAttributeId",
                principalTable: "RegAttributes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
