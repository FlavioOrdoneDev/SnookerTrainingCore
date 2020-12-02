using Microsoft.EntityFrameworkCore.Migrations;

namespace SnookerTrainingCore.Infra.Migrations
{
    public partial class CriacaoCampoImagemRotinaTemplate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Imagem",
                table: "RotinasTemplate",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagem",
                table: "RotinasTemplate");
        }
    }
}
