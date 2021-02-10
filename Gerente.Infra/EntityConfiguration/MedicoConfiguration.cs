using Gerente.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gerente.Infra.Data.EntityConfiguration
{
    public class MedicoConfiguration : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.Property(p => p.Nome).HasMaxLength(150).IsRequired();
            builder.HasOne(p => p.LocalProcedimento).WithMany(b => b.Medicos).HasForeignKey(p => p.LocalProcedimentoId);
        }
    }
}