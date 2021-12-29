using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistracijosPozymiai.Migrations
{
    public partial class remodelingFormedRegistrationtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FormedRegistrations",
                table: "FormedRegistrations");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "FormedRegistrations",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FormedRegistrations",
                table: "FormedRegistrations",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_FormedRegistrations_RegAttributeId",
                table: "FormedRegistrations",
                column: "RegAttributeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FormedRegistrations",
                table: "FormedRegistrations");

            migrationBuilder.DropIndex(
                name: "IX_FormedRegistrations_RegAttributeId",
                table: "FormedRegistrations");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "FormedRegistrations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FormedRegistrations",
                table: "FormedRegistrations",
                columns: new[] { "RegAttributeId", "RegValueId" });
        }
    }
}
