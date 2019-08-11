using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SnookerTrainingCore.Domain.Entidades;

namespace SnookerTrainingCore.Infra.Mapeamentos
{
    public class ResultadoMap : IEntityTypeConfiguration<Resultado>
    {
        public void Configure(EntityTypeBuilder<Resultado> builder)
        {
            builder.HasKey(re => re.IdResultado);
            
            builder.Property(re => re.Data).IsRequired();
            builder.Property(re => re.Observacao).IsRequired(false);

            builder.ToTable("Resultados");
        }
    }
}
