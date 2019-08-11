using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SnookerTrainingCore.Domain.Entidades;

namespace SnookerTrainingCore.Infra.Mapeamentos
{
    public class PontuacaoMap : IEntityTypeConfiguration<Pontuacao>
    {
        public void Configure(EntityTypeBuilder<Pontuacao> builder)
        {

            builder.HasKey(re => re.IdPontuacao);            
            builder.Property(re => re.Pontos).IsRequired();

            builder.HasOne(r => r.Rotina).WithMany(r => r.Pontos).HasForeignKey(r => r.IdRotina);

            builder.ToTable("Pontuacoes");
        }        
    }
}

