using Gerente.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gerente.Infra.Data.EntityConfiguration
{
    public class FilaProcedimentoConfiguration : IEntityTypeConfiguration<FilaProcedimento>
    {
        public void Configure(EntityTypeBuilder<FilaProcedimento> builder)
        {
            builder.HasOne(p => p.Paciente).WithMany(b => b.FilaProcedimentos).HasForeignKey(p => p.PacienteId);
            builder.HasOne(p => p.Especialidade).WithMany(b => b.FilaProcedimentos).HasForeignKey(p => p.EspecialidadeId);
            builder.HasOne(p => p.Procedimento).WithMany(b => b.FilaProcedimentos).HasForeignKey(p => p.ProcedimentoId);
            builder.HasOne(p => p.LocalProcedimento).WithMany(b => b.FilaProcedimentos).HasForeignKey(p => p.LocalProcedimentoId);
            builder.HasOne(p => p.Medico).WithMany(b => b.FilaProcedimentos).HasForeignKey(p => p.MedicoId);
            builder.Property(p => p.Prioridade).IsRequired();
            builder.Property(p => p.Status).IsRequired();
            builder.Property(p => p.Observacoes).HasMaxLength(2000);
        }
    }
}