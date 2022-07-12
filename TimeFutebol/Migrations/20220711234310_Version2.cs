using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeFutebol.Migrations
{
    public partial class Version2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jogador_Time_TimeFK",
                table: "Jogador");

            migrationBuilder.AlterColumn<int>(
                name: "TimeFK",
                table: "Jogador",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Jogador_Camisa",
                table: "Jogador",
                column: "Camisa",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Jogador_Time_TimeFK",
                table: "Jogador",
                column: "TimeFK",
                principalTable: "Time",
                principalColumn: "IdTime",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jogador_Time_TimeFK",
                table: "Jogador");

            migrationBuilder.DropIndex(
                name: "IX_Jogador_Camisa",
                table: "Jogador");

            migrationBuilder.AlterColumn<int>(
                name: "TimeFK",
                table: "Jogador",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogador_Time_TimeFK",
                table: "Jogador",
                column: "TimeFK",
                principalTable: "Time",
                principalColumn: "IdTime",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
