using System;
using Gerente.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gerente.Infra.Data.EntityConfiguration
{
    public class MunicipioConfiguration : IEntityTypeConfiguration<Municipio>
    {
        public void Configure(EntityTypeBuilder<Municipio> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.CriadoPor).HasMaxLength(100);
            builder.Property(p => p.AlteradoPor).HasMaxLength(100);
            builder.Property(p => p.Nome).HasMaxLength(80).IsRequired();
            builder.HasOne(p => p.Estado).WithMany(b => b.Municipios).HasForeignKey(p => p.EstadoId);

            builder.HasData(new Municipio
            {
                Id = 1,
                CriadoPor = "admin",
                AlteradoPor = "admin",
                CriadoEm = DateTime.Now,
                AlteradoEm = DateTime.Now,
                Ativo = true,
                Nome = "Rio Branco",
                EstadoId = 1
            });
        }
    }
}