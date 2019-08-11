using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SnookerTrainingCore.Domain.Entidades.Templates;

namespace SnookerTrainingCore.Infra.Mapeamentos.Templates
{
    public class RotinaTemplateMap : IEntityTypeConfiguration<RotinaTemplate>
    {
        public void Configure(EntityTypeBuilder<RotinaTemplate> builder)
        {
            builder.HasKey(r => r.IdRotina);
            builder.Property(r => r.Nome).HasMaxLength(50).IsRequired();
            builder.Property(r => r.Descricao).HasMaxLength(200).IsRequired(false);            
            builder.Property(r => r.TipoMeta).IsRequired();
            builder.Property(r => r.Meta).IsRequired(false);

            builder.HasOne(r => r.Categoria).WithMany(r => r.RotinasTemplate).HasForeignKey(r => r.IdCategoria);
            builder.HasMany(c => c.Rotinas).WithOne(c => c.RotinaTemplate).HasForeignKey(c => c.IdRotinaTemplate);

            builder.ToTable("RotinasTemplate");
        }
    }
}
