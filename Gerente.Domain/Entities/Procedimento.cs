using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Gerente.Domain.Enums;

namespace Gerente.Domain.Entities
{
    public class Procedimento : ControleVersao
    {
        public string Nome { get; set; }
        public NaturezaProcedimento NaturezaProcedimento { get; set; }
        public int EspecialidadeId { get; set; }
        public virtual Especialidade Especialidade { get; set; }
        public bool DoisMembros { get; set; }
        public string TempoDuracao { get; set; }
        public virtual ICollection<FilaProcedimento> FilaProcedimentos { get; set; }
    }
}