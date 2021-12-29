using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistracijosPozymiai.Migrations
{
    public partial class filledregistrationtableManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormedRegistrations",
                columns: table => new
                {
                    RegAttributeId = table.Column<int>(type: "int", nullable: false),
                    RegValueId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormedRegistrations", x => new { x.RegAttributeId, x.RegValueId });
                    table.ForeignKey(
                        name: "FK_FormedRegistrations_RegAttributes_RegAttributeId",
                        column: x => x.RegAttributeId,
                        principalTable: "RegAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormedRegistrations_RegValues_RegValueId",
                        column: x => x.RegValueId,
                        principalTable: "RegValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FormedRegistrations_RegValueId",
                table: "FormedRegistrations",
                column: "RegValueId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormedRegistrations");
        }
    }
}
