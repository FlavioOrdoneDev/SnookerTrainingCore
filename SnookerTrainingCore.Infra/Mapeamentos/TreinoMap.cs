using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SnookerTrainingCore.Domain.Entidades;

namespace SnookerTrainingCore.Infra.Mapeamentos
{
    public class TreinoMap : IEntityTypeConfiguration<Treino>
    {
        public void Configure(EntityTypeBuilder<Treino> builder)
        {
            builder.HasKey(  t => t.IdTreino);            
            builder.Property(t => t.Data).IsRequired();
            builder.Property(t => t.Duracao).IsRequired(false);
            builder.Property(t => t.Observacao).IsRequired(false);

            builder.HasOne(r => r.TreinoTemplate).WithMany(r => r.Treinos).HasForeignKey(r => r.IdTreinoTemplate);
            builder.HasMany(r => r.Rotinas).WithOne(r => r.Treino).HasForeignKey(r => r.IdTreino);

            builder.ToTable("Treinos");
        }
    }
}
