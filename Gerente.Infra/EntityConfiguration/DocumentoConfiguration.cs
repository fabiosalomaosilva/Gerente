using Gerente.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gerente.Infra.Data.EntityConfiguration
{
    public class DocumentoConfiguration : IEntityTypeConfiguration<Documento>
    {
        public void Configure(EntityTypeBuilder<Documento> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.CriadoPor).HasMaxLength(100);
            builder.Property(p => p.AlteradoPor).HasMaxLength(100);
            builder.Property(p => p.Nome).HasMaxLength(150).IsRequired();
            builder.Property(p => p.Url).HasMaxLength(255).IsRequired();
            builder.HasOne(p => p.Contrato).WithMany(b => b.Documentos).HasForeignKey(p => p.ContratoId);
            builder.HasOne(p => p.Aditivo).WithMany(b => b.Documentos).HasForeignKey(p => p.AditivoId);
            builder.HasOne(p => p.Pessoa).WithMany(b => b.Documentos).HasForeignKey(p => p.PessoaId);
            builder.Property(p => p.TipoDocumento).IsRequired();
        }
    }
}