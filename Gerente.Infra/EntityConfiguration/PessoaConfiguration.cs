using System;
using Gerente.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gerente.Infra.Data.EntityConfiguration
{
    public class PessoaConfiguration : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.Property(p => p.NomeCompleto).HasMaxLength(150).IsRequired();
            builder.Property(p => p.Email).HasMaxLength(100).IsRequired();
            builder.Property(p => p.DataNascimento).IsRequired();
            builder.Property(p => p.Cpf).HasMaxLength(20).IsRequired();
            builder.HasIndex(p => p.Cpf).IsUnique();
            builder.Property(p => p.CartaoFundhacre).HasMaxLength(20);
            builder.HasIndex(p => p.CartaoFundhacre).IsUnique();
            builder.Property(p => p.CartaoSus).HasMaxLength(30);
            builder.HasIndex(p => p.CartaoSus).IsUnique();
            builder.Property(p => p.Matricula).HasMaxLength(30);
            builder.HasMany(p => p.Acompanhantes).WithOne();
            builder.HasOne(p => p.Secretaria).WithMany(b => b.Servidores).HasForeignKey(p => p.SecretariaId);
        }
    }
}
