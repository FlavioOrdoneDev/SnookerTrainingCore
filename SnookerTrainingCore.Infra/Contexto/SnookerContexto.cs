

using Microsoft.EntityFrameworkCore;
using SnookerTrainingCore.Domain.Entidades;
using SnookerTrainingCore.Domain.Entidades.Templates;
using SnookerTrainingCore.Infra.Mapeamentos;
using SnookerTrainingCore.Infra.Mapeamentos.Templates;

namespace SnookerTrainingCore.Infra.Contexto
{
    public class SnookerContexto : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<RotinaTemplate> RotinasTemplate { get; set; }
        public DbSet<TreinoTemplate> TreinosTemplate { get; set; }
        public DbSet<Rotina> Rotinas { get; set; }
        public DbSet<Resultado> Resultados { get; set; }
        public DbSet<Treino> Treinos {get; set;}
        public DbSet<Pontuacao> Pontuacoes { get; set; }
        
        public SnookerContexto(DbContextOptions<SnookerContexto> opcoes) : base(opcoes) {  }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new RotinaTemplateMap());
            modelBuilder.ApplyConfiguration(new TreinoTemplateMap());
            modelBuilder.ApplyConfiguration(new RotinaMap());
            modelBuilder.ApplyConfiguration(new ResultadoMap());
            modelBuilder.ApplyConfiguration(new TreinoMap());
            modelBuilder.ApplyConfiguration(new PontuacaoMap());
            //modelBuilder.ApplyConfiguration(new TreinoRotinaMap());
        }
    }
}
