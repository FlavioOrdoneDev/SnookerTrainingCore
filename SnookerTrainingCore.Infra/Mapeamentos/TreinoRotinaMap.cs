using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SnookerTrainingCore.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.Infra.Mapeamentos
{
    public class TreinoRotinaMap : IEntityTypeConfiguration<TreinoRotina>
    {
        public void Configure(EntityTypeBuilder<TreinoRotina> builder)
        {

            builder.HasKey(x => new { x.IdTreino, x.IdRotina });            

            builder.ToTable("TreinoRotinas");
        }
    }
}
