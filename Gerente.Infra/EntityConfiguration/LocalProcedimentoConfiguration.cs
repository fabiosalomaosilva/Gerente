using Gerente.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gerente.Infra.Data.EntityConfiguration
{
    public class LocalProcedimentoConfiguration : IEntityTypeConfiguration<LocalProcedimento>
    {
        public void Configure(EntityTypeBuilder<LocalProcedimento> builder)
        {
            builder.Property(p => p.Nome).HasMaxLength(150).IsRequired();
        }
    }
}