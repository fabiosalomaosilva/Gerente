using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Gerente.Domain.Enums;

namespace Gerente.Domain.Entities
{
    public class Procedimento
    {
        public int Id { get; set; }
        public string CriadoPor { get; set; }
        public DateTime CriadoEm { get; set; }
        public string AlteradoPor { get; set; }
        public DateTime AlteradoEm { get; set; }
        public bool Ativo { get; set; }
        public string Nome { get; set; }
        public NaturezaProcedimento NaturezaProcedimento { get; set; }
        public int EspecialidadeId { get; set; }
        public virtual Especialidade Especialidade { get; set; }
        public bool DoisMembros { get; set; }
        public DateTime TempoDuracao { get; set; }
        public virtual ICollection<FilaProcedimento> FilaProcedimentos { get; set; }
    }
}