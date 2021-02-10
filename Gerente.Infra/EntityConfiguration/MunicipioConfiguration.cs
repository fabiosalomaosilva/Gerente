using Gerente.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gerente.Infra.Data.EntityConfiguration
{
    public class MunicipioConfiguration : IEntityTypeConfiguration<Municipio>
    {
        public void Configure(EntityTypeBuilder<Municipio> builder)
        {
            builder.Property(p => p.Nome).HasMaxLength(80).IsRequired();
            builder.HasOne(p => p.Estado).WithMany(b => b.Municipios).HasForeignKey(p => p.EstadoId);
        }
    }
}