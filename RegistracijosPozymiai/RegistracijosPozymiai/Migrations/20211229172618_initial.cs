using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistracijosPozymiai.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RegAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegAttributes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(type: "int", nullable: false),
                    RegistrationAttributeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegValues_RegAttributes_RegistrationAttributeId",
                        column: x => x.RegistrationAttributeId,
                        principalTable: "RegAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RegValues_RegistrationAttributeId",
                table: "RegValues",
                column: "RegistrationAttributeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegValues");

            migrationBuilder.DropTable(
                name: "RegAttributes");
        }
    }
}
