using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeFutebol.Migrations
{
    public partial class Version1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Time",
                columns: table => new
                {
                    IdTime = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Pais = table.Column<string>(type: "TEXT", nullable: true),
                    Estado = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Time", x => x.IdTime);
                });

            migrationBuilder.CreateTable(
                name: "Jogador",
                columns: table => new
                {
                    IdJogador = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Camisa = table.Column<int>(type: "INTEGER", nullable: false),
                    Posicao = table.Column<string>(type: "TEXT", nullable: true),
                    Peso = table.Column<float>(type: "REAL", nullable: false),
                    Altura = table.Column<float>(type: "REAL", nullable: false),
                    TimeFK = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogador", x => x.IdJogador);
                    table.ForeignKey(
                        name: "FK_Jogador_Time_TimeFK",
                        column: x => x.TimeFK,
                        principalTable: "Time",
                        principalColumn: "IdTime",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jogador_TimeFK",
                table: "Jogador",
                column: "TimeFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jogador");

            migrationBuilder.DropTable(
                name: "Time");
        }
    }
}
