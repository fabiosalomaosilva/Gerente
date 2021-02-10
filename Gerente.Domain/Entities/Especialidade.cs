using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gerente.Domain.Entities
{
    public class Especialidade : ControleVersao
    {
        public string Nome { get; set; }
        public virtual ICollection<FilaProcedimento> FilaProcedimentos { get; set; }
        public virtual ICollection<Procedimento> Procedimentos { get; set; }
        
    }
}