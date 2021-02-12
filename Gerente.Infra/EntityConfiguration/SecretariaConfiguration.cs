using System;
using Gerente.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gerente.Infra.Data.EntityConfiguration
{
    public class SecretariaConfiguration : IEntityTypeConfiguration<Secretaria>
    {
        public void Configure(EntityTypeBuilder<Secretaria> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.CriadoPor).HasMaxLength(100);
            builder.Property(p => p.AlteradoPor).HasMaxLength(100);

            builder.Property(p => p.Logradouro).HasMaxLength(150).IsRequired();
            builder.Property(p => p.Numero).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Bairro).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Complemento).HasMaxLength(100);
            builder.Property(p => p.Cep).HasMaxLength(20);
            builder.HasOne(p => p.Estado).WithMany(b => b.Secretarias).HasForeignKey(p => p.EstadoId);
            builder.HasOne(p => p.Municipio).WithMany(b => b.Secretarias).HasForeignKey(p => p.MunicipioId);

            builder.Property(p => p.Nome).HasMaxLength(150).IsRequired();
            builder.Property(p => p.NomeSimplificado).HasMaxLength(30).IsRequired();
            builder.HasOne(p => p.Estado).WithMany(b => b.Secretarias).HasForeignKey(p => p.EstadoId);
            builder.HasOne(p => p.Municipio).WithMany(b => b.Secretarias).HasForeignKey(p => p.MunicipioId);

            
        }
    }
}