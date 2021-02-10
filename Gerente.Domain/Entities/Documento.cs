using System;
using System.ComponentModel.DataAnnotations;
using Gerente.Domain.Enums;

namespace Gerente.Domain.Entities
{
    public class Documento
    {
        public int Id { get; set; }
        public string CriadoPor { get; set; }
        public DateTime CriadoEm { get; set; }
        public string AlteradoPor { get; set; }
        public DateTime AlteradoEm { get; set; }
        public bool Ativo { get; set; }
        public string Nome { get; set; }
        public string Url { get; set; }
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public int ContratoId { get; set; }
        public virtual Contrato Contrato { get; set; }
        public  int AditivoId { get; set; }
        public virtual Aditivo Aditivo { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
    }
}