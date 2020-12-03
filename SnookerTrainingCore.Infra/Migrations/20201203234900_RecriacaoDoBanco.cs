using Microsoft.EntityFrameworkCore.Migrations;

namespace SnookerTrainingCore.Infra.Migrations
{
    public partial class RecriacaoDoBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
