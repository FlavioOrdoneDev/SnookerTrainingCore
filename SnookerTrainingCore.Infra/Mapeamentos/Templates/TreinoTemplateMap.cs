using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SnookerTrainingCore.Domain.Entidades.Templates;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.Infra.Mapeamentos.Templates
{
    public class TreinoTemplateMap : IEntityTypeConfiguration<TreinoTemplate>
    {
        public void Configure(EntityTypeBuilder<TreinoTemplate> builder)
        {
            builder.HasKey(t => t.IdTreino);
            builder.Property(t => t.Nome).HasMaxLength(50).IsRequired();
            builder.Property(t => t.Descricao).HasMaxLength(200).IsRequired(false);
            
            builder.HasMany(c => c.Treinos).WithOne(c => c.TreinoTemplate).HasForeignKey(c => c.IdTreinoTemplate);

            builder.ToTable("TreinosTemplate");
        }
    }
}
