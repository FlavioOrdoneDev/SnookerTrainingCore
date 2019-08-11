using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SnookerTrainingCore.Domain.Entidades;
using SnookerTrainingCore.Domain.Entidades.Templates;

namespace SnookerTrainingCore.Infra.Mapeamentos
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(c => c.IdCategoria);
            builder.Property(c => c.Nome).HasMaxLength(50).IsRequired();
            builder.Property(c => c.Descricao).HasMaxLength(300).IsRequired(false);
            builder.HasMany(c => c.RotinasTemplate).WithOne(c => c.Categoria).HasForeignKey(c => c.IdCategoria);

            builder.ToTable("Categorias");
        }
    }
}
