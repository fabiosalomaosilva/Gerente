using Gerente.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gerente.Infra.Data.EntityConfiguration
{
    public class ContratoConfiguration : IEntityTypeConfiguration<Contrato>
    {
        public void Configure(EntityTypeBuilder<Contrato> builder)
        {
            builder.Property(p => p.Numero).HasMaxLength(40).IsRequired();
            builder.HasOne(p => p.Fornecedor).WithMany(b => b.Contratos).HasForeignKey(p => p.FornecedorId);
            builder.Property(p => p.ModalidadeLicitacao).IsRequired();
            builder.Property(p => p.SistemaLicitacao).IsRequired();
            builder.Property(p => p.ModalidadeLicitacao).IsRequired();
            builder.Property(p => p.DataContrato).IsRequired();
            builder.Property(p => p.DataFinalVigencia).IsRequired();
            builder.Property(p => p.Objeto).HasMaxLength(4000).IsRequired();
            builder.Property(p => p.NumeroLicitacao).HasMaxLength(20).IsRequired();
        }
    }
}