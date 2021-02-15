using System;
using System.ComponentModel.DataAnnotations;
using Gerente.Domain.Enums;

namespace Gerente.Domain.Entities
{
    public class Documento : ControleVersao
    {
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