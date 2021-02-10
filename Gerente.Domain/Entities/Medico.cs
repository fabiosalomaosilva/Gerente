using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gerente.Domain.Entities
{
    public class Medico
    {
        public int Id { get; set; }
        public string CriadoPor { get; set; }
        public DateTime CriadoEm { get; set; }
        public string AlteradoPor { get; set; }
        public DateTime AlteradoEm { get; set; }
        public bool Ativo { get; set; }
        public int LocalProcedimentoId { get; set; }
        public virtual LocalProcedimento LocalProcedimento { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<FilaProcedimento> FilaProcedimentos { get; set; }
    }
}