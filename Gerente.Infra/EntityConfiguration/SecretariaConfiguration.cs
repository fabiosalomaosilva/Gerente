using Gerente.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gerente.Infra.Data.EntityConfiguration
{
    public class SecretariaConfiguration : IEntityTypeConfiguration<Secretaria>
    {
        public void Configure(EntityTypeBuilder<Secretaria> builder)
        {
            builder.Property(p => p.Nome).HasMaxLength(150).IsRequired();
            builder.Property(p => p.NomeSimplificado).HasMaxLength(30).IsRequired();
        }
    }
}