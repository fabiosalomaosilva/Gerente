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

            var user = new Usuario
            {
                Id = Guid.NewGuid().ToString(),
                NomeCompleto = "Fábio Salomão Silva Vogth",
                Email = "fabio@arquivarnet.com.br",
                UserName = "fabio@arquivarnet.com.br",
                Matricula = "123456",
                Cpf = "65788974291",
                DataNascimento = Convert.ToDateTime("08/02/1981"),
                SecretariaId = 1,
                SetorId = 1,
                Foto = "https://fundhacre.blob.core.windows.net/avatar/masculino01.png",
                FotoExtensao = ".png",
                Sexo = "Indefinido",
                EmailConfirmed = true
            };
            var ph = new PasswordHasher<Usuario>();
            user.PasswordHash = ph.HashPassword(user, user.Cpf);
            builder.HasData(user);

        }
    }
}