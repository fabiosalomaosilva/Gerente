using Gerente.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gerente.Infra.Data.EntityConfiguration
{
    public class TelefoneConfiguration : IEntityTypeConfiguration<Telefone>
    {
        public void Configure(EntityTypeBuilder<Telefone> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.CriadoPor).HasMaxLength(100);
            builder.Property(p => p.AlteradoPor).HasMaxLength(100);
            builder.Property(p => p.PessoaResponsavel).HasMaxLength(150);
            builder.Property(p => p.Numero).HasMaxLength(30).IsRequired();
            builder.HasOne(p => p.Secretaria).WithMany(b => b.Telefones).HasForeignKey(p => p.SecretariaId);
            builder.HasOne(p => p.Setor).WithMany(b => b.Telefones).HasForeignKey(p => p.SetorId);
            builder.HasOne(p => p.Pessoa).WithMany(b => b.Telefones).HasForeignKey(p => p.PessoaId);
        }
    }
}