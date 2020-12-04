using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SnookerTrainingCore.Domain.Entidades;
using SnookerTrainingCore.Domain.Entidades.Templates;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.Infra.Mapeamentos
{
    public class RotinaTreinoTemplateMap : IEntityTypeConfiguration<RotinaTreinoTemplate>
    {
        public void Configure(EntityTypeBuilder<RotinaTreinoTemplate> builder)
        {
            builder.HasKey(r => new { r.IdRotina, r.IdTreino });

            builder.HasOne(rt => rt.RotinaTemplate)
                .WithMany(rtt => rtt.RotinaTreinoTemplate)
                .HasForeignKey(rt => rt.IdRotina);

            builder.HasOne(tt => tt.TreinoTemplate)
                .WithMany(rtt => rtt.RotinaTreinoTemplate)
                .HasForeignKey(tt => tt.IdTreino);
        }
    }
}
