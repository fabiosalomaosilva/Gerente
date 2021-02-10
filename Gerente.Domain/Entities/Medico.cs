using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gerente.Domain.Entities
{
    public class Medico : ControleVersao
    {
        public int LocalProcedimentoId { get; set; }
        public virtual LocalProcedimento LocalProcedimento { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<FilaProcedimento> FilaProcedimentos { get; set; }
    }
}