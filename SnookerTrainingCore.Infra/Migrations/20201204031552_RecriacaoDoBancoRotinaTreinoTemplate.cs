using Microsoft.EntityFrameworkCore.Migrations;

namespace SnookerTrainingCore.Infra.Migrations
{
    public partial class RecriacaoDoBancoRotinaTreinoTemplate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RotinasTemplate_TreinosTemplate_TreinoTemplateIdTreino",
                table: "RotinasTemplate");

            migrationBuilder.DropIndex(
                name: "IX_RotinasTemplate_TreinoTemplateIdTreino",
                table: "RotinasTemplate");

            migrationBuilder.DropColumn(
                name: "TreinoTemplateIdTreino",
                table: "RotinasTemplate");

            migrationBuilder.CreateTable(
                name: "RotinaTreinoTemplate",
                columns: table => new
                {
                    IdRotina = table.Column<int>(nullable: false),
                    IdTreino = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RotinaTreinoTemplate", x => new { x.IdRotina, x.IdTreino });
                    table.ForeignKey(
                        name: "FK_RotinaTreinoTemplate_RotinasTemplate_IdRotina",
                        column: x => x.IdRotina,
                        principalTable: "RotinasTemplate",
                        principalColumn: "IdRotina",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RotinaTreinoTemplate_TreinosTemplate_IdTreino",
                        column: x => x.IdTreino,
                        principalTable: "TreinosTemplate",
                        principalColumn: "IdTreino",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RotinaTreinoTemplate_IdTreino",
                table: "RotinaTreinoTemplate",
                column: "IdTreino");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RotinaTreinoTemplate");

            migrationBuilder.AddColumn<int>(
                name: "TreinoTemplateIdTreino",
                table: "RotinasTemplate",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RotinasTemplate_TreinoTemplateIdTreino",
                table: "RotinasTemplate",
                column: "TreinoTemplateIdTreino");

            migrationBuilder.AddForeignKey(
                name: "FK_RotinasTemplate_TreinosTemplate_TreinoTemplateIdTreino",
                table: "RotinasTemplate",
                column: "TreinoTemplateIdTreino",
                principalTable: "TreinosTemplate",
                principalColumn: "IdTreino",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
