using System.ComponentModel.DataAnnotations;
using Gerente.Domain.Enums;

namespace Gerente.Domain.Entities
{
    public class Documento : ControleVersao
    {
        public string Nome { get; set; }
        public string Url { get; set; }
        public virtual int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
        public virtual int ContratoId { get; set; }
        public Contrato Contrato { get; set; }
        public virtual int AditivoId { get; set; }
        public Aditivo Aditivo { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
    }
}