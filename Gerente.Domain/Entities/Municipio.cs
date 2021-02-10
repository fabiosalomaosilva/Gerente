using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gerente.Domain.Entities
{
    public class Municipio : ControleVersao
    {
        public string Nome { get; set; }
        public virtual Estado Estado { get; set; }
        public int EstadoId { get; set; }
        public virtual ICollection<ControleVersaoEndereco> ControleVersaoEnderecos { get; set; }
    }
}