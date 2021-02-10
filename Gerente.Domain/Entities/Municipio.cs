using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gerente.Domain.Entities
{
    public class Municipio
    {
        public int Id { get; set; }
        public string CriadoPor { get; set; }
        public DateTime CriadoEm { get; set; }
        public string AlteradoPor { get; set; }
        public DateTime AlteradoEm { get; set; }
        public bool Ativo { get; set; }
        public string Nome { get; set; }
        public virtual Estado Estado { get; set; }
        public int EstadoId { get; set; }
        public virtual ICollection<LocalProcedimento> LocalProcedimentos { get; set; }
        public virtual ICollection<Pessoa> Pessoas { get; set; }
        public virtual ICollection<Secretaria> Secretarias { get; set; }
    }
}