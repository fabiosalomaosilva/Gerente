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
            builder.HasKey(p => p.Id);
            builder.Property(p => p.CriadoPor).HasMaxLength(100);
            builder.Property(p => p.AlteradoPor).HasMaxLength(100);

            builder.Property(p => p.Logradouro).HasMaxLength(150).IsRequired();
            builder.Property(p => p.Numero).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Bairro).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Complemento).HasMaxLength(100);
            builder.Property(p => p.Cep).HasMaxLength(20);
            builder.HasOne(p => p.Estado).WithMany(b => b.Pessoas).HasForeignKey(p => p.EstadoId);
            builder.HasOne(p => p.Municipio).WithMany(b => b.Pessoas).HasForeignKey(p => p.MunicipioId);
            
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
            builder.HasMany(p => p.Representantes).WithOne();
            builder.HasOne(p => p.Secretaria).WithMany(b => b.Servidores).HasForeignKey(p => p.SecretariaId);
            builder.HasOne(p => p.Setor).WithMany(b => b.Servidores).HasForeignKey(p => p.SetorId);
            builder.HasOne(p => p.Estado).WithMany(b => b.Pessoas).HasForeignKey(p => p.EstadoId);
            builder.HasOne(p => p.Municipio).WithMany(b => b.Pessoas).HasForeignKey(p => p.MunicipioId);
        }
    }
}
