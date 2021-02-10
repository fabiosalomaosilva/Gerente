using Gerente.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gerente.Infra.Data.EntityConfiguration
{
    public class AgendamentoConfiguration : IEntityTypeConfiguration<Agendamento>
    {
        public void Configure(EntityTypeBuilder<Agendamento> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.CriadoPor).HasMaxLength(100);
            builder.Property(p => p.AlteradoPor).HasMaxLength(100);
            builder.Property(p => p.Titulo).HasMaxLength(100).IsRequired();
            builder.HasOne(p => p.FilaProcedimento).WithMany(b => b.Agendamentos).HasForeignKey(p => p.FilaProcedimentoId);
            builder.Property(p => p.DataInicio).IsRequired();
            builder.Property(p => p.HoraInicio).IsRequired();
            builder.Property(p => p.MensagemNotificacao).HasMaxLength(150);
            builder.Property(p => p.NomePessoaConfirmacao).HasMaxLength(100);
            builder.Property(p => p.Descricao).HasMaxLength(4000);
        }
    }
}