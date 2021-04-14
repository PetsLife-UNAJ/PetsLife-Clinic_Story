using Microsoft.EntityFrameworkCore.Migrations;

namespace AccessData.Migrations
{
    public partial class hhccDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HistoriasClinicas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MascotaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoriasClinicas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Registros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Analisis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HistoriaClinicaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Registros_HistoriasClinicas_HistoriaClinicaId",
                        column: x => x.HistoriaClinicaId,
                        principalTable: "HistoriasClinicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Registros_HistoriaClinicaId",
                table: "Registros",
                column: "HistoriaClinicaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registros");

            migrationBuilder.DropTable(
                name: "HistoriasClinicas");
        }
    }
}
