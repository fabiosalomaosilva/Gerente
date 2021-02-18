using System;
using Gerente.Infra.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gerente.Infra.Data.EntityConfiguration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.Property(p => p.NomeCompleto).HasMaxLength(150).IsRequired();
            builder.Property(p => p.Matricula).HasMaxLength(20).IsRequired();
            builder.Property(p => p.Cpf).HasMaxLength(20).IsRequired();
            builder.Property(p => p.Foto).HasMaxLength(255);
            builder.Property(p => p.FotoExtensao).HasMaxLength(10);
            builder.Property(p => p.Sexo).HasMaxLength(20);
            builder.Property(p => p.Secretaria).HasMaxLength(100);
            builder.Property(p => p.SecretariaId).IsRequired();
            builder.Property(p => p.Setor).HasMaxLength(100);
            builder.Property(p => p.SetorId).IsRequired();


        }
    }


}