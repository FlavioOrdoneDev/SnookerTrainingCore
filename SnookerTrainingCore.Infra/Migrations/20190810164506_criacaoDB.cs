using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SnookerTrainingCore.Infra.Migrations
{
    public partial class criacaoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    IdCategoria = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    Descricao = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.IdCategoria);
                });

            migrationBuilder.CreateTable(
                name: "Resultados",
                columns: table => new
                {
                    IdResultado = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(nullable: false),
                    Observacao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resultados", x => x.IdResultado);
                });

            migrationBuilder.CreateTable(
                name: "TreinosTemplate",
                columns: table => new
                {
                    IdTreino = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    Descricao = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreinosTemplate", x => x.IdTreino);
                });

            migrationBuilder.CreateTable(
                name: "RotinasTemplate",
                columns: table => new
                {
                    IdRotina = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    Descricao = table.Column<string>(maxLength: 200, nullable: true),
                    IdCategoria = table.Column<int>(nullable: false),
                    TipoMeta = table.Column<int>(nullable: false),
                    Meta = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RotinasTemplate", x => x.IdRotina);
                    table.ForeignKey(
                        name: "FK_RotinasTemplate_Categorias_IdCategoria",
                        column: x => x.IdCategoria,
                        principalTable: "Categorias",
                        principalColumn: "IdCategoria",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Treinos",
                columns: table => new
                {
                    IdTreino = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdTreinoTemplate = table.Column<int>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false),
                    HoraInicio = table.Column<DateTime>(nullable: true),
                    HoraFim = table.Column<DateTime>(nullable: true),
                    Duracao = table.Column<TimeSpan>(nullable: true),
                    Observacao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treinos", x => x.IdTreino);
                    table.ForeignKey(
                        name: "FK_Treinos_TreinosTemplate_IdTreinoTemplate",
                        column: x => x.IdTreinoTemplate,
                        principalTable: "TreinosTemplate",
                        principalColumn: "IdTreino",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rotinas",
                columns: table => new
                {
                    IdRotina = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdRotinaTemplate = table.Column<int>(nullable: false),
                    HoraInicio = table.Column<DateTime>(nullable: true),
                    HoraFim = table.Column<DateTime>(nullable: true),
                    Duracao = table.Column<TimeSpan>(nullable: true),
                    Observacao = table.Column<string>(nullable: true),
                    IdTreino = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rotinas", x => x.IdRotina);
                    table.ForeignKey(
                        name: "FK_Rotinas_RotinasTemplate_IdRotinaTemplate",
                        column: x => x.IdRotinaTemplate,
                        principalTable: "RotinasTemplate",
                        principalColumn: "IdRotina",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rotinas_Treinos_IdTreino",
                        column: x => x.IdTreino,
                        principalTable: "Treinos",
                        principalColumn: "IdTreino",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pontuacoes",
                columns: table => new
                {
                    IdPontuacao = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Pontos = table.Column<double>(nullable: false),
                    MatouTodasAsBolas = table.Column<bool>(nullable: false),
                    IdRotina = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pontuacoes", x => x.IdPontuacao);
                    table.ForeignKey(
                        name: "FK_Pontuacoes_Rotinas_IdRotina",
                        column: x => x.IdRotina,
                        principalTable: "Rotinas",
                        principalColumn: "IdRotina",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pontuacoes_IdRotina",
                table: "Pontuacoes",
                column: "IdRotina");

            migrationBuilder.CreateIndex(
                name: "IX_Rotinas_IdRotinaTemplate",
                table: "Rotinas",
                column: "IdRotinaTemplate");

            migrationBuilder.CreateIndex(
                name: "IX_Rotinas_IdTreino",
                table: "Rotinas",
                column: "IdTreino");

            migrationBuilder.CreateIndex(
                name: "IX_RotinasTemplate_IdCategoria",
                table: "RotinasTemplate",
                column: "IdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Treinos_IdTreinoTemplate",
                table: "Treinos",
                column: "IdTreinoTemplate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pontuacoes");

            migrationBuilder.DropTable(
                name: "Resultados");

            migrationBuilder.DropTable(
                name: "Rotinas");

            migrationBuilder.DropTable(
                name: "RotinasTemplate");

            migrationBuilder.DropTable(
                name: "Treinos");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "TreinosTemplate");
        }
    }
}
