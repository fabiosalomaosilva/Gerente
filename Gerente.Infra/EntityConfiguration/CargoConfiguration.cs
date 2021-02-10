using Gerente.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gerente.Infra.Data.EntityConfiguration
{
    public class CargoConfiguration : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(EntityTypeBuilder<Cargo> builder)
        {
            builder.Property(p => p.Nome).HasMaxLength(100).IsRequired();
            builder.HasOne(p => p.Secretaria).WithMany(b => b.Cargos).HasForeignKey(p => p.SecretariaId);
            builder.HasOne(p => p.Setor).WithMany(b => b.Cargos).HasForeignKey(p => p.SetorId);
        }
    }
}