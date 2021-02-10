using Gerente.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gerente.Infra.Data.EntityConfiguration
{
    public class AuditoriaConfiguration : IEntityTypeConfiguration<Auditoria>
    {
        public void Configure(EntityTypeBuilder<Auditoria> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasIndex(p => p.Id).IsUnique();
            builder.Property(p => p.Id).HasMaxLength(45).IsRequired();
            builder.Property(p => p.Tabela).HasMaxLength(30);
            builder.Property(p => p.Operacao).HasMaxLength(20);
            builder.Property(p => p.Valor).HasMaxLength(1500);
            builder.Property(p => p.AuditadoEm).HasMaxLength(100);
        }
    }
}