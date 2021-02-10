using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gerente.Domain.Entities
{
    public class LocalProcedimento : ControleVersaoEndereco
    {
        public string Nome { get; set; }
        public virtual ICollection<Medico> Medicos { get; set; }
        public virtual ICollection<FilaProcedimento> FilaProcedimentos { get; set; }
    }
}