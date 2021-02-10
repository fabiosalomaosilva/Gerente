using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Gerente.Domain.Enums;

namespace Gerente.Domain.Entities
{
    public class Contrato
    {
        public int Id { get; set; }
        public string CriadoPor { get; set; }
        public DateTime CriadoEm { get; set; }
        public string AlteradoPor { get; set; }
        public DateTime AlteradoEm { get; set; }
        public bool Ativo { get; set; }
        public TipoInstrumento TipoInstrumento { get; set; }
        public string Numero { get; set; }
        public int FornecedorId { get; set; }
        public virtual Pessoa Fornecedor { get; set; }
        public int RepresentanteId { get; set; }
        public virtual Pessoa Representante { get; set; }
        public ModalidadeLicitacao ModalidadeLicitacao { get; set; }
        public SistemaLicitacao SistemaLicitacao { get; set; }
        public string NumeroLicitacao { get; set; }
        public DateTime DataContrato { get; set; }
        public DateTime DataFinalVigencia { get; set; }
        public string Objeto { get; set; }
        public virtual ICollection<Aditivo> Aditivos { get; set; }
        public virtual ICollection<Documento> Documentos { get; set; }
        public virtual ICollection<Pessoa> Representantes { get; set; }


    }
}