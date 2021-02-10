using Gerente.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gerente.Infra.Data.EntityConfiguration
{
    public class AditivoConfiguration : IEntityTypeConfiguration<Aditivo>
    {
        public void Configure(EntityTypeBuilder<Aditivo> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.CriadoPor).HasMaxLength(100);
            builder.Property(p => p.AlteradoPor).HasMaxLength(100);
            builder.Property(p => p.Numero).HasMaxLength(40).IsRequired();
            builder.HasOne(p => p.Contrato).WithMany(b => b.Aditivos).HasForeignKey(p => p.ContratoId);
            builder.Property(p => p.DataAditivo).IsRequired();
            builder.Property(p => p.MesesAcrescidos).IsRequired();
            builder.Property(p => p.Objeto).HasMaxLength(1000).IsRequired();
        }
    }
}