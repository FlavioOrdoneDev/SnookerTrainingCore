using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SnookerTrainingCore.Domain.Entidades;

namespace SnookerTrainingCore.Infra.Mapeamentos
{
    public class RotinaMap : IEntityTypeConfiguration<Rotina>
    {
        public void Configure(EntityTypeBuilder<Rotina> builder)
        {
            builder.HasKey(r => r.IdRotina);
            builder.Property(r => r.Duracao).IsRequired(false);
            builder.Property(r => r.Observacao).IsRequired(false);
            builder.Ignore(r => r.Media);
            builder.Ignore(r => r.BreakMaximo);
            
            builder.HasMany(c => c.Pontos).WithOne(c => c.Rotina).HasForeignKey(c => c.IdRotina);
            builder.HasOne(r => r.Treino).WithMany(r => r.Rotinas).HasForeignKey(r => r.IdTreino);
            //builder.HasMany(r => r.TreinoRotinas).WithOne(r => r.Rotina).HasForeignKey(r => r.IdRotina);

            builder.ToTable("Rotinas");
        }
    }
}
