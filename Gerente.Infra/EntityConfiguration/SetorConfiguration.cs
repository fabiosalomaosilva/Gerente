using System;
using Gerente.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gerente.Infra.Data.EntityConfiguration
{
    public class SetorConfiguration : IEntityTypeConfiguration<Setor>
    {
        public void Configure(EntityTypeBuilder<Setor> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.CriadoPor).HasMaxLength(100);
            builder.Property(p => p.AlteradoPor).HasMaxLength(100);
            builder.Property(p => p.Nome).HasMaxLength(150).IsRequired();
            builder.Property(p => p.Email).HasMaxLength(100);
            builder.HasOne(p => p.Secretaria).WithMany(b => b.Setores).HasForeignKey(p => p.SecretariaId);
            
            builder.HasData(new Setor
            {
                Id = 1,
                CriadoPor = "admin",
                AlteradoPor = "admin",
                CriadoEm = DateTime.Now,
                AlteradoEm = DateTime.Now,
                Ativo = true,
                Nome = "Complexo Regulador Estadual",
                Email = "gerenciacomplexo@gmail.com",
                SecretariaId = 1
            });

        }
    }
}