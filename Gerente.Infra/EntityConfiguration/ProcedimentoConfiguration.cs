using Gerente.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gerente.Infra.Data.EntityConfiguration
{
    public class ProcedimentoConfiguration : IEntityTypeConfiguration<Procedimento>
    {
        public void Configure(EntityTypeBuilder<Procedimento> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.CriadoPor).HasMaxLength(100);
            builder.Property(p => p.AlteradoPor).HasMaxLength(100);
            builder.Property(p => p.Nome).HasMaxLength(100).IsRequired();
            builder.HasOne(p => p.Especialidade).WithMany(b => b.Procedimentos).HasForeignKey(p => p.EspecialidadeId);
            builder.Property(p => p.TempoDuracao).HasMaxLength(20).IsRequired();
        }
    }
}